using HelsiProgramm.UseControl;
using ServiceDLL.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ServiceDLL.Models.ClientModel;
using ServiceDLL.Concrete;
using static ServiceDLL.Concrete.ClientApiService;

namespace HelsiProgramm
{
    public partial class MainForm : Form
    {
        List<ClinicModels> clinic;
        public MainForm()
        {
            InitializeComponent();
            SidePanel.Height = btnClinic.Height;
            SidePanel.Top = btnClinic.Top;

        }
        public MainForm(List<ClinicModels> _clinic)
        {
            InitializeComponent();

            clinic = _clinic;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClinic_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnClinic.Height;
            SidePanel.Top = btnClinic.Top;
            dvgClinics.BringToFront();

            ClientApiService service = new ClientApiService();
            var list = service.GetClinics();
            foreach (var p in list)
            {
                object[] row = { p.Id, p.Name, p.Street };
                dvgClinics.Rows.Add(row);
            }



            //foreach (var p in clinic)
            //{
            //    object[] row = { p.Id, p.Name, p.Street };
            //    dgvProducts.Rows.Add(row);
            //}

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
            dvgDoctor.BringToFront();
            ClientApiService service = new ClientApiService();
            var list = service.GetClinics();
            foreach (var p in list)
            {
                object[] row = { p.Id, p.Name, p.Street };
                dvgDoctor.Rows.Add(row);
            }
            
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            ContactProfil contactProfil = new ContactProfil("Vova", "Novak", "1989", "https://medialeaks.ru/wp-content/uploads/2018/07/2_MPM_DRUNK_LEMUR_03-305x449.jpg");
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
