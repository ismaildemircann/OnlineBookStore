namespace Online_Book_Store
{
    partial class AdminScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            this.pboxBanner = new System.Windows.Forms.PictureBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCDs = new System.Windows.Forms.Button();
            this.btnMagazines = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.paneldashbord = new System.Windows.Forms.Panel();
            this.lbDashbord = new System.Windows.Forms.Label();
            this.panelBase = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBanner)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.paneldashbord.SuspendLayout();
            this.SuspendLayout();
            // 
            // pboxBanner
            // 
            this.pboxBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pboxBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pboxBanner.Image = global::Online_Book_Store.Properties.Resources.bannerAdmin;
            this.pboxBanner.Location = new System.Drawing.Point(0, 0);
            this.pboxBanner.Name = "pboxBanner";
            this.pboxBanner.Size = new System.Drawing.Size(1350, 100);
            this.pboxBanner.TabIndex = 1;
            this.pboxBanner.TabStop = false;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 645);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1350, 21);
            this.panelInfo.TabIndex = 4;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.panelSidebar.Controls.Add(this.btnOrders);
            this.panelSidebar.Controls.Add(this.btnCDs);
            this.panelSidebar.Controls.Add(this.btnMagazines);
            this.panelSidebar.Controls.Add(this.btnBook);
            this.panelSidebar.Controls.Add(this.paneldashbord);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 100);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(152, 545);
            this.panelSidebar.TabIndex = 5;
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnOrders.Image = global::Online_Book_Store.Properties.Resources.orderIco;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(0, 160);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(152, 40);
            this.btnOrders.TabIndex = 4;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
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
            this.btnCDs.Location = new System.Drawing.Point(0, 120);
            this.btnCDs.Name = "btnCDs";
            this.btnCDs.Size = new System.Drawing.Size(152, 40);
            this.btnCDs.TabIndex = 3;
            this.btnCDs.Text = "CDs";
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
            this.btnMagazines.Location = new System.Drawing.Point(0, 80);
            this.btnMagazines.Name = "btnMagazines";
            this.btnMagazines.Size = new System.Drawing.Size(152, 40);
            this.btnMagazines.TabIndex = 2;
            this.btnMagazines.Text = "Magazines";
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
            this.btnBook.Location = new System.Drawing.Point(0, 40);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(152, 40);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Books";
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
            this.paneldashbord.Name = "paneldashbord";
            this.paneldashbord.Size = new System.Drawing.Size(152, 40);
            this.paneldashbord.TabIndex = 0;
            // 
            // lbDashbord
            // 
            this.lbDashbord.AutoSize = true;
            this.lbDashbord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDashbord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lbDashbord.Location = new System.Drawing.Point(12, 12);
            this.lbDashbord.Name = "lbDashbord";
            this.lbDashbord.Size = new System.Drawing.Size(76, 16);
            this.lbDashbord.TabIndex = 0;
            this.lbDashbord.Text = "Dashboard";
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(152, 100);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(1198, 545);
            this.panelBase.TabIndex = 6;
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 666);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.pboxBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "AdminScreen";
            this.Text = "Ocean Store Admin View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxBanner)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.paneldashbord.ResumeLayout(false);
            this.paneldashbord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxBanner;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnCDs;
        private System.Windows.Forms.Button btnMagazines;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Panel paneldashbord;
        private System.Windows.Forms.Label lbDashbord;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Button btnOrders;
    }
}