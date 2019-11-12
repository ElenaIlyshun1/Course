using HelsiProgramm.ViewModels;
using Newtonsoft.Json;
using ServiceDLL.Concrete;
using ServiceDLL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ServiceDLL.Models.ClientModel;
using System.IdentityModel.Tokens.Jwt;

namespace HelsiProgramm
{
    public partial class RegisterForm : Form
    {
        private ObservableCollection<ClientViewModels> ClientVM { get; set; }
        public bool check = false;
        public string ImgName;
        string imageFolderSave = "ClientsPictures";
        string PathImagDic;
        public RegisterForm()
        {
            InitializeComponent();
            PathImagDic = System.IO.Path.Combine(Directory.GetCurrentDirectory(), imageFolderSave);
            ClientVM = new ObservableCollection<ClientViewModels>();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UserAdd();

        }
        #region Design
        private void PrivacyPolicyLabel_MouseMove(object sender, MouseEventArgs e)
        {
            PrivacyPolicyLabel.ForeColor = Color.Red;
        }

        private void PrivacyPolicyLabel_MouseLeave(object sender, EventArgs e)
        {
            PrivacyPolicyLabel.ForeColor = Color.Teal;
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }
        #endregion
        //=======================================
        static async void WriteSomeTextAsync(string text)
        {
            string Filepath = @"Token.txt";

            using (StreamWriter SR = new StreamWriter(Filepath))
            {
                await SR.WriteAsync(text);
            }
        }

        private void UserAdd()
        {
            lblNameError.Text = "";
            lblSurnameError.Text = "";
            lblBateBirtdayError.Text = "";
            lblEmailError.Text = "";
            lblPasswordError.Text = "";
            if (txtName.Text == "" && txtSur.Text == "" && txtEmail.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please, fill all lines.");
            }
            else
            {

                // відправляємо модель на сервер
                AccountApiService service = new AccountApiService();
                try
                {
                    var token = service.Register(new ClientAddVM
                    {
                        Name = txtName.Text,
                        Surname = txtSur.Text,
                        DateBirthday = DatePicker.Value,
                        Password = txtPassword.Text,
                        Email = txtEmail.Text
                    });

                    var tokenStr = token;
                    var handler = new JwtSecurityTokenHandler();
                    var tokenJwtSec = handler.ReadToken(tokenStr) as JwtSecurityToken;

                    Dictionary<string, string> user = new Dictionary<string, string>();

                   

                    WriteSomeTextAsync(txtEmail.Text + " " + token);
                    this.Close();

                }
                catch (WebException wex)
                {
                    if (wex.Response != null)
                    {
                        using (var errorResponse = (HttpWebResponse)wex.Response)
                        {
                            using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                            {
                                string error = reader.ReadToEnd();
                               
                                var mes = JsonConvert.DeserializeAnonymousType(error, new
                                {        
                                    
                                    Name = "",                                    
                                    Surname = "",
                                    DateBirthday = "",
                                    Password = "",
                                    Email = " ",
                                   
                                });

                                var invalidInfo = new { invalid = "" };
                                invalidInfo = JsonConvert.DeserializeAnonymousType(error, invalidInfo);
                                Console.BackgroundColor = ConsoleColor.Red;
                                MessageBox.Show(invalidInfo.invalid.ToUpper());
                                Console.BackgroundColor = ConsoleColor.White;

                                if (mes.Name != null)
                                {
                                    lblNameError.Text = mes.Name;
                                }
                                if (mes.Surname != null)
                                {
                                    lblSurnameError.Text = mes.Surname;
                                }
                                if (mes.DateBirthday != null)
                                {
                                    lblBateBirtdayError.Text = mes.DateBirthday;
                                }
                                if (mes.Password != null)
                                {
                                    lblPasswordError.Text = mes.Password;
                                }
                                if (mes.Email != null)
                                {
                                    lblEmailError.Text = mes.Email;
                                }

                                lblNameError.ForeColor = Color.Red;
                                lblSurnameError.ForeColor = Color.Red;
                                lblBateBirtdayError.ForeColor = Color.Red;
                                lblEmailError.ForeColor = Color.Red;
                                lblPasswordError.ForeColor = Color.Red;
                                lblPrivacyError.ForeColor = Color.Red;
                                //TODO: use JSON.net to parse this string and look at the error message
                            }
                        }
                    }
                   // MessageBox.Show("Гюстон у нас проблеми");
                }

            }
        }

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {
            bool result = txtName.Text.All(Char.IsLetter);
            if (result==true)
            {
                txtName.LineFocusedColor = Color.Green;
                txtName.LineIdleColor = Color.LightGreen;
            }
            else
            {
                txtName.LineFocusedColor = Color.Red;
                txtName.LineIdleColor = Color.Red;
            }
        }

        private void txtSur_OnValueChanged(object sender, EventArgs e)
        {
            bool result = txtSur.Text.All(Char.IsLetter);
            if (result == true)
            {
                txtSur.LineFocusedColor = Color.Green;
                txtSur.LineIdleColor = Color.LightGreen;
            }
            else
            {
                txtSur.LineFocusedColor = Color.Red;
                txtSur.LineIdleColor = Color.Red;
            }
        }
    }
}

