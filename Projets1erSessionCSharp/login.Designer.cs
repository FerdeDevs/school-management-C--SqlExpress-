namespace Projets1erSessionCSharp
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txtMdp = new Guna.UI.WinForms.GunaTextBox();
            this.btnConnecter = new Siticone.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreerUnCompte = new Siticone.UI.WinForms.SiticoneButton();
            this.chkMdp = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFermer = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(536, 203);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(396, 35);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "email@example.com";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
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
            this.txtMdp.ForeColor = System.Drawing.Color.Gray;
            this.txtMdp.Location = new System.Drawing.Point(536, 277);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.SelectedText = "";
            this.txtMdp.Size = new System.Drawing.Size(396, 35);
            this.txtMdp.TabIndex = 3;
            this.txtMdp.Text = "mot de passe";
            this.txtMdp.Enter += new System.EventHandler(this.txtMdp_Enter);
            this.txtMdp.Leave += new System.EventHandler(this.txtMdp_Leave);
            // 
            // btnConnecter
            // 
            this.btnConnecter.CheckedState.Parent = this.btnConnecter;
            this.btnConnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnecter.CustomImages.Parent = this.btnConnecter;
            this.btnConnecter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnConnecter.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.btnConnecter.ForeColor = System.Drawing.Color.White;
            this.btnConnecter.HoveredState.Parent = this.btnConnecter;
            this.btnConnecter.Location = new System.Drawing.Point(812, 377);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.ShadowDecoration.Parent = this.btnConnecter;
            this.btnConnecter.Size = new System.Drawing.Size(120, 35);
            this.btnConnecter.TabIndex = 4;
            this.btnConnecter.Text = "Connecter";
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(533, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email ou  numero telephone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(533, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mot de passe";
            // 
            // btnCreerUnCompte
            // 
            this.btnCreerUnCompte.BackColor = System.Drawing.Color.Transparent;
            this.btnCreerUnCompte.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnCreerUnCompte.BorderThickness = 1;
            this.btnCreerUnCompte.CheckedState.Parent = this.btnCreerUnCompte;
            this.btnCreerUnCompte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreerUnCompte.CustomImages.Parent = this.btnCreerUnCompte;
            this.btnCreerUnCompte.FillColor = System.Drawing.Color.Transparent;
            this.btnCreerUnCompte.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.btnCreerUnCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnCreerUnCompte.HoveredState.Parent = this.btnCreerUnCompte;
            this.btnCreerUnCompte.Location = new System.Drawing.Point(686, 377);
            this.btnCreerUnCompte.Name = "btnCreerUnCompte";
            this.btnCreerUnCompte.ShadowDecoration.Parent = this.btnCreerUnCompte;
            this.btnCreerUnCompte.Size = new System.Drawing.Size(120, 35);
            this.btnCreerUnCompte.TabIndex = 10;
            this.btnCreerUnCompte.Text = "Inscrire";
            this.btnCreerUnCompte.Click += new System.EventHandler(this.btnCreerUnCompte_Click_1);
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
            this.chkMdp.Location = new System.Drawing.Point(538, 330);
            this.chkMdp.Name = "chkMdp";
            this.chkMdp.Size = new System.Drawing.Size(129, 16);
            this.chkMdp.TabIndex = 11;
            this.chkMdp.Text = "Afficher mot de passe";
            this.chkMdp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMdp.UncheckedState.BorderRadius = 2;
            this.chkMdp.UncheckedState.BorderThickness = 0;
            this.chkMdp.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMdp.UseVisualStyleBackColor = true;
            this.chkMdp.CheckedChanged += new System.EventHandler(this.chkMdp_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 511);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnFermer
            // 
            this.btnFermer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnFermer.BorderRadius = 5;
            this.btnFermer.BorderThickness = 1;
            this.btnFermer.CheckedState.Parent = this.btnFermer;
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.CustomImages.Parent = this.btnFermer;
            this.btnFermer.FillColor = System.Drawing.Color.Transparent;
            this.btnFermer.FillColor2 = System.Drawing.Color.Transparent;
            this.btnFermer.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.btnFermer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnFermer.HoveredState.Parent = this.btnFermer;
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFermer.ImageOffset = new System.Drawing.Point(4, 0);
            this.btnFermer.ImageSize = new System.Drawing.Size(15, 15);
            this.btnFermer.Location = new System.Drawing.Point(12, 12);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.ShadowDecoration.Parent = this.btnFermer;
            this.btnFermer.Size = new System.Drawing.Size(42, 36);
            this.btnFermer.TabIndex = 12;
            this.btnFermer.TextOffset = new System.Drawing.Point(10, 0);
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(506, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 133;
            this.pictureBox2.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.chkMdp);
            this.Controls.Add(this.btnCreerUnCompte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaTextBox txtMdp;
        private Siticone.UI.WinForms.SiticoneButton btnConnecter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneButton btnCreerUnCompte;
        private Siticone.UI.WinForms.SiticoneCheckBox chkMdp;
        private Siticone.UI.WinForms.SiticoneGradientButton btnFermer;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}