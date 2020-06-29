namespace Online_Book_Store
{
    partial class MagazineScreen
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
            this.flpMagazinList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPriceRange = new System.Windows.Forms.Button();
            this.pnlTre = new System.Windows.Forms.Panel();
            this.txtMaxPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtMinPrice = new System.Windows.Forms.MaskedTextBox();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMagazinList
            // 
            this.flpMagazinList.AutoScroll = true;
            this.flpMagazinList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.flpMagazinList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMagazinList.Location = new System.Drawing.Point(0, 24);
            this.flpMagazinList.Margin = new System.Windows.Forms.Padding(4);
            this.flpMagazinList.Name = "flpMagazinList";
            this.flpMagazinList.Size = new System.Drawing.Size(1240, 566);
            this.flpMagazinList.TabIndex = 0;
            this.flpMagazinList.VisibleChanged += new System.EventHandler(this.flpMagazinList_VisibleChanged);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.pnlSearch.Controls.Add(this.btnPriceRange);
            this.pnlSearch.Controls.Add(this.pnlTre);
            this.pnlSearch.Controls.Add(this.txtMaxPrice);
            this.pnlSearch.Controls.Add(this.txtMinPrice);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1240, 24);
            this.pnlSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(454, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search here";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnPriceRange
            // 
            this.btnPriceRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.btnPriceRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnPriceRange.Location = new System.Drawing.Point(1081, -1);
            this.btnPriceRange.Name = "btnPriceRange";
            this.btnPriceRange.Size = new System.Drawing.Size(159, 24);
            this.btnPriceRange.TabIndex = 8;
            this.btnPriceRange.Text = "Apply Price Filter";
            this.btnPriceRange.UseVisualStyleBackColor = false;
            this.btnPriceRange.Click += new System.EventHandler(this.btnPriceRange_Click);
            // 
            // pnlTre
            // 
            this.pnlTre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pnlTre.Location = new System.Drawing.Point(984, 12);
            this.pnlTre.Name = "pnlTre";
            this.pnlTre.Size = new System.Drawing.Size(10, 5);
            this.pnlTre.TabIndex = 7;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(1009, 0);
            this.txtMaxPrice.Mask = "00000";
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(48, 22);
            this.txtMaxPrice.TabIndex = 6;
            this.txtMaxPrice.ValidatingType = typeof(int);
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(921, 0);
            this.txtMinPrice.Mask = "00000";
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(48, 22);
            this.txtMinPrice.TabIndex = 5;
            this.txtMinPrice.ValidatingType = typeof(int);
            // 
            // MagazineScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1240, 590);
            this.Controls.Add(this.flpMagazinList);
            this.Controls.Add(this.pnlSearch);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MagazineScreen";
            this.Text = "MagazineScreen";
            this.Load += new System.EventHandler(this.MagazineScreen_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMagazinList;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPriceRange;
        private System.Windows.Forms.Panel pnlTre;
        private System.Windows.Forms.MaskedTextBox txtMaxPrice;
        private System.Windows.Forms.MaskedTextBox txtMinPrice;
    }
}