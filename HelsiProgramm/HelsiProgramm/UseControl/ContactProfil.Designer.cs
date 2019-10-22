namespace HelsiProgramm.UseControl
{
    partial class ContactProfil
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactProfil));
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSurname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDateOfBirth = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Photo = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtName.LineIdleColor = System.Drawing.Color.DarkSeaGreen;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(252, 87);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 44);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSurname
            // 
            this.txtSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurname.Enabled = false;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSurname.HintForeColor = System.Drawing.Color.Empty;
            this.txtSurname.HintText = "";
            this.txtSurname.isPassword = false;
            this.txtSurname.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtSurname.LineIdleColor = System.Drawing.Color.DarkSeaGreen;
            this.txtSurname.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtSurname.LineThickness = 3;
            this.txtSurname.Location = new System.Drawing.Point(252, 139);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(165, 44);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateOfBirth.Enabled = false;
            this.txtDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDateOfBirth.HintForeColor = System.Drawing.Color.Empty;
            this.txtDateOfBirth.HintText = "";
            this.txtDateOfBirth.isPassword = false;
            this.txtDateOfBirth.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtDateOfBirth.LineIdleColor = System.Drawing.Color.DarkSeaGreen;
            this.txtDateOfBirth.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtDateOfBirth.LineThickness = 3;
            this.txtDateOfBirth.Location = new System.Drawing.Point(252, 191);
            this.txtDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(165, 44);
            this.txtDateOfBirth.TabIndex = 3;
            this.txtDateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Photo
            // 
            this.Photo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Photo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Photo.BackgroundImage")));
            this.Photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Photo.Location = new System.Drawing.Point(15, 18);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(185, 252);
            this.Photo.TabIndex = 4;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.Photo);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkSeaGreen;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Gold;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkSeaGreen;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(15, 28);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(213, 284);
            this.bunifuGradientPanel1.TabIndex = 5;
            // 
            // ContactProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Name = "ContactProfil";
            this.Size = new System.Drawing.Size(1012, 544);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSurname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDateOfBirth;
        private System.Windows.Forms.Panel Photo;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}
