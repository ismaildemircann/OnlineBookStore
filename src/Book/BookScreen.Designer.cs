﻿namespace Online_Book_Store
{
    partial class BookScreen
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
            this.flpBookList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtMinPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtMaxPrice = new System.Windows.Forms.MaskedTextBox();
            this.pnlTre = new System.Windows.Forms.Panel();
            this.btnPriceRange = new System.Windows.Forms.Button();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpBookList
            // 
            this.flpBookList.AutoScroll = true;
            this.flpBookList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.flpBookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBookList.Location = new System.Drawing.Point(0, 24);
            this.flpBookList.Margin = new System.Windows.Forms.Padding(4);
            this.flpBookList.Name = "flpBookList";
            this.flpBookList.Size = new System.Drawing.Size(1240, 566);
            this.flpBookList.TabIndex = 0;
            this.flpBookList.VisibleChanged += new System.EventHandler(this.flpBookList_VisibleChanged);
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
            this.pnlSearch.TabIndex = 1;
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
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(921, 0);
            this.txtMinPrice.Mask = "00000";
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(48, 22);
            this.txtMinPrice.TabIndex = 1;
            this.txtMinPrice.ValidatingType = typeof(int);
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(1009, 0);
            this.txtMaxPrice.Mask = "00000";
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(48, 22);
            this.txtMaxPrice.TabIndex = 2;
            this.txtMaxPrice.ValidatingType = typeof(int);
            // 
            // pnlTre
            // 
            this.pnlTre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pnlTre.Location = new System.Drawing.Point(984, 12);
            this.pnlTre.Name = "pnlTre";
            this.pnlTre.Size = new System.Drawing.Size(10, 5);
            this.pnlTre.TabIndex = 3;
            // 
            // btnPriceRange
            // 
            this.btnPriceRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.btnPriceRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnPriceRange.Location = new System.Drawing.Point(1081, -1);
            this.btnPriceRange.Name = "btnPriceRange";
            this.btnPriceRange.Size = new System.Drawing.Size(159, 24);
            this.btnPriceRange.TabIndex = 4;
            this.btnPriceRange.Text = "Apply Price Filter";
            this.btnPriceRange.UseVisualStyleBackColor = false;
            this.btnPriceRange.Click += new System.EventHandler(this.btnPriceRange_Click);
            // 
            // BookScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 590);
            this.Controls.Add(this.flpBookList);
            this.Controls.Add(this.pnlSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookScreen";
            this.Text = "BookScreen";
            this.Load += new System.EventHandler(this.BookScreen_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBookList;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.MaskedTextBox txtMinPrice;
        private System.Windows.Forms.Button btnPriceRange;
        private System.Windows.Forms.Panel pnlTre;
        private System.Windows.Forms.MaskedTextBox txtMaxPrice;
    }
}