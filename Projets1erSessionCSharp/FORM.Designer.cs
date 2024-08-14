namespace Projets1erSessionCSharp
{
    partial class FORM
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
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.picBox = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblRole = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.gunaElipsePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(187)))));
            this.gunaElipsePanel1.Controls.Add(this.picBox);
            this.gunaElipsePanel1.Controls.Add(this.gunaElipsePanel2);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(11, 21);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 20;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(815, 285);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // picBox
            // 
            this.picBox.BaseColor = System.Drawing.Color.White;
            this.picBox.Location = new System.Drawing.Point(39, 44);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(200, 200);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            this.picBox.UseTransfarantBackground = false;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.lblRole);
            this.gunaElipsePanel2.Controls.Add(this.label4);
            this.gunaElipsePanel2.Controls.Add(this.label5);
            this.gunaElipsePanel2.Controls.Add(this.lblPrenom);
            this.gunaElipsePanel2.Controls.Add(this.lblNom);
            this.gunaElipsePanel2.Controls.Add(this.label3);
            this.gunaElipsePanel2.Controls.Add(this.lblAmount);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(472, 96);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 20;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(330, 175);
            this.gunaElipsePanel2.TabIndex = 0;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(203, 149);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 15);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "role";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prenom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Inter Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(75, 48);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(50, 15);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Inter Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(56, 24);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(33, 15);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "gds";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Inter SemiBold", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(8, 82);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(164, 81);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "220";
            // 
            // FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 550);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FORM";
            this.Load += new System.EventHandler(this.FORM_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaCirclePictureBox picBox;


    }
}