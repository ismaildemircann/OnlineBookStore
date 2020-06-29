namespace Online_Book_Store
{
    partial class LoginPassword
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
            this.panelBase = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pboxPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panelBase.Location = new System.Drawing.Point(46, 28);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(211, 2);
            this.panelBase.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbPassword.Location = new System.Drawing.Point(46, 3);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(211, 19);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // pboxPassword
            // 
            this.pboxPassword.Image = global::Online_Book_Store.Properties.Resources.loginpasswordImage;
            this.pboxPassword.Location = new System.Drawing.Point(0, 0);
            this.pboxPassword.Name = "pboxPassword";
            this.pboxPassword.Size = new System.Drawing.Size(40, 40);
            this.pboxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPassword.TabIndex = 6;
            this.pboxPassword.TabStop = false;
            // 
            // LoginPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.pboxPassword);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.tbPassword);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Name = "LoginPassword";
            this.Size = new System.Drawing.Size(260, 40);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxPassword;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.TextBox tbPassword;
    }
}
