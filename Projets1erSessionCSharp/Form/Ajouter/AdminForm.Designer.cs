namespace Projets1erSessionCSharp
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.siticoneGroupBox1 = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.browseBtn = new Guna.UI.WinForms.GunaCircleButton();
            this.picProfile = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.txtNom = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.btnCreate = new Siticone.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new Siticone.UI.WinForms.SiticoneButton();
            this.txtPrenom = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMdp = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdresse = new Guna.UI.WinForms.GunaTextBox();
            this.txtRepeteMdp = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSexe = new Siticone.UI.WinForms.SiticoneComboBox();
            this.chkMdp = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new Siticone.UI.WinForms.SiticoneButton();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.siticoneGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.BorderThickness = 0;
            this.siticoneGroupBox1.Controls.Add(this.browseBtn);
            this.siticoneGroupBox1.Controls.Add(this.picProfile);
            this.siticoneGroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox1.Location = new System.Drawing.Point(39, 31);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.ShadowDecoration.Parent = this.siticoneGroupBox1;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(112, 110);
            this.siticoneGroupBox1.TabIndex = 73;
            this.siticoneGroupBox1.Text = "siticoneGroupBox1";
            // 
            // browseBtn
            // 
            this.browseBtn.AnimationHoverSpeed = 0.07F;
            this.browseBtn.AnimationSpeed = 0.03F;
            this.browseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.browseBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(222)))), ((int)(((byte)(254)))));
            this.browseBtn.BorderColor = System.Drawing.Color.Black;
            this.browseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.browseBtn.FocusedColor = System.Drawing.Color.Empty;
            this.browseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.browseBtn.ForeColor = System.Drawing.Color.White;
            this.browseBtn.Image = ((System.Drawing.Image)(resources.GetObject("browseBtn.Image")));
            this.browseBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.browseBtn.Location = new System.Drawing.Point(75, 73);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.browseBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.browseBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.browseBtn.OnHoverImage = null;
            this.browseBtn.OnPressedColor = System.Drawing.Color.Black;
            this.browseBtn.Size = new System.Drawing.Size(30, 30);
            this.browseBtn.TabIndex = 72;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // picProfile
            // 
            this.picProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picProfile.Image = ((System.Drawing.Image)(resources.GetObject("picProfile.Image")));
            this.picProfile.Location = new System.Drawing.Point(12, 16);
            this.picProfile.Name = "picProfile";
            this.picProfile.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.picProfile.ShadowDecoration.Parent = this.picProfile;
            this.picProfile.Size = new System.Drawing.Size(70, 70);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 70;
            this.picProfile.TabStop = false;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.Control;
            this.txtNom.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNom.BorderColor = System.Drawing.Color.Transparent;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNom.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.txtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtNom.Location = new System.Drawing.Point(39, 203);
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.SelectedText = "";
            this.txtNom.Size = new System.Drawing.Size(354, 35);
            this.txtNom.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.BorderColor = System.Drawing.Color.Transparent;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtEmail.Location = new System.Drawing.Point(39, 277);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(354, 35);
            this.txtEmail.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.CheckedState.Parent = this.btnCreate;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.CustomImages.Parent = this.btnCreate;
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnCreate.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.HoveredState.Parent = this.btnCreate;
            this.btnCreate.Location = new System.Drawing.Point(660, 494);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.ShadowDecoration.Parent = this.btnCreate;
            this.btnCreate.Size = new System.Drawing.Size(120, 35);
            this.btnCreate.TabIndex = 49;
            this.btnCreate.Text = "Créer un compte";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(36, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(36, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Email";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnClear.BorderThickness = 1;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnClear.HoveredState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(534, 494);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 52;
            this.btnClear.Text = "Nettoyer";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrenom.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrenom.BorderColor = System.Drawing.Color.Transparent;
            this.txtPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrenom.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrenom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrenom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrenom.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.txtPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtPrenom.Location = new System.Drawing.Point(426, 203);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PasswordChar = '\0';
            this.txtPrenom.SelectedText = "";
            this.txtPrenom.Size = new System.Drawing.Size(354, 35);
            this.txtPrenom.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(423, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 55;
            this.label4.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(423, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "Sexe";
            // 
            // txtMdp
            // 
            this.txtMdp.BackColor = System.Drawing.SystemColors.Control;
            this.txtMdp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMdp.BorderColor = System.Drawing.Color.Transparent;
            this.txtMdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMdp.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMdp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMdp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMdp.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.txtMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtMdp.Location = new System.Drawing.Point(39, 425);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.SelectedText = "";
            this.txtMdp.Size = new System.Drawing.Size(354, 35);
            this.txtMdp.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(36, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 59;
            this.label8.Text = "Téléphone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(36, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 60;
            this.label7.Text = "Mot de passe";
            // 
            // txtAdresse
            // 
            this.txtAdresse.BackColor = System.Drawing.SystemColors.Control;
            this.txtAdresse.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAdresse.BorderColor = System.Drawing.Color.Transparent;
            this.txtAdresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdresse.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAdresse.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAdresse.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAdresse.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.txtAdresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtAdresse.Location = new System.Drawing.Point(426, 351);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.PasswordChar = '\0';
            this.txtAdresse.SelectedText = "";
            this.txtAdresse.Size = new System.Drawing.Size(354, 35);
            this.txtAdresse.TabIndex = 6;
            // 
            // txtRepeteMdp
            // 
            this.txtRepeteMdp.BackColor = System.Drawing.SystemColors.Control;
            this.txtRepeteMdp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRepeteMdp.BorderColor = System.Drawing.Color.Transparent;
            this.txtRepeteMdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepeteMdp.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRepeteMdp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRepeteMdp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRepeteMdp.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.txtRepeteMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtRepeteMdp.Location = new System.Drawing.Point(426, 425);
            this.txtRepeteMdp.Name = "txtRepeteMdp";
            this.txtRepeteMdp.PasswordChar = '*';
            this.txtRepeteMdp.SelectedText = "";
            this.txtRepeteMdp.Size = new System.Drawing.Size(354, 35);
            this.txtRepeteMdp.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(423, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 63;
            this.label6.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(423, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 15);
            this.label5.TabIndex = 64;
            this.label5.Text = "Répéter mot de passe";
            // 
            // txtSexe
            // 
            this.txtSexe.BackColor = System.Drawing.SystemColors.Control;
            this.txtSexe.BorderThickness = 2;
            this.txtSexe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSexe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSexe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSexe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSexe.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.txtSexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtSexe.FormattingEnabled = true;
            this.txtSexe.HoveredState.Parent = this.txtSexe;
            this.txtSexe.ItemHeight = 30;
            this.txtSexe.Items.AddRange(new object[] {
            "Choisir",
            "Masculin",
            "Feminin"});
            this.txtSexe.ItemsAppearance.Parent = this.txtSexe;
            this.txtSexe.Location = new System.Drawing.Point(426, 277);
            this.txtSexe.Name = "txtSexe";
            this.txtSexe.ShadowDecoration.Parent = this.txtSexe;
            this.txtSexe.Size = new System.Drawing.Size(354, 36);
            this.txtSexe.TabIndex = 4;
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
            this.chkMdp.Location = new System.Drawing.Point(39, 475);
            this.chkMdp.Name = "chkMdp";
            this.chkMdp.Size = new System.Drawing.Size(129, 16);
            this.chkMdp.TabIndex = 74;
            this.chkMdp.Text = "Afficher mot de passe";
            this.chkMdp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMdp.UncheckedState.BorderRadius = 2;
            this.chkMdp.UncheckedState.BorderThickness = 0;
            this.chkMdp.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMdp.UseVisualStyleBackColor = true;
            this.chkMdp.CheckedChanged += new System.EventHandler(this.chkMdp_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.chkMdp);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.siticoneGroupBox1);
            this.groupBox1.Controls.Add(this.txtSexe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRepeteMdp);
            this.groupBox1.Controls.Add(this.txtAdresse);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMdp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 550);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin";
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnBack.Font = new System.Drawing.Font("Inter SemiBold", 7F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoveredState.Parent = this.btnBack;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(70, 25);
            this.btnBack.TabIndex = 80;
            this.btnBack.Text = "Retour";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.SystemColors.Control;
            this.txtTel.Location = new System.Drawing.Point(39, 366);
            this.txtTel.Mask = "(5\\0\\9)#### ####";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(354, 20);
            this.txtTel.TabIndex = 5;
            // 
            // AdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(839, 550);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "v";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.siticoneGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneCirclePictureBox picProfile;
        private Guna.UI.WinForms.GunaCircleButton browseBtn;
        private Siticone.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private Guna.UI.WinForms.GunaTextBox txtNom;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Siticone.UI.WinForms.SiticoneButton btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneButton btnClear;
        private Guna.UI.WinForms.GunaTextBox txtPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtMdp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtAdresse;
        private Guna.UI.WinForms.GunaTextBox txtRepeteMdp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Siticone.UI.WinForms.SiticoneComboBox txtSexe;
        private Siticone.UI.WinForms.SiticoneCheckBox chkMdp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private Siticone.UI.WinForms.SiticoneButton btnBack;
    }
}