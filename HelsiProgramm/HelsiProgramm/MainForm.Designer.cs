namespace HelsiProgramm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSchedule = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAbout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnContact = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnDoctor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReform = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClinic = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dvgClinics = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgDoctor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwClients = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCity = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pShedule = new System.Windows.Forms.Panel();
            this.btnConfirmShedule = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBirthDoctor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSurnameDoctor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNameDoctor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBirthClient = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSurNameClient = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNameClient = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dateShedulePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dvgShedules = new System.Windows.Forms.DataGridView();
            this.ID_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pacient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeShedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgShedule = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClinics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCity)).BeginInit();
            this.pShedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgShedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgShedule)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.SeaGreen;
            this.SidePanel.Location = new System.Drawing.Point(1, 61);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 60);
            this.SidePanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.btnSchedule);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnContact);
            this.panel1.Controls.Add(this.BtnDoctor);
            this.panel1.Controls.Add(this.btnReform);
            this.panel1.Controls.Add(this.btnClinic);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 660);
            this.panel1.TabIndex = 1;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSchedule.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSchedule.BorderRadius = 0;
            this.btnSchedule.ButtonText = "   Schedule";
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.DisabledColor = System.Drawing.Color.Gray;
            this.btnSchedule.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSchedule.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSchedule.Iconimage")));
            this.btnSchedule.Iconimage_right = null;
            this.btnSchedule.Iconimage_right_Selected = null;
            this.btnSchedule.Iconimage_Selected = null;
            this.btnSchedule.IconMarginLeft = 0;
            this.btnSchedule.IconMarginRight = 0;
            this.btnSchedule.IconRightVisible = true;
            this.btnSchedule.IconRightZoom = 0D;
            this.btnSchedule.IconVisible = true;
            this.btnSchedule.IconZoom = 90D;
            this.btnSchedule.IsTab = false;
            this.btnSchedule.Location = new System.Drawing.Point(12, 325);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Normalcolor = System.Drawing.Color.DarkSeaGreen;
            this.btnSchedule.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSchedule.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSchedule.selected = false;
            this.btnSchedule.Size = new System.Drawing.Size(197, 60);
            this.btnSchedule.TabIndex = 10;
            this.btnSchedule.Text = "   Schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Textcolor = System.Drawing.Color.White;
            this.btnSchedule.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAbout.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.BorderRadius = 0;
            this.btnAbout.ButtonText = "   About";
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.DisabledColor = System.Drawing.Color.Gray;
            this.btnAbout.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAbout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAbout.Iconimage")));
            this.btnAbout.Iconimage_right = null;
            this.btnAbout.Iconimage_right_Selected = null;
            this.btnAbout.Iconimage_Selected = null;
            this.btnAbout.IconMarginLeft = 0;
            this.btnAbout.IconMarginRight = 0;
            this.btnAbout.IconRightVisible = true;
            this.btnAbout.IconRightZoom = 0D;
            this.btnAbout.IconVisible = true;
            this.btnAbout.IconZoom = 90D;
            this.btnAbout.IsTab = false;
            this.btnAbout.Location = new System.Drawing.Point(12, 391);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Normalcolor = System.Drawing.Color.DarkSeaGreen;
            this.btnAbout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAbout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAbout.selected = false;
            this.btnAbout.Size = new System.Drawing.Size(197, 60);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "   About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Textcolor = System.Drawing.Color.White;
            this.btnAbout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnContact
            // 
            this.btnContact.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnContact.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContact.BorderRadius = 0;
            this.btnContact.ButtonText = "   Contact";
            this.btnContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContact.DisabledColor = System.Drawing.Color.Gray;
            this.btnContact.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.Iconcolor = System.Drawing.Color.Transparent;
            this.btnContact.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnContact.Iconimage")));
            this.btnContact.Iconimage_right = null;
            this.btnContact.Iconimage_right_Selected = null;
            this.btnContact.Iconimage_Selected = null;
            this.btnContact.IconMarginLeft = 0;
            this.btnContact.IconMarginRight = 0;
            this.btnContact.IconRightVisible = true;
            this.btnContact.IconRightZoom = 0D;
            this.btnContact.IconVisible = true;
            this.btnContact.IconZoom = 90D;
            this.btnContact.IsTab = false;
            this.btnContact.Location = new System.Drawing.Point(12, 259);
            this.btnContact.Name = "btnContact";
            this.btnContact.Normalcolor = System.Drawing.Color.DarkSeaGreen;
            this.btnContact.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnContact.OnHoverTextColor = System.Drawing.Color.White;
            this.btnContact.selected = false;
            this.btnContact.Size = new System.Drawing.Size(197, 60);
            this.btnContact.TabIndex = 8;
            this.btnContact.Text = "   Contact";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Textcolor = System.Drawing.Color.White;
            this.btnContact.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // BtnDoctor
            // 
            this.BtnDoctor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnDoctor.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoctor.BorderRadius = 0;
            this.BtnDoctor.ButtonText = "   Doctor";
            this.BtnDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDoctor.DisabledColor = System.Drawing.Color.Gray;
            this.BtnDoctor.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoctor.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDoctor.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnDoctor.Iconimage")));
            this.BtnDoctor.Iconimage_right = null;
            this.BtnDoctor.Iconimage_right_Selected = null;
            this.BtnDoctor.Iconimage_Selected = null;
            this.BtnDoctor.IconMarginLeft = 0;
            this.BtnDoctor.IconMarginRight = 0;
            this.BtnDoctor.IconRightVisible = true;
            this.BtnDoctor.IconRightZoom = 0D;
            this.BtnDoctor.IconVisible = true;
            this.BtnDoctor.IconZoom = 90D;
            this.BtnDoctor.IsTab = false;
            this.BtnDoctor.Location = new System.Drawing.Point(12, 193);
            this.BtnDoctor.Name = "BtnDoctor";
            this.BtnDoctor.Normalcolor = System.Drawing.Color.DarkSeaGreen;
            this.BtnDoctor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnDoctor.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnDoctor.selected = false;
            this.BtnDoctor.Size = new System.Drawing.Size(197, 60);
            this.BtnDoctor.TabIndex = 7;
            this.BtnDoctor.Text = "   Doctor";
            this.BtnDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDoctor.Textcolor = System.Drawing.Color.White;
            this.BtnDoctor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoctor.Click += new System.EventHandler(this.BtnDoctor_Click);
            // 
            // btnReform
            // 
            this.btnReform.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReform.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReform.BorderRadius = 0;
            this.btnReform.ButtonText = "   Medical Reform ";
            this.btnReform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReform.DisabledColor = System.Drawing.Color.Gray;
            this.btnReform.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReform.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReform.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReform.Iconimage")));
            this.btnReform.Iconimage_right = null;
            this.btnReform.Iconimage_right_Selected = null;
            this.btnReform.Iconimage_Selected = null;
            this.btnReform.IconMarginLeft = 0;
            this.btnReform.IconMarginRight = 0;
            this.btnReform.IconRightVisible = true;
            this.btnReform.IconRightZoom = 0D;
            this.btnReform.IconVisible = true;
            this.btnReform.IconZoom = 90D;
            this.btnReform.IsTab = false;
            this.btnReform.Location = new System.Drawing.Point(12, 127);
            this.btnReform.Name = "btnReform";
            this.btnReform.Normalcolor = System.Drawing.Color.DarkSeaGreen;
            this.btnReform.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReform.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReform.selected = false;
            this.btnReform.Size = new System.Drawing.Size(197, 60);
            this.btnReform.TabIndex = 6;
            this.btnReform.Text = "   Medical Reform ";
            this.btnReform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReform.Textcolor = System.Drawing.Color.White;
            this.btnReform.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReform.Click += new System.EventHandler(this.btnReform_Click);
            // 
            // btnClinic
            // 
            this.btnClinic.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClinic.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClinic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClinic.BorderRadius = 0;
            this.btnClinic.ButtonText = "   Clinic";
            this.btnClinic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClinic.DisabledColor = System.Drawing.Color.Gray;
            this.btnClinic.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinic.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClinic.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClinic.Iconimage")));
            this.btnClinic.Iconimage_right = null;
            this.btnClinic.Iconimage_right_Selected = null;
            this.btnClinic.Iconimage_Selected = null;
            this.btnClinic.IconMarginLeft = 0;
            this.btnClinic.IconMarginRight = 0;
            this.btnClinic.IconRightVisible = true;
            this.btnClinic.IconRightZoom = 0D;
            this.btnClinic.IconVisible = true;
            this.btnClinic.IconZoom = 90D;
            this.btnClinic.IsTab = false;
            this.btnClinic.Location = new System.Drawing.Point(12, 61);
            this.btnClinic.Name = "btnClinic";
            this.btnClinic.Normalcolor = System.Drawing.Color.DarkSeaGreen;
            this.btnClinic.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnClinic.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClinic.selected = false;
            this.btnClinic.Size = new System.Drawing.Size(197, 60);
            this.btnClinic.TabIndex = 5;
            this.btnClinic.Text = "   Clinic";
            this.btnClinic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinic.Textcolor = System.Drawing.Color.White;
            this.btnClinic.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinic.Click += new System.EventHandler(this.btnClinic_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(901, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 21);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 11;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 30);
            this.panel2.TabIndex = 12;
            // 
            // dvgClinics
            // 
            this.dvgClinics.AllowUserToAddRows = false;
            this.dvgClinics.AllowUserToDeleteRows = false;
            this.dvgClinics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClinics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.city,
            this.ColName,
            this.street});
            this.dvgClinics.Location = new System.Drawing.Point(209, 28);
            this.dvgClinics.Margin = new System.Windows.Forms.Padding(4);
            this.dvgClinics.Name = "dvgClinics";
            this.dvgClinics.ReadOnly = true;
            this.dvgClinics.RowTemplate.Height = 24;
            this.dvgClinics.Size = new System.Drawing.Size(926, 632);
            this.dvgClinics.TabIndex = 13;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // city
            // 
            this.city.HeaderText = "Місто";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.FillWeight = 60F;
            this.ColName.HeaderText = "Назва";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // street
            // 
            this.street.HeaderText = "Вулиця";
            this.street.Name = "street";
            this.street.ReadOnly = true;
            this.street.Width = 500;
            // 
            // dvgDoctor
            // 
            this.dvgDoctor.AllowUserToAddRows = false;
            this.dvgDoctor.AllowUserToDeleteRows = false;
            this.dvgDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.datebirth});
            this.dvgDoctor.Location = new System.Drawing.Point(209, 28);
            this.dvgDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.dvgDoctor.Name = "dvgDoctor";
            this.dvgDoctor.ReadOnly = true;
            this.dvgDoctor.RowTemplate.Height = 24;
            this.dvgDoctor.Size = new System.Drawing.Size(926, 632);
            this.dvgDoctor.TabIndex = 14;
            this.dvgDoctor.SelectionChanged += new System.EventHandler(this.dvgDoctor_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 60F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Ім\'я";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Прізвище";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 500;
            // 
            // datebirth
            // 
            this.datebirth.HeaderText = "Дата народження";
            this.datebirth.Name = "datebirth";
            this.datebirth.ReadOnly = true;
            // 
            // dgwClients
            // 
            this.dgwClients.AllowUserToAddRows = false;
            this.dgwClients.AllowUserToDeleteRows = false;
            this.dgwClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgwClients.Location = new System.Drawing.Point(209, 28);
            this.dgwClients.Margin = new System.Windows.Forms.Padding(4);
            this.dgwClients.Name = "dgwClients";
            this.dgwClients.ReadOnly = true;
            this.dgwClients.RowTemplate.Height = 24;
            this.dgwClients.Size = new System.Drawing.Size(926, 632);
            this.dgwClients.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.FillWeight = 60F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Ім\'я";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Прізвище";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 500;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата народження";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dvgCity
            // 
            this.dvgCity.AllowUserToAddRows = false;
            this.dvgCity.AllowUserToDeleteRows = false;
            this.dvgCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dvgCity.Location = new System.Drawing.Point(209, 28);
            this.dvgCity.Margin = new System.Windows.Forms.Padding(4);
            this.dvgCity.Name = "dvgCity";
            this.dvgCity.ReadOnly = true;
            this.dvgCity.RowTemplate.Height = 24;
            this.dvgCity.Size = new System.Drawing.Size(926, 632);
            this.dvgCity.TabIndex = 16;
            this.dvgCity.SelectionChanged += new System.EventHandler(this.dvgCity_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.FillWeight = 60F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // pShedule
            // 
            this.pShedule.BackColor = System.Drawing.Color.Gainsboro;
            this.pShedule.Controls.Add(this.btnConfirmShedule);
            this.pShedule.Controls.Add(this.txtBirthDoctor);
            this.pShedule.Controls.Add(this.txtSurnameDoctor);
            this.pShedule.Controls.Add(this.txtNameDoctor);
            this.pShedule.Controls.Add(this.txtBirthClient);
            this.pShedule.Controls.Add(this.txtSurNameClient);
            this.pShedule.Controls.Add(this.txtNameClient);
            this.pShedule.Controls.Add(this.dateShedulePicker);
            this.pShedule.Location = new System.Drawing.Point(209, 30);
            this.pShedule.Name = "pShedule";
            this.pShedule.Size = new System.Drawing.Size(926, 663);
            this.pShedule.TabIndex = 17;
            // 
            // btnConfirmShedule
            // 
            this.btnConfirmShedule.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnConfirmShedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnConfirmShedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmShedule.BorderRadius = 0;
            this.btnConfirmShedule.ButtonText = "                  Confirm";
            this.btnConfirmShedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmShedule.DisabledColor = System.Drawing.Color.Gray;
            this.btnConfirmShedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirmShedule.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConfirmShedule.Iconimage = null;
            this.btnConfirmShedule.Iconimage_right = null;
            this.btnConfirmShedule.Iconimage_right_Selected = null;
            this.btnConfirmShedule.Iconimage_Selected = null;
            this.btnConfirmShedule.IconMarginLeft = 0;
            this.btnConfirmShedule.IconMarginRight = 0;
            this.btnConfirmShedule.IconRightVisible = true;
            this.btnConfirmShedule.IconRightZoom = 0D;
            this.btnConfirmShedule.IconVisible = true;
            this.btnConfirmShedule.IconZoom = 90D;
            this.btnConfirmShedule.IsTab = false;
            this.btnConfirmShedule.Location = new System.Drawing.Point(322, 503);
            this.btnConfirmShedule.Name = "btnConfirmShedule";
            this.btnConfirmShedule.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnConfirmShedule.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnConfirmShedule.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConfirmShedule.selected = false;
            this.btnConfirmShedule.Size = new System.Drawing.Size(281, 48);
            this.btnConfirmShedule.TabIndex = 8;
            this.btnConfirmShedule.Text = "                  Confirm";
            this.btnConfirmShedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmShedule.Textcolor = System.Drawing.Color.White;
            this.btnConfirmShedule.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmShedule.Click += new System.EventHandler(this.btnConfirmShedule_Click);
            // 
            // txtBirthDoctor
            // 
            this.txtBirthDoctor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBirthDoctor.Enabled = false;
            this.txtBirthDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBirthDoctor.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.txtBirthDoctor.HintForeColor = System.Drawing.Color.Empty;
            this.txtBirthDoctor.HintText = "";
            this.txtBirthDoctor.isPassword = false;
            this.txtBirthDoctor.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtBirthDoctor.LineIdleColor = System.Drawing.Color.DarkSeaGreen;
            this.txtBirthDoctor.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtBirthDoctor.LineThickness = 3;
            this.txtBirthDoctor.Location = new System.Drawing.Point(623, 191);
            this.txtBirthDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirthDoctor.Name = "txtBirthDoctor";
            this.txtBirthDoctor.Size = new System.Drawing.Size(278, 44);
            this.txtBirthDoctor.TabIndex = 7;
            this.txtBirthDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSurnameDoctor
            // 
            this.txtSurnameDoctor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurnameDoctor.Enabled = false;
            this.txtSurnameDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSurnameDoctor.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.txtSurnameDoctor.HintForeColor = System.Drawing.Color.Empty;
            this.txtSurnameDoctor.HintText = "";
            this.txtSurnameDoctor.isPassword = false;
            this.txtSurnameDoctor.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtSurnameDoctor.LineIdleColor = System.Drawing.Color.DarkSeaGreen;
            this.txtSurnameDoctor.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtSurnameDoctor.LineThickness = 3;
            this.txtSurnameDoctor.Location = new System.Drawing.Point(623, 113);
            this.txtSurnameDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurnameDoctor.Name = "txtSurnameDoctor";
            this.txtSurnameDoctor.Size = new System.Drawing.Size(278, 44);
            this.txtSurnameDoctor.TabIndex = 6;
            this.txtSurnameDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNameDoctor
            // 
            this.txtNameDoctor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameDoctor.Enabled = false;
            this.txtNameDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNameDoctor.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.txtNameDoctor.HintForeColor = System.Drawing.Color.Empty;
            this.txtNameDoctor.HintText = "";
            this.txtNameDoctor.isPassword = false;
            this.txtNameDoctor.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtNameDoctor.LineIdleColor = System.Drawing.Color.DarkSeaGreen;
            this.txtNameDoctor.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtNameDoctor.LineThickness = 3;
            this.txtNameDoctor.Location = new System.Drawing.Point(623, 47);
            this.txtNameDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameDoctor.Name = "txtNameDoctor";
            this.txtNameDoctor.Size = new System.Drawing.Size(278, 44);
            this.txtNameDoctor.TabIndex = 5;
            this.txtNameDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBirthClient
            // 
            this.txtBirthClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBirthClient.Enabled = false;
            this.txtBirthClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBirthClient.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.txtBirthClient.HintForeColor = System.Drawing.Color.Empty;
            this.txtBirthClient.HintText = "";
            this.txtBirthClient.isPassword = false;
            this.txtBirthClient.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtBirthClient.LineIdleColor = System.Drawing.Color.DarkSeaGreen;
            this.txtBirthClient.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtBirthClient.LineThickness = 3;
            this.txtBirthClient.Location = new System.Drawing.Point(25, 191);
            this.txtBirthClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirthClient.Name = "txtBirthClient";
            this.txtBirthClient.Size = new System.Drawing.Size(278, 44);
            this.txtBirthClient.TabIndex = 4;
            this.txtBirthClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSurNameClient
            // 
            this.txtSurNameClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurNameClient.Enabled = false;
            this.txtSurNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSurNameClient.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.txtSurNameClient.HintForeColor = System.Drawing.Color.Empty;
            this.txtSurNameClient.HintText = "";
            this.txtSurNameClient.isPassword = false;
            this.txtSurNameClient.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtSurNameClient.LineIdleColor = System.Drawing.Color.DarkSeaGreen;
            this.txtSurNameClient.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtSurNameClient.LineThickness = 3;
            this.txtSurNameClient.Location = new System.Drawing.Point(25, 113);
            this.txtSurNameClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurNameClient.Name = "txtSurNameClient";
            this.txtSurNameClient.Size = new System.Drawing.Size(278, 44);
            this.txtSurNameClient.TabIndex = 3;
            this.txtSurNameClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNameClient
            // 
            this.txtNameClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameClient.Enabled = false;
            this.txtNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNameClient.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.txtNameClient.HintForeColor = System.Drawing.Color.Empty;
            this.txtNameClient.HintText = "";
            this.txtNameClient.isPassword = false;
            this.txtNameClient.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtNameClient.LineIdleColor = System.Drawing.Color.DarkSeaGreen;
            this.txtNameClient.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtNameClient.LineThickness = 3;
            this.txtNameClient.Location = new System.Drawing.Point(25, 47);
            this.txtNameClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(278, 44);
            this.txtNameClient.TabIndex = 2;
            this.txtNameClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dateShedulePicker
            // 
            this.dateShedulePicker.BackColor = System.Drawing.Color.SeaGreen;
            this.dateShedulePicker.BorderRadius = 0;
            this.dateShedulePicker.ForeColor = System.Drawing.Color.White;
            this.dateShedulePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateShedulePicker.FormatCustom = "MMMMdd, yyyy ";
            this.dateShedulePicker.Location = new System.Drawing.Point(310, 361);
            this.dateShedulePicker.Name = "dateShedulePicker";
            this.dateShedulePicker.Size = new System.Drawing.Size(303, 36);
            this.dateShedulePicker.TabIndex = 0;
            this.dateShedulePicker.Value = new System.DateTime(2019, 11, 12, 17, 7, 17, 836);
            this.dateShedulePicker.onValueChanged += new System.EventHandler(this.dateShedulePicker_onValueChanged);
            // 
            // dvgShedules
            // 
            this.dvgShedules.AllowUserToAddRows = false;
            this.dvgShedules.AllowUserToDeleteRows = false;
            this.dvgShedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgShedules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_S,
            this.Pacient,
            this.Doctors,
            this.DateTimeShedule});
            this.dvgShedules.Location = new System.Drawing.Point(209, 30);
            this.dvgShedules.Name = "dvgShedules";
            this.dvgShedules.ReadOnly = true;
            this.dvgShedules.Size = new System.Drawing.Size(926, 630);
            this.dvgShedules.TabIndex = 9;
            // 
            // ID_S
            // 
            this.ID_S.HeaderText = "ID";
            this.ID_S.Name = "ID_S";
            this.ID_S.ReadOnly = true;
            this.ID_S.Visible = false;
            // 
            // Pacient
            // 
            this.Pacient.HeaderText = "Пацієнт";
            this.Pacient.Name = "Pacient";
            this.Pacient.ReadOnly = true;
            this.Pacient.Width = 283;
            // 
            // Doctors
            // 
            this.Doctors.HeaderText = "ЛІкарь";
            this.Doctors.Name = "Doctors";
            this.Doctors.ReadOnly = true;
            this.Doctors.Width = 300;
            // 
            // DateTimeShedule
            // 
            this.DateTimeShedule.HeaderText = "Дата прийому";
            this.DateTimeShedule.Name = "DateTimeShedule";
            this.DateTimeShedule.ReadOnly = true;
            this.DateTimeShedule.Width = 300;
            // 
            // doctor
            // 
            this.doctor.FillWeight = 60F;
            this.doctor.HeaderText = "Лікарь";
            this.doctor.Name = "doctor";
            this.doctor.ReadOnly = true;
            this.doctor.Width = 432;
            // 
            // client
            // 
            this.client.FillWeight = 60F;
            this.client.HeaderText = "Пацієнт";
            this.client.Name = "client";
            this.client.ReadOnly = true;
            this.client.Width = 450;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dvgShedule
            // 
            this.dvgShedule.AllowUserToAddRows = false;
            this.dvgShedule.AllowUserToDeleteRows = false;
            this.dvgShedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgShedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.client,
            this.doctor});
            this.dvgShedule.Location = new System.Drawing.Point(209, 30);
            this.dvgShedule.Name = "dvgShedule";
            this.dvgShedule.ReadOnly = true;
            this.dvgShedule.RowTemplate.Height = 24;
            this.dvgShedule.Size = new System.Drawing.Size(926, 630);
            this.dvgShedule.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1135, 660);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dvgDoctor);
            this.Controls.Add(this.dvgClinics);
            this.Controls.Add(this.dvgCity);
            this.Controls.Add(this.dgwClients);
            this.Controls.Add(this.dvgShedules);
            this.Controls.Add(this.pShedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgClinics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCity)).EndInit();
            this.pShedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgShedules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgShedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnClinic;
        private Bunifu.Framework.UI.BunifuFlatButton btnAbout;
        private Bunifu.Framework.UI.BunifuFlatButton btnContact;
        private Bunifu.Framework.UI.BunifuFlatButton BtnDoctor;
        private Bunifu.Framework.UI.BunifuFlatButton btnReform;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnSchedule;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dvgClinics;
        private System.Windows.Forms.DataGridView dvgDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebirth;
        private System.Windows.Forms.DataGridView dgwClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dvgCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.Panel pShedule;
        private Bunifu.Framework.UI.BunifuDatepicker dateShedulePicker;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBirthDoctor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSurnameDoctor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNameDoctor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBirthClient;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSurNameClient;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNameClient;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfirmShedule;
        private System.Windows.Forms.DataGridView dvgShedules;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_S;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pacient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeShedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView dvgShedule;
    }
}