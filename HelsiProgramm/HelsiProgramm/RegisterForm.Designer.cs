namespace HelsiProgramm
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSur = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PrivacyPolicyLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCreate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.LightGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(578, 36);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(86, 25);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Sign Up";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.LimeGreen;
            this.txtEmail.HintText = "Email";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Green;
            this.txtEmail.LineIdleColor = System.Drawing.Color.LightGreen;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(481, 214);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 44);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSur
            // 
            this.txtSur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSur.HintForeColor = System.Drawing.Color.LimeGreen;
            this.txtSur.HintText = "Surname";
            this.txtSur.isPassword = false;
            this.txtSur.LineFocusedColor = System.Drawing.Color.Green;
            this.txtSur.LineIdleColor = System.Drawing.Color.LightGreen;
            this.txtSur.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtSur.LineThickness = 3;
            this.txtSur.Location = new System.Drawing.Point(481, 151);
            this.txtSur.Margin = new System.Windows.Forms.Padding(4);
            this.txtSur.Name = "txtSur";
            this.txtSur.Size = new System.Drawing.Size(280, 44);
            this.txtSur.TabIndex = 4;
            this.txtSur.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.LimeGreen;
            this.txtName.HintText = "Name";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Green;
            this.txtName.LineIdleColor = System.Drawing.Color.LightGreen;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(481, 89);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 44);
            this.txtName.TabIndex = 5;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DatePicker
            // 
            this.DatePicker.BackColor = System.Drawing.Color.SeaGreen;
            this.DatePicker.BorderRadius = 0;
            this.DatePicker.ForeColor = System.Drawing.Color.White;
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatePicker.FormatCustom = null;
            this.DatePicker.Location = new System.Drawing.Point(481, 327);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(280, 36);
            this.DatePicker.TabIndex = 6;
            this.DatePicker.Value = new System.DateTime(2019, 10, 17, 9, 21, 13, 820);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(518, 367);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 7;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(544, 369);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(96, 16);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "I agree with the";
            // 
            // PrivacyPolicyLabel
            // 
            this.PrivacyPolicyLabel.AutoSize = true;
            this.PrivacyPolicyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivacyPolicyLabel.ForeColor = System.Drawing.Color.Teal;
            this.PrivacyPolicyLabel.Location = new System.Drawing.Point(644, 369);
            this.PrivacyPolicyLabel.Name = "PrivacyPolicyLabel";
            this.PrivacyPolicyLabel.Size = new System.Drawing.Size(93, 16);
            this.PrivacyPolicyLabel.TabIndex = 9;
            this.PrivacyPolicyLabel.Text = "Privacy Policy";
            this.PrivacyPolicyLabel.MouseLeave += new System.EventHandler(this.PrivacyPolicyLabel_MouseLeave);
            this.PrivacyPolicyLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PrivacyPolicyLabel_MouseMove);
            // 
            // btnCreate
            // 
            this.btnCreate.ActiveBorderThickness = 1;
            this.btnCreate.ActiveCornerRadius = 20;
            this.btnCreate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCreate.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreate.BackgroundImage")));
            this.btnCreate.ButtonText = "Create Account";
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCreate.IdleBorderThickness = 1;
            this.btnCreate.IdleCornerRadius = 20;
            this.btnCreate.IdleFillColor = System.Drawing.Color.White;
            this.btnCreate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCreate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCreate.Location = new System.Drawing.Point(526, 391);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(190, 35);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(766, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 21);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.LimeGreen;
            this.txtPassword.HintText = "Password";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Green;
            this.txtPassword.LineIdleColor = System.Drawing.Color.LightGreen;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Green;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(481, 266);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(280, 44);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.txtPassword_OnValueChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.PrivacyPolicyLabel);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSur);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSur;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuDatepicker DatePicker;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel PrivacyPolicyLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCreate;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
    }
}