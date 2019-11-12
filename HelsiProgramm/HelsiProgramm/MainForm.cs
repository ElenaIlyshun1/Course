using HelsiProgramm.UseControl;
using ServiceDLL.Concrete;
using ServiceDLL.Models;
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


namespace HelsiProgramm
{
    public partial class MainForm : Form
    {
        string EmailSearch;
        ContactProfil contactProfil;
        ClientApiService clientApi = new ClientApiService();
        public MainForm(string email)
        {
            EmailSearch = email;
            InitializeComponent();
            SidePanel.Height = btnClinic.Height;
            SidePanel.Top = btnClinic.Top;

            //================================
            var listclients = clientApi.GetClients();
            foreach (var p in listclients)
            {
                object[] row = { p.Id, p.Name, p.Surname, p.DateBirthday };
                dgwClients.Rows.Add(row);
            }

            //================================
           ClinicApiService clinicApi = new ClinicApiService();
            var listclinic = clinicApi.GetClinics();
            foreach (var p in listclinic)
            {
                object[] row = { p.Id,p.City, p.Name, p.Street };
                dvgClinics.Rows.Add(row);
            }
            //=============================

            CityApiService cityApi = new CityApiService();
            var listcity = cityApi.GetCities();
            foreach (var p in listcity)
            {
                object[] row = { p.Id, p.Name};
                dvgCity.Rows.Add(row);
            }
            //========================================
            DoctorApiService doctorApi = new DoctorApiService();
            var listdoctor = doctorApi.GetDoctor();
            foreach (var p in listdoctor)
            {
                object[] row = { p.Id, p.Name, p.Surname, p.DateBirthday.ToShortDateString() };
                dvgDoctor.Rows.Add(row);
            }
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


        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            var listcl = clientApi.GetClients();
            foreach (var p in listcl)
            {
                if (p.Email == EmailSearch)
                {

                    contactProfil = new ContactProfil(p.Name, p.Surname, p.DateBirthday.ToString());
                    this.Controls.Add(contactProfil);
                    contactProfil.Location = new Point(209, 0);
                    contactProfil.BringToFront();
                    break;
                }
            }
            SidePanel.Height = btnContact.Height;
            SidePanel.Top = btnContact.Top;
            contactProfil.BringToFront();
           
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
            dvgDoctor.BringToFront();
        }

       

        private void dvgCity_SelectionChanged(object sender, EventArgs e)
        {
          /* 
            

            ClinicApiService clinicApi = new ClinicApiService();
            var listclinic = clinicApi.GetClinics();



            foreach (var p in listclinic)
            {
                if (dvgCity.SelectedColumns == p.City)
                {

                }
                object[] row = { p.Id, p.Name, p.Street };
                dvgClinics.Rows.Add(row);
            }*/
        }
    }
}
