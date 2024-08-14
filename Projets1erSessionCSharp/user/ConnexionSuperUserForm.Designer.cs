namespace Projets1erSessionCSharp
{
    partial class ConnexionSuperUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnexionSuperUserForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkMdp = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.txtMdp = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.btnRetour = new Siticone.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(484, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 511);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // chkMdp
            // 
            this.chkMdp.AutoSize = true;
            this.chkMdp.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMdp.CheckedState.BorderRadius = 2;
            this.chkMdp.CheckedState.BorderThickness = 0;
            this.chkMdp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMdp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMdp.Font = new System.Drawing.Font("Inter SemiBold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMdp.Location = new System.Drawing.Point(47, 307);
            this.chkMdp.Name = "chkMdp";
            this.chkMdp.Size = new System.Drawing.Size(129, 16);
            this.chkMdp.TabIndex = 32;
            this.chkMdp.Text = "Afficher mot de passe";
            this.chkMdp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMdp.UncheckedState.BorderRadius = 2;
            this.chkMdp.UncheckedState.BorderThickness = 0;
            this.chkMdp.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMdp.UseVisualStyleBackColor = true;
            this.chkMdp.CheckedChanged += new System.EventHandler(this.chkMdp_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.label4.Location = new System.Drawing.Point(41, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Connexion en tant que Super Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label3.Location = new System.Drawing.Point(42, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Bienvenue!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(42, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(42, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Email";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(321, 340);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(120, 35);
            this.siticoneButton1.TabIndex = 25;
            this.siticoneButton1.Text = "Connecter";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click_1);
            // 
            // txtMdp
            // 
            this.txtMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMdp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMdp.BorderColor = System.Drawing.Color.Transparent;
            this.txtMdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMdp.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMdp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMdp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMdp.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.txtMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtMdp.Location = new System.Drawing.Point(45, 254);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.SelectedText = "";
            this.txtMdp.Size = new System.Drawing.Size(396, 35);
            this.txtMdp.TabIndex = 24;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.BorderColor = System.Drawing.Color.Transparent;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtEmail.Location = new System.Drawing.Point(45, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(396, 35);
            this.txtEmail.TabIndex = 23;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Transparent;
            this.btnRetour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnRetour.BorderThickness = 1;
            this.btnRetour.CheckedState.Parent = this.btnRetour;
            this.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetour.CustomImages.Parent = this.btnRetour;
            this.btnRetour.FillColor = System.Drawing.Color.Transparent;
            this.btnRetour.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.btnRetour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnRetour.HoveredState.Parent = this.btnRetour;
            this.btnRetour.Location = new System.Drawing.Point(195, 340);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.ShadowDecoration.Parent = this.btnRetour;
            this.btnRetour.Size = new System.Drawing.Size(120, 35);
            this.btnRetour.TabIndex = 33;
            this.btnRetour.Text = "Retour";
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // ConnexionSuperUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.chkMdp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnexionSuperUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnexionSuperUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.UI.WinForms.SiticoneCheckBox chkMdp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Guna.UI.WinForms.GunaTextBox txtMdp;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Siticone.UI.WinForms.SiticoneButton btnRetour;
    }
}