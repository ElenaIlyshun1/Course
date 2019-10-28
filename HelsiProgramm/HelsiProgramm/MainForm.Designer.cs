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
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgDoctor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClinics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDoctor)).BeginInit();
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
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1101, 23);
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
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 17);
            this.panel2.TabIndex = 12;
            // 
            // dvgClinics
            // 
            this.dvgClinics.AllowUserToAddRows = false;
            this.dvgClinics.AllowUserToDeleteRows = false;
            this.dvgClinics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClinics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.street});
            this.dvgClinics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgClinics.Location = new System.Drawing.Point(209, 0);
            this.dvgClinics.Margin = new System.Windows.Forms.Padding(4);
            this.dvgClinics.Name = "dvgClinics";
            this.dvgClinics.ReadOnly = true;
            this.dvgClinics.RowTemplate.Height = 24;
            this.dvgClinics.Size = new System.Drawing.Size(926, 660);
            this.dvgClinics.TabIndex = 13;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
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
            this.dataGridViewTextBoxColumn3});
            this.dvgDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgDoctor.Location = new System.Drawing.Point(209, 0);
            this.dvgDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.dvgDoctor.Name = "dvgDoctor";
            this.dvgDoctor.ReadOnly = true;
            this.dvgDoctor.RowTemplate.Height = 24;
            this.dvgDoctor.Size = new System.Drawing.Size(926, 660);
            this.dvgDoctor.TabIndex = 14;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Вулиця";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 500;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1135, 660);
            this.Controls.Add(this.dvgDoctor);
            this.Controls.Add(this.dvgClinics);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClinics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDoctor)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.DataGridView dvgDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}