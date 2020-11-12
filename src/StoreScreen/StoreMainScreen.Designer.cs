namespace Online_Book_Store
{
    partial class StoreMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreMainScreen));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnMyOrders = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnCDs = new System.Windows.Forms.Button();
            this.btnMagazines = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.paneldashbord = new System.Windows.Forms.Panel();
            this.lbDashbord = new System.Windows.Forms.Label();
            this.panelBase = new System.Windows.Forms.Panel();
            this.pboxBanner = new System.Windows.Forms.PictureBox();
            this.panelInfo.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.paneldashbord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelInfo.Controls.Add(this.lblWelcome);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 712);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1373, 26);
            this.panelInfo.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.Location = new System.Drawing.Point(549, 4);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 18);
            this.lblWelcome.TabIndex = 0;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.panelSidebar.Controls.Add(this.btnMyOrders);
            this.panelSidebar.Controls.Add(this.btnAdmin);
            this.panelSidebar.Controls.Add(this.btnLogOut);
            this.panelSidebar.Controls.Add(this.btnCart);
            this.panelSidebar.Controls.Add(this.btnCDs);
            this.panelSidebar.Controls.Add(this.btnMagazines);
            this.panelSidebar.Controls.Add(this.btnBook);
            this.panelSidebar.Controls.Add(this.paneldashbord);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 123);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(133, 589);
            this.panelSidebar.TabIndex = 2;
            this.panelSidebar.Resize += new System.EventHandler(this.panelSidebar_Resize);
            // 
            // btnMyOrders
            // 
            this.btnMyOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.btnMyOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyOrders.FlatAppearance.BorderSize = 0;
            this.btnMyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnMyOrders.Image = global::Online_Book_Store.Properties.Resources.orderIco;
            this.btnMyOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyOrders.Location = new System.Drawing.Point(0, 245);
            this.btnMyOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Size = new System.Drawing.Size(133, 49);
            this.btnMyOrders.TabIndex = 5;
            this.btnMyOrders.Text = "My Orders";
            this.btnMyOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMyOrders.UseVisualStyleBackColor = false;
            this.btnMyOrders.Click += new System.EventHandler(this.btnMyOrders_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnAdmin.Image = global::Online_Book_Store.Properties.Resources.adminIcon;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 491);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(133, 49);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnLogOut.Image = global::Online_Book_Store.Properties.Resources.logoutIco;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 540);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(133, 49);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnCart.Image = global::Online_Book_Store.Properties.Resources.cartIcon;
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(0, 196);
            this.btnCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(133, 49);
            this.btnCart.TabIndex = 4;
            this.btnCart.Text = "Cart";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnCDs
            // 
            this.btnCDs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.btnCDs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCDs.FlatAppearance.BorderSize = 0;
            this.btnCDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCDs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnCDs.Image = global::Online_Book_Store.Properties.Resources.cd;
            this.btnCDs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCDs.Location = new System.Drawing.Point(0, 147);
            this.btnCDs.Margin = new System.Windows.Forms.Padding(4);
            this.btnCDs.Name = "btnCDs";
            this.btnCDs.Size = new System.Drawing.Size(133, 49);
            this.btnCDs.TabIndex = 3;
            this.btnCDs.Text = "CDs";
            this.btnCDs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCDs.UseVisualStyleBackColor = false;
            this.btnCDs.Click += new System.EventHandler(this.btnCDs_Click);
            // 
            // btnMagazines
            // 
            this.btnMagazines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.btnMagazines.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMagazines.FlatAppearance.BorderSize = 0;
            this.btnMagazines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagazines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnMagazines.Image = global::Online_Book_Store.Properties.Resources.magazineIcon;
            this.btnMagazines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMagazines.Location = new System.Drawing.Point(0, 98);
            this.btnMagazines.Margin = new System.Windows.Forms.Padding(4);
            this.btnMagazines.Name = "btnMagazines";
            this.btnMagazines.Size = new System.Drawing.Size(133, 49);
            this.btnMagazines.TabIndex = 2;
            this.btnMagazines.Text = "Magazines";
            this.btnMagazines.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMagazines.UseVisualStyleBackColor = false;
            this.btnMagazines.Click += new System.EventHandler(this.btnMagazines_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBook.Image")));
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(0, 49);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(133, 49);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Books";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // paneldashbord
            // 
            this.paneldashbord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.paneldashbord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneldashbord.Controls.Add(this.lbDashbord);
            this.paneldashbord.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneldashbord.Location = new System.Drawing.Point(0, 0);
            this.paneldashbord.Margin = new System.Windows.Forms.Padding(4);
            this.paneldashbord.Name = "paneldashbord";
            this.paneldashbord.Size = new System.Drawing.Size(133, 49);
            this.paneldashbord.TabIndex = 0;
            // 
            // lbDashbord
            // 
            this.lbDashbord.AutoSize = true;
            this.lbDashbord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDashbord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lbDashbord.Location = new System.Drawing.Point(16, 15);
            this.lbDashbord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDashbord.Name = "lbDashbord";
            this.lbDashbord.Size = new System.Drawing.Size(91, 20);
            this.lbDashbord.TabIndex = 0;
            this.lbDashbord.Text = "Dashboard";
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(133, 123);
            this.panelBase.Margin = new System.Windows.Forms.Padding(4);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(1240, 589);
            this.panelBase.TabIndex = 3;
            // 
            // pboxBanner
            // 
            this.pboxBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pboxBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pboxBanner.Image = ((System.Drawing.Image)(resources.GetObject("pboxBanner.Image")));
            this.pboxBanner.Location = new System.Drawing.Point(0, 0);
            this.pboxBanner.Margin = new System.Windows.Forms.Padding(4);
            this.pboxBanner.Name = "pboxBanner";
            this.pboxBanner.Size = new System.Drawing.Size(1373, 123);
            this.pboxBanner.TabIndex = 0;
            this.pboxBanner.TabStop = false;
            // 
            // StoreMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 738);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.pboxBanner);
            this.Controls.Add(this.panelInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StoreMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocean Store";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StoreMainScreen_FormClosed);
            this.Load += new System.EventHandler(this.StoreMainScreen_Load);
            this.Resize += new System.EventHandler(this.StoreMainScreen_Resize);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.paneldashbord.ResumeLayout(false);
            this.paneldashbord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxBanner;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Panel paneldashbord;
        private System.Windows.Forms.Label lbDashbord;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnMagazines;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnCDs;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnMyOrders;
    }
}