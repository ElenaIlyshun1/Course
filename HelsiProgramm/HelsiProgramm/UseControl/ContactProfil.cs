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
        public ContactProfil(string name, string surname, string birth,string image)
        {
            InitializeComponent();
            txtName.Text = name;
            txtSurname.Text = surname;
            txtDateOfBirth.Text = birth;
            var request = WebRequest.Create(image);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                Photo.BackgroundImage = Bitmap.FromStream(stream);
            }
            Photo.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
