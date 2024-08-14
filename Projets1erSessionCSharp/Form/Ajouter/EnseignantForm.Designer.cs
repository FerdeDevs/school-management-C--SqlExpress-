namespace Projets1erSessionCSharp
{
    partial class EnseignantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnseignantForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new Siticone.UI.WinForms.SiticoneButton();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtFaculte = new Siticone.UI.WinForms.SiticoneComboBox();
            this.txtCours = new Siticone.UI.WinForms.SiticoneComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSexe = new Siticone.UI.WinForms.SiticoneComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chkMdp = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.siticoneGroupBox1 = new Siticone.UI.WinForms.SiticoneGroupBox();
            this.browseBtn = new Guna.UI.WinForms.GunaCircleButton();
            this.picProfile = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRepeteMdp = new Guna.UI.WinForms.GunaTextBox();
            this.txtAdresse = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMdp = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrenom = new Guna.UI.WinForms.GunaTextBox();
            this.btnClear = new Siticone.UI.WinForms.SiticoneButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new Siticone.UI.WinForms.SiticoneButton();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txtNom = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox1.SuspendLayout();
            this.siticoneGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtFaculte);
            this.groupBox1.Controls.Add(this.txtCours);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSexe);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.chkMdp);
            this.groupBox1.Controls.Add(this.siticoneGroupBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRepeteMdp);
            this.groupBox1.Controls.Add(this.txtAdresse);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMdp);
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
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enseignant";
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
            this.btnBack.Size = new System.Drawing.Size(74, 25);
            this.btnBack.TabIndex = 116;
            this.btnBack.Text = "Retour";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.SystemColors.Control;
            this.txtTel.Location = new System.Drawing.Point(618, 292);
            this.txtTel.Mask = "(5\\0\\9)#### ####";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(171, 20);
            this.txtTel.TabIndex = 6;
            // 
            // txtFaculte
            // 
            this.txtFaculte.BackColor = System.Drawing.SystemColors.Control;
            this.txtFaculte.BorderThickness = 2;
            this.txtFaculte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFaculte.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtFaculte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFaculte.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFaculte.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFaculte.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.txtFaculte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtFaculte.FormattingEnabled = true;
            this.txtFaculte.HoveredState.Parent = this.txtFaculte;
            this.txtFaculte.ItemHeight = 30;
            this.txtFaculte.ItemsAppearance.Parent = this.txtFaculte;
            this.txtFaculte.Location = new System.Drawing.Point(426, 351);
            this.txtFaculte.Name = "txtFaculte";
            this.txtFaculte.ShadowDecoration.Parent = this.txtFaculte;
            this.txtFaculte.Size = new System.Drawing.Size(173, 36);
            this.txtFaculte.TabIndex = 8;
            this.txtFaculte.SelectedIndexChanged += new System.EventHandler(this.txtFaculte_SelectedIndexChanged);
            // 
            // txtCours
            // 
            this.txtCours.BackColor = System.Drawing.SystemColors.Control;
            this.txtCours.BorderThickness = 2;
            this.txtCours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCours.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCours.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCours.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCours.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.txtCours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.txtCours.FormattingEnabled = true;
            this.txtCours.HoveredState.Parent = this.txtCours;
            this.txtCours.ItemHeight = 30;
            this.txtCours.ItemsAppearance.Parent = this.txtCours;
            this.txtCours.Location = new System.Drawing.Point(616, 352);
            this.txtCours.Name = "txtCours";
            this.txtCours.ShadowDecoration.Parent = this.txtCours;
            this.txtCours.Size = new System.Drawing.Size(173, 36);
            this.txtCours.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(430, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 119;
            this.label12.Text = "Faculté";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(613, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 118;
            this.label11.Text = "Téléphone";
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
            this.txtSexe.Size = new System.Drawing.Size(173, 36);
            this.txtSexe.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(613, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 116;
            this.label10.Text = "Cours";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(423, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 15);
            this.label13.TabIndex = 115;
            this.label13.Text = "Sexe";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(36, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 63;
            this.label6.Text = "Adresse";
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
            this.txtRepeteMdp.TabIndex = 11;
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
            this.txtAdresse.Location = new System.Drawing.Point(39, 352);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.PasswordChar = '\0';
            this.txtAdresse.SelectedText = "";
            this.txtAdresse.Size = new System.Drawing.Size(354, 35);
            this.txtAdresse.TabIndex = 7;
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
            this.txtMdp.TabIndex = 10;
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
            this.txtPrenom.TabIndex = 3;
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
            this.txtEmail.TabIndex = 4;
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
            this.txtNom.TabIndex = 2;
            // 
            // EnseignantForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(839, 550);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnseignantForm";
            this.Text = "EnseignantForm";
            this.Load += new System.EventHandler(this.EnseignantForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.siticoneGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Siticone.UI.WinForms.SiticoneCheckBox chkMdp;
        private Siticone.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private Guna.UI.WinForms.GunaCircleButton browseBtn;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox picProfile;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtRepeteMdp;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtMdp;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtPrenom;
        private Siticone.UI.WinForms.SiticoneButton btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneButton btnCreate;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaTextBox txtNom;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtAdresse;
        private Siticone.UI.WinForms.SiticoneComboBox txtFaculte;
        private Siticone.UI.WinForms.SiticoneComboBox txtCours;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Siticone.UI.WinForms.SiticoneComboBox txtSexe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private Siticone.UI.WinForms.SiticoneButton btnBack;

    }
}