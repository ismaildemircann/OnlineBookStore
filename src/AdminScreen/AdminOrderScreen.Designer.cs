namespace Online_Book_Store.adminScreen
{
    partial class AdminOrderScreen
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
            this.flpOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnShip = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpOrders
            // 
            this.flpOrders.AutoScroll = true;
            this.flpOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpOrders.Location = new System.Drawing.Point(0, 0);
            this.flpOrders.Margin = new System.Windows.Forms.Padding(4);
            this.flpOrders.Name = "flpOrders";
            this.flpOrders.Size = new System.Drawing.Size(493, 671);
            this.flpOrders.TabIndex = 0;
            // 
            // flpItems
            // 
            this.flpItems.AutoScroll = true;
            this.flpItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.flpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpItems.Location = new System.Drawing.Point(497, 0);
            this.flpItems.Margin = new System.Windows.Forms.Padding(4);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(1100, 605);
            this.flpItems.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Controls.Add(this.btnShip);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(497, 605);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1100, 66);
            this.panelBottom.TabIndex = 2;
            this.panelBottom.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(172)))), ((int)(((byte)(197)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnCancel.Location = new System.Drawing.Point(803, 17);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnShip
            // 
            this.btnShip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnShip.FlatAppearance.BorderSize = 0;
            this.btnShip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(172)))), ((int)(((byte)(197)))));
            this.btnShip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
            this.btnShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnShip.Location = new System.Drawing.Point(947, 17);
            this.btnShip.Margin = new System.Windows.Forms.Padding(4);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(116, 34);
            this.btnShip.TabIndex = 8;
            this.btnShip.Text = "Ship Order";
            this.btnShip.UseVisualStyleBackColor = false;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColor.Location = new System.Drawing.Point(493, 0);
            this.panelColor.Margin = new System.Windows.Forms.Padding(4);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(4, 671);
            this.panelColor.TabIndex = 3;
            // 
            // AdminOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 671);
            this.Controls.Add(this.flpItems);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.flpOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminOrderScreen";
            this.Text = "AdminOrderScreen";
            this.Load += new System.EventHandler(this.AdminOrderScreen_Load);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpOrders;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelColor;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnShip;
    }
}