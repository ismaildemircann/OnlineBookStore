namespace Online_Book_Store
{
    partial class ShoppingCardForm
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
            this.menuStripShoppingCard = new System.Windows.Forms.MenuStrip();
            this.shoppingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlShoppingCard = new System.Windows.Forms.Panel();
            this.menuStripShoppingCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripShoppingCard
            // 
            this.menuStripShoppingCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.menuStripShoppingCard.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripShoppingCard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shoppingListToolStripMenuItem});
            this.menuStripShoppingCard.Location = new System.Drawing.Point(0, 0);
            this.menuStripShoppingCard.Name = "menuStripShoppingCard";
            this.menuStripShoppingCard.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripShoppingCard.Size = new System.Drawing.Size(1373, 30);
            this.menuStripShoppingCard.TabIndex = 2;
            this.menuStripShoppingCard.Text = "menuStrip1";
            // 
            // shoppingListToolStripMenuItem
            // 
            this.shoppingListToolStripMenuItem.Name = "shoppingListToolStripMenuItem";
            this.shoppingListToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.shoppingListToolStripMenuItem.Text = "Shopping List";
            this.shoppingListToolStripMenuItem.Click += new System.EventHandler(this.shoppingListToolStripMenuItem_Click);
            // 
            // pnlShoppingCard
            // 
            this.pnlShoppingCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pnlShoppingCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShoppingCard.Location = new System.Drawing.Point(0, 30);
            this.pnlShoppingCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlShoppingCard.Name = "pnlShoppingCard";
            this.pnlShoppingCard.Size = new System.Drawing.Size(1373, 708);
            this.pnlShoppingCard.TabIndex = 3;
            // 
            // ShoppingCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 738);
            this.Controls.Add(this.pnlShoppingCard);
            this.Controls.Add(this.menuStripShoppingCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ShoppingCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoppingCardForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShoppingCardForm_FormClosed);
            this.Load += new System.EventHandler(this.ShoppingCardForm_Load);
            this.menuStripShoppingCard.ResumeLayout(false);
            this.menuStripShoppingCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripShoppingCard;
        private System.Windows.Forms.ToolStripMenuItem shoppingListToolStripMenuItem;
        private System.Windows.Forms.Panel pnlShoppingCard;
    }
}