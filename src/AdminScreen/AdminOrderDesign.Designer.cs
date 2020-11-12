namespace Online_Book_Store.adminScreen
{
    partial class AdminOrderDesign
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
            this.btnShow = new System.Windows.Forms.Button();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.lbPaymentType = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(172)))), ((int)(((byte)(197)))));
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnShow.Location = new System.Drawing.Point(309, 135);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(116, 34);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show Details";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Location = new System.Drawing.Point(35, 34);
            this.lbCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(76, 17);
            this.lbCustomer.TabIndex = 8;
            this.lbCustomer.Text = "Customer: ";
            // 
            // lbPaymentType
            // 
            this.lbPaymentType.AutoSize = true;
            this.lbPaymentType.Location = new System.Drawing.Point(35, 63);
            this.lbPaymentType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPaymentType.Name = "lbPaymentType";
            this.lbPaymentType.Size = new System.Drawing.Size(107, 17);
            this.lbPaymentType.TabIndex = 9;
            this.lbPaymentType.Text = "Payment Type: ";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(35, 91);
            this.lbAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(100, 17);
            this.lbAmount.TabIndex = 10;
            this.lbAmount.Text = "Total Amount: ";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(35, 119);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(56, 17);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "Status: ";
            // 
            // AdminOrderDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbPaymentType);
            this.Controls.Add(this.lbCustomer);
            this.Controls.Add(this.btnShow);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminOrderDesign";
            this.Size = new System.Drawing.Size(436, 185);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbPaymentType;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbStatus;
    }
}
