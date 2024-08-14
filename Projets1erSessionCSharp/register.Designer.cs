namespace Projets1erSessionCSharp
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.leftMainPanel = new System.Windows.Forms.Panel();
            this.siticoneGradientButton1 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.btnEconomat = new Siticone.UI.WinForms.SiticoneButton();
            this.btnSecretaire = new Siticone.UI.WinForms.SiticoneButton();
            this.btnEnseignant = new Siticone.UI.WinForms.SiticoneButton();
            this.btnAdmin = new Siticone.UI.WinForms.SiticoneButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.leftMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftMainPanel
            // 
            this.leftMainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.leftMainPanel.Controls.Add(this.siticoneGradientButton1);
            this.leftMainPanel.Controls.Add(this.btnEconomat);
            this.leftMainPanel.Controls.Add(this.btnSecretaire);
            this.leftMainPanel.Controls.Add(this.btnEnseignant);
            this.leftMainPanel.Controls.Add(this.btnAdmin);
            this.leftMainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMainPanel.Location = new System.Drawing.Point(0, 0);
            this.leftMainPanel.Name = "leftMainPanel";
            this.leftMainPanel.Size = new System.Drawing.Size(161, 550);
            this.leftMainPanel.TabIndex = 2;
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.siticoneGradientButton1.BorderRadius = 5;
            this.siticoneGradientButton1.BorderThickness = 1;
            this.siticoneGradientButton1.CheckedState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneGradientButton1.CustomImages.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.siticoneGradientButton1.HoveredState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneGradientButton1.Image")));
            this.siticoneGradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneGradientButton1.ImageOffset = new System.Drawing.Point(4, 0);
            this.siticoneGradientButton1.ImageSize = new System.Drawing.Size(15, 15);
            this.siticoneGradientButton1.Location = new System.Drawing.Point(16, 502);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(128, 36);
            this.siticoneGradientButton1.TabIndex = 0;
            this.siticoneGradientButton1.Text = "Déconnecter";
            this.siticoneGradientButton1.TextOffset = new System.Drawing.Point(10, 0);
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
            // 
            // btnEconomat
            // 
            this.btnEconomat.Animated = false;
            this.btnEconomat.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEconomat.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnEconomat.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnEconomat.CheckedState.Parent = this.btnEconomat;
            this.btnEconomat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEconomat.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEconomat.CustomImages.Parent = this.btnEconomat;
            this.btnEconomat.FillColor = System.Drawing.Color.Transparent;
            this.btnEconomat.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.btnEconomat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnEconomat.HoveredState.Parent = this.btnEconomat;
            this.btnEconomat.Image = ((System.Drawing.Image)(resources.GetObject("btnEconomat.Image")));
            this.btnEconomat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEconomat.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnEconomat.ImageSize = new System.Drawing.Size(15, 15);
            this.btnEconomat.Location = new System.Drawing.Point(0, 299);
            this.btnEconomat.Name = "btnEconomat";
            this.btnEconomat.PressedDepth = 0;
            this.btnEconomat.ShadowDecoration.Parent = this.btnEconomat;
            this.btnEconomat.Size = new System.Drawing.Size(161, 36);
            this.btnEconomat.TabIndex = 4;
            this.btnEconomat.Text = "Econome";
            this.btnEconomat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEconomat.TextOffset = new System.Drawing.Point(10, 0);
            this.btnEconomat.Click += new System.EventHandler(this.btnEconomat_Click);
            // 
            // btnSecretaire
            // 
            this.btnSecretaire.Animated = false;
            this.btnSecretaire.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSecretaire.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnSecretaire.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnSecretaire.CheckedState.Parent = this.btnSecretaire;
            this.btnSecretaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecretaire.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSecretaire.CustomImages.Parent = this.btnSecretaire;
            this.btnSecretaire.FillColor = System.Drawing.Color.Transparent;
            this.btnSecretaire.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.btnSecretaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnSecretaire.HoveredState.Parent = this.btnSecretaire;
            this.btnSecretaire.Image = ((System.Drawing.Image)(resources.GetObject("btnSecretaire.Image")));
            this.btnSecretaire.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSecretaire.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnSecretaire.ImageSize = new System.Drawing.Size(15, 15);
            this.btnSecretaire.Location = new System.Drawing.Point(0, 263);
            this.btnSecretaire.Name = "btnSecretaire";
            this.btnSecretaire.PressedDepth = 0;
            this.btnSecretaire.ShadowDecoration.Parent = this.btnSecretaire;
            this.btnSecretaire.Size = new System.Drawing.Size(161, 36);
            this.btnSecretaire.TabIndex = 3;
            this.btnSecretaire.Text = "Secretaire";
            this.btnSecretaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSecretaire.TextOffset = new System.Drawing.Point(10, 0);
            this.btnSecretaire.Click += new System.EventHandler(this.btnSecretaire_Click);
            // 
            // btnEnseignant
            // 
            this.btnEnseignant.Animated = false;
            this.btnEnseignant.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEnseignant.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnEnseignant.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnEnseignant.CheckedState.Parent = this.btnEnseignant;
            this.btnEnseignant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnseignant.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEnseignant.CustomImages.Parent = this.btnEnseignant;
            this.btnEnseignant.FillColor = System.Drawing.Color.Transparent;
            this.btnEnseignant.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.btnEnseignant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnEnseignant.HoveredState.Parent = this.btnEnseignant;
            this.btnEnseignant.Image = ((System.Drawing.Image)(resources.GetObject("btnEnseignant.Image")));
            this.btnEnseignant.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEnseignant.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnEnseignant.ImageSize = new System.Drawing.Size(15, 15);
            this.btnEnseignant.Location = new System.Drawing.Point(0, 227);
            this.btnEnseignant.Name = "btnEnseignant";
            this.btnEnseignant.PressedDepth = 0;
            this.btnEnseignant.ShadowDecoration.Parent = this.btnEnseignant;
            this.btnEnseignant.Size = new System.Drawing.Size(161, 36);
            this.btnEnseignant.TabIndex = 2;
            this.btnEnseignant.Text = "Enseignant";
            this.btnEnseignant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEnseignant.TextOffset = new System.Drawing.Point(10, 0);
            this.btnEnseignant.Click += new System.EventHandler(this.btnEnseignant_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Animated = false;
            this.btnAdmin.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAdmin.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnAdmin.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnAdmin.CheckedState.Parent = this.btnAdmin;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAdmin.CustomImages.Parent = this.btnAdmin;
            this.btnAdmin.FillColor = System.Drawing.Color.Transparent;
            this.btnAdmin.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnAdmin.HoveredState.Parent = this.btnAdmin;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdmin.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnAdmin.ImageSize = new System.Drawing.Size(15, 15);
            this.btnAdmin.Location = new System.Drawing.Point(0, 191);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.PressedDepth = 0;
            this.btnAdmin.ShadowDecoration.Parent = this.btnAdmin;
            this.btnAdmin.Size = new System.Drawing.Size(161, 36);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdmin.TextOffset = new System.Drawing.Point(10, 0);
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(161, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(839, 550);
            this.mainPanel.TabIndex = 3;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftMainPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.leftMainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneButton btnAdmin;
        private System.Windows.Forms.Panel leftMainPanel;
        private Siticone.UI.WinForms.SiticoneButton btnEconomat;
        private Siticone.UI.WinForms.SiticoneButton btnSecretaire;
        private Siticone.UI.WinForms.SiticoneButton btnEnseignant;
        private System.Windows.Forms.Panel mainPanel;
        private Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
    }
}