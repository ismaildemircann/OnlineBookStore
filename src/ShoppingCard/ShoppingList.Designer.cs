namespace Online_Book_Store
{
    partial class ShoppingList
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
            this.flpShoppingList = new System.Windows.Forms.FlowLayoutPanel();
            this.paymentPanel = new System.Windows.Forms.Panel();
            this.btnContinueShopping = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.paymentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpShoppingList
            // 
            this.flpShoppingList.AutoScroll = true;
            this.flpShoppingList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.flpShoppingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpShoppingList.Location = new System.Drawing.Point(0, 0);
            this.flpShoppingList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpShoppingList.Name = "flpShoppingList";
            this.flpShoppingList.Size = new System.Drawing.Size(1391, 705);
            this.flpShoppingList.TabIndex = 0;
            // 
            // paymentPanel
            // 
            this.paymentPanel.Controls.Add(this.btnContinueShopping);
            this.paymentPanel.Controls.Add(this.btnCheckout);
            this.paymentPanel.Controls.Add(this.btnCancel);
            this.paymentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paymentPanel.Location = new System.Drawing.Point(0, 705);
            this.paymentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Size = new System.Drawing.Size(1391, 80);
            this.paymentPanel.TabIndex = 0;
            // 
            // btnContinueShopping
            // 
            this.btnContinueShopping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnContinueShopping.FlatAppearance.BorderSize = 0;
            this.btnContinueShopping.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(172)))), ((int)(((byte)(197)))));
            this.btnContinueShopping.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
            this.btnContinueShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinueShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContinueShopping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnContinueShopping.Location = new System.Drawing.Point(37, 22);
            this.btnContinueShopping.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinueShopping.Name = "btnContinueShopping";
            this.btnContinueShopping.Size = new System.Drawing.Size(182, 34);
            this.btnContinueShopping.TabIndex = 21;
            this.btnContinueShopping.Text = "Continue Shopping";
            this.btnContinueShopping.UseVisualStyleBackColor = false;
            this.btnContinueShopping.Click += new System.EventHandler(this.btnContinueShopping_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(172)))), ((int)(((byte)(197)))));
            this.btnCheckout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnCheckout.Location = new System.Drawing.Point(1219, 22);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(133, 34);
            this.btnCheckout.TabIndex = 20;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(172)))), ((int)(((byte)(197)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnCancel.Location = new System.Drawing.Point(1078, 22);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 34);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1391, 785);
            this.Controls.Add(this.flpShoppingList);
            this.Controls.Add(this.paymentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShoppingList";
            this.Text = "ShoppingList";
            this.Load += new System.EventHandler(this.ShoppingList_Load);
            this.VisibleChanged += new System.EventHandler(this.ShoppingList_VisibleChanged);
            this.paymentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpShoppingList;
        private System.Windows.Forms.Panel paymentPanel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnContinueShopping;
    }
}