namespace Projets1erSessionCSharp
{
    partial class ToastForm
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
            this.components = new System.ComponentModel.Container();
            this.toastBorder = new System.Windows.Forms.Panel();
            this.lbType = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.toastTimer = new System.Windows.Forms.Timer(this.components);
            this.toastHide = new System.Windows.Forms.Timer(this.components);
            this.picIcon = new Siticone.UI.WinForms.SiticonePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // toastBorder
            // 
            this.toastBorder.BackColor = System.Drawing.Color.Teal;
            this.toastBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.toastBorder.Location = new System.Drawing.Point(0, 0);
            this.toastBorder.Name = "toastBorder";
            this.toastBorder.Size = new System.Drawing.Size(10, 58);
            this.toastBorder.TabIndex = 0;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(70, 9);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(41, 17);
            this.lbType.TabIndex = 2;
            this.lbType.Text = "Type";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbMessage.Location = new System.Drawing.Point(70, 28);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(97, 15);
            this.lbMessage.TabIndex = 3;
            this.lbMessage.Text = "Toast Message";
            // 
            // toastTimer
            // 
            this.toastTimer.Enabled = true;
            this.toastTimer.Interval = 10;
            this.toastTimer.Tick += new System.EventHandler(this.toastTimer_Tick);
            // 
            // toastHide
            // 
            this.toastHide.Enabled = true;
            this.toastHide.Interval = 10;
            this.toastHide.Tick += new System.EventHandler(this.toastHide_Tick);
            // 
            // picIcon
            // 
            this.picIcon.Image = global::Projets1erSessionCSharp.Properties.Resources.info;
            this.picIcon.Location = new System.Drawing.Point(18, 10);
            this.picIcon.Name = "picIcon";
            this.picIcon.ShadowDecoration.Parent = this.picIcon;
            this.picIcon.Size = new System.Drawing.Size(46, 39);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            // 
            // ToastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 58);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.toastBorder);
            this.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ToastForm";
            this.Load += new System.EventHandler(this.ToastForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toastBorder;
        private Siticone.UI.WinForms.SiticonePictureBox picIcon;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Timer toastTimer;
        private System.Windows.Forms.Timer toastHide;
    }
}