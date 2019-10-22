using HelsiProgramm.UseControl;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SidePanel.Height = btnClinic.Height;
            SidePanel.Top = btnClinic.Top;
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClinic_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnClinic.Height;
            SidePanel.Top = btnClinic.Top;
        }

        private void btnReform_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnReform.Height;
            SidePanel.Top = btnReform.Top;
        }

        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BtnDoctor.Height;
            SidePanel.Top = BtnDoctor.Top;
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            ContactProfil contactProfil = new ContactProfil("Vova","Novak","1989", "https://medialeaks.ru/wp-content/uploads/2018/07/2_MPM_DRUNK_LEMUR_03-305x449.jpg");
            this.Controls.Add(contactProfil);
            contactProfil.Location = new Point(237, 61); 
            SidePanel.Height = btnContact.Height;
            SidePanel.Top = btnContact.Top;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAbout.Height;
            SidePanel.Top = btnAbout.Top;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSchedule.Height;
            SidePanel.Top = btnSchedule.Top;
        }

      
    }
}
