using Newtonsoft.Json;
using ServiceDLL.Concrete;
using ServiceDLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelsiProgramm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        #region DESIGN
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
            if (txtEmail.Text == "" && txtPswd.Text == "")
            {
                MessageBox.Show("Please, fill all lines.");
            }
            else
            {
                lblErrorEmail.Text = "";
                lblErrorPassword.Text = "";
                // відправляємо модель на сервер
                AccountApiService service = new AccountApiService();
                try
                {
                    var token = service.Login(new UserLoginVM
                    {
                        Password = txtPswd.Text,
                        Email = txtEmail.Text
                    });

                    var tokenStr = token;
                    var handler = new JwtSecurityTokenHandler();
                    var tokenJwtSec = handler.ReadToken(tokenStr) as JwtSecurityToken;

                    //Dictionary<string, string> user = new Dictionary<string, string>();

                    //foreach (var item in tokenJwtSec.Claims)
                    //{
                    //    //if (item.Type != "Id" && item.Type != "exp")
                    //    //MessageBox.Show(item.Type, item.Value);
                    //    //user.Add(item.Type, item.Value);
                    //}
                    //// WriteSomeTextAsync(txtEmail.Text + " " + token);
                    ///
                    
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
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
                                var error = reader.ReadToEnd();
                                var mes = JsonConvert.DeserializeAnonymousType(error, new
                                {
                                    Email = "",
                                    Password = ""
                                });
                                if (mes.Email != null)
                                {
                                    lblErrorEmail.Text = mes.Email;
                                }
                                if (mes.Password != null)
                                {                         
                                    lblErrorPassword.Text = mes.Password;
                                }
                                if (mes.Password == null)
                                {
                                    lblErrorPassword.Text = "Невірно введені дані!";                                 
                                }

                                lblErrorEmail.ForeColor = Color.Red;
                                lblErrorPassword.ForeColor = Color.Red;
                            }
                        }
                    }
                }

            }
            
        }

        private void txtPswd_OnValueChanged(object sender, EventArgs e)
        {
            txtPswd.isPassword = true;
        }

    }
    #endregion
}