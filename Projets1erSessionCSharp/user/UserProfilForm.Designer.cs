namespace Projets1erSessionCSharp
{
    partial class UserProfilForm
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
            this.TopPanel = new Guna.UI.WinForms.GunaPanel();
            this.FormPanel = new Guna.UI.WinForms.GunaPanel();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(222)))), ((int)(((byte)(254)))));
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(839, 66);
            this.TopPanel.TabIndex = 80;
            // 
            // FormPanel
            // 
            this.FormPanel.BackColor = System.Drawing.Color.Transparent;
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(0, 66);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(839, 484);
            this.FormPanel.TabIndex = 81;
            // 
            // UserProfilForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(839, 550);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfilForm";
            this.Load += new System.EventHandler(this.UserProfilForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel TopPanel;
        private Guna.UI.WinForms.GunaPanel FormPanel;
    }
}