using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace HelsiProgramm.UseControl
{
    public partial class ContactProfil : UserControl
    {  
        public ContactProfil(string name, string surname, string birth)
        {
            InitializeComponent();
            txtName.Text = name;
            txtSurname.Text = surname;
            txtDateOfBirth.Text = birth;
          
        }

        private void ContactProfil_Load(object sender, EventArgs e)
        {

        }
    }
}
