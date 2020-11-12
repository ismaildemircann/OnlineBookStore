namespace Online_Book_Store
{
    partial class LoginScreen
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelChild = new System.Windows.Forms.Panel();
            this.lbStore = new System.Windows.Forms.Label();
            this.loginUsername = new Online_Book_Store.LoginUsername();
            this.pboxShowHide = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.loginPassword = new Online_Book_Store.LoginPassword();
            this.panelBase = new System.Windows.Forms.Panel();
            this.pboxBackground = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            this.panelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxShowHide)).BeginInit();
            this.panelBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelLogin.Controls.Add(this.panelChild);
            this.panelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panelLogin.Location = new System.Drawing.Point(320, 111);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(431, 423);
            this.panelLogin.TabIndex = 0;
            // 
            // panelChild
            // 
            this.panelChild.Controls.Add(this.lbStore);
            this.panelChild.Controls.Add(this.loginUsername);
            this.panelChild.Controls.Add(this.pboxShowHide);
            this.panelChild.Controls.Add(this.btnLogin);
            this.panelChild.Controls.Add(this.loginPassword);
            this.panelChild.Location = new System.Drawing.Point(41, 28);
            this.panelChild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(364, 320);
            this.panelChild.TabIndex = 6;
            // 
            // lbStore
            // 
            this.lbStore.AutoSize = true;
            this.lbStore.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbStore.Location = new System.Drawing.Point(11, 11);
            this.lbStore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStore.Name = "lbStore";
            this.lbStore.Size = new System.Drawing.Size(323, 29);
            this.lbStore.TabIndex = 0;
            this.lbStore.Text = "Welcome to Ocean Book Store";
            this.lbStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginUsername
            // 
            this.loginUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.loginUsername.GetSetText = "";
            this.loginUsername.Location = new System.Drawing.Point(8, 76);
            this.loginUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(347, 49);
            this.loginUsername.TabIndex = 1;
            // 
            // pboxShowHide
            // 
            this.pboxShowHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxShowHide.Image = global::Online_Book_Store.Properties.Resources.showpassword;
            this.pboxShowHide.Location = new System.Drawing.Point(296, 219);
            this.pboxShowHide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pboxShowHide.Name = "pboxShowHide";
            this.pboxShowHide.Size = new System.Drawing.Size(33, 31);
            this.pboxShowHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxShowHide.TabIndex = 4;
            this.pboxShowHide.TabStop = false;
            this.pboxShowHide.Tag = "show";
            this.pboxShowHide.Click += new System.EventHandler(this.pboxShowHide_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(172)))), ((int)(((byte)(197)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLogin.Location = new System.Drawing.Point(123, 265);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 34);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // loginPassword
            // 
            this.loginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.loginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.loginPassword.getSetPasswordChar = true;
            this.loginPassword.GetSetText = "";
            this.loginPassword.Location = new System.Drawing.Point(8, 162);
            this.loginPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(347, 49);
            this.loginPassword.TabIndex = 2;
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(this.panelLogin);
            this.panelBase.Controls.Add(this.pboxBackground);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 0);
            this.panelBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(1067, 677);
            this.panelBase.TabIndex = 1;
            // 
            // pboxBackground
            // 
            this.pboxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxBackground.Image = global::Online_Book_Store.Properties.Resources.background;
            this.pboxBackground.Location = new System.Drawing.Point(0, 0);
            this.pboxBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pboxBackground.Name = "pboxBackground";
            this.pboxBackground.Size = new System.Drawing.Size(1067, 677);
            this.pboxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBackground.TabIndex = 1;
            this.pboxBackground.TabStop = false;
            // 
            // LoginScreen
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1067, 677);
            this.Controls.Add(this.panelBase);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.VisibleChanged += new System.EventHandler(this.LoginScreen_VisibleChanged);
            this.Resize += new System.EventHandler(this.LoginScreen_Resize);
            this.panelLogin.ResumeLayout(false);
            this.panelChild.ResumeLayout(false);
            this.panelChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxShowHide)).EndInit();
            this.panelBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lbStore;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.PictureBox pboxBackground;
        private LoginUsername loginUsername;
        private LoginPassword loginPassword;
        private System.Windows.Forms.PictureBox pboxShowHide;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelChild;
    }
}