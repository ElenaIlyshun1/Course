using HelsiProgramm.ViewModels;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ServiceDLL.Models.ClinicsModel;

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

      
        private void UserAdd()
        {
            if (txtName.Text == "" && txtSur.Text == "" && txtEmail.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please, fill all lines.");
            }
            else
            {





                //if (tbPassword.Password != tbConfirmPassword.Password)
                //{
                //    tbWarningPassword.Text = "Пароль не співпадає";
                //    tbWarningConfirmPassword.Text = "Пароль не співпадає";
                //    return;
                //}
                //if (tbFirstName.Text == tbLastName.Text && tbFirstName.Text != "")
                //{
                //    tbWarningFirstName.Text = "Поле FirstName та LastName не можуть співпадати";
                //    tbWarningLastName.Text = "Поле FirstName та LastName не можуть співпадати";
                //    return;
                //}

                // відправляємо модель на сервер
                AccountApiService service = new AccountApiService();

                var client =  service.Register(new ClientAddVM
                {
                    Name = txtName.Text,
                    Surname = txtSur.Text,
                    DateBirthday = DatePicker.Value,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text
                });
            }
        }

    }
}

