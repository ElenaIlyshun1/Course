using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelsiProgramm
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {    
            this.Close();
        }

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
    }
}
