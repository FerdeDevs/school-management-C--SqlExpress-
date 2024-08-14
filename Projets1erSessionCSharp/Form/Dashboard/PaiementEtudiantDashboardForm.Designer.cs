namespace Projets1erSessionCSharp
{
    partial class PaiementEtudiantDashboardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaiementEtudiantDashboardForm));
            this.txtRechercher = new Guna.UI.WinForms.GunaTextBox();
            this.DataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DataGridViewPanel = new Guna.UI.WinForms.GunaPanel();
            this.MainFormPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new Guna.UI.WinForms.GunaPanel();
            this.btnRefresh = new Siticone.UI.WinForms.SiticoneButton();
            this.btnRechercher = new Guna.UI.WinForms.GunaCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.DataGridViewPanel.SuspendLayout();
            this.MainFormPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRechercher
            // 
            this.txtRechercher.BackColor = System.Drawing.Color.Transparent;
            this.txtRechercher.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.txtRechercher.BorderColor = System.Drawing.Color.Transparent;
            this.txtRechercher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRechercher.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.txtRechercher.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(222)))), ((int)(((byte)(254)))));
            this.txtRechercher.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRechercher.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.txtRechercher.ForeColor = System.Drawing.Color.Silver;
            this.txtRechercher.Location = new System.Drawing.Point(25, 26);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.PasswordChar = '\0';
            this.txtRechercher.Radius = 15;
            this.txtRechercher.SelectedText = "";
            this.txtRechercher.Size = new System.Drawing.Size(354, 35);
            this.txtRechercher.TabIndex = 76;
            this.txtRechercher.Text = "Rechercher par Matricule ou Email";
            this.txtRechercher.Enter += new System.EventHandler(this.txtRechercher_Enter);
            this.txtRechercher.Leave += new System.EventHandler(this.txtRechercher_Leave);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToOrderColumns = true;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.ColumnHeadersHeight = 40;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column4,
            this.Column10,
            this.Column6,
            this.Column9});
            this.DataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView.EnableHeadersVisualStyles = false;
            this.DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.Location = new System.Drawing.Point(12, 19);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridView.Name = "DataGridView";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowTemplate.Height = 35;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(815, 439);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridView.ThemeStyle.ReadOnly = false;
            this.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prenom";
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Email";
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sexe";
            this.Column4.Name = "Column4";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Faculter";
            this.Column10.Name = "Column10";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Telephone";
            this.Column6.Name = "Column6";
            // 
            // Column9
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.Column9.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column9.HeaderText = "Paiement";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.Text = "Paiement";
            this.Column9.UseColumnTextForButtonValue = true;
            // 
            // DataGridViewPanel
            // 
            this.DataGridViewPanel.BackColor = System.Drawing.Color.Transparent;
            this.DataGridViewPanel.Controls.Add(this.DataGridView);
            this.DataGridViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewPanel.Location = new System.Drawing.Point(0, 83);
            this.DataGridViewPanel.Name = "DataGridViewPanel";
            this.DataGridViewPanel.Size = new System.Drawing.Size(839, 467);
            this.DataGridViewPanel.TabIndex = 78;
            // 
            // MainFormPanel
            // 
            this.MainFormPanel.Controls.Add(this.DataGridViewPanel);
            this.MainFormPanel.Controls.Add(this.TopPanel);
            this.MainFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormPanel.Location = new System.Drawing.Point(0, 0);
            this.MainFormPanel.Name = "MainFormPanel";
            this.MainFormPanel.Size = new System.Drawing.Size(839, 550);
            this.MainFormPanel.TabIndex = 3;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(222)))), ((int)(((byte)(254)))));
            this.TopPanel.Controls.Add(this.btnRefresh);
            this.TopPanel.Controls.Add(this.btnRechercher);
            this.TopPanel.Controls.Add(this.txtRechercher);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(839, 83);
            this.TopPanel.TabIndex = 77;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 18;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnRefresh.Font = new System.Drawing.Font("Inter SemiBold", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoveredState.Parent = this.btnRefresh;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(699, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(113, 35);
            this.btnRefresh.TabIndex = 79;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.AnimationHoverSpeed = 0.07F;
            this.btnRechercher.AnimationSpeed = 0.03F;
            this.btnRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.btnRechercher.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnRechercher.BorderColor = System.Drawing.Color.Black;
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRechercher.FocusedColor = System.Drawing.Color.Empty;
            this.btnRechercher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRechercher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.btnRechercher.Image = global::Projets1erSessionCSharp.Properties.Resources.search;
            this.btnRechercher.ImageSize = new System.Drawing.Size(10, 10);
            this.btnRechercher.Location = new System.Drawing.Point(346, 31);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRechercher.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRechercher.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRechercher.OnHoverImage = null;
            this.btnRechercher.OnPressedColor = System.Drawing.Color.Black;
            this.btnRechercher.Size = new System.Drawing.Size(25, 25);
            this.btnRechercher.TabIndex = 73;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // PaiementEtudiantDashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(839, 550);
            this.Controls.Add(this.MainFormPanel);
            this.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaiementEtudiantDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaiementEtudiantDashboardForm";
            this.Load += new System.EventHandler(this.PaiementEtudiantDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.DataGridViewPanel.ResumeLayout(false);
            this.MainFormPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtRechercher;
        private Guna.UI.WinForms.GunaDataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private Guna.UI.WinForms.GunaPanel DataGridViewPanel;
        private System.Windows.Forms.Panel MainFormPanel;
        private Guna.UI.WinForms.GunaPanel TopPanel;
        private Siticone.UI.WinForms.SiticoneButton btnRefresh;
        private Guna.UI.WinForms.GunaCircleButton btnRechercher;
    }
}