namespace Online_Book_Store
{
    partial class MagazinDesign
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
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblIssue = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlQuantity = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.picMagazine = new System.Windows.Forms.PictureBox();
            this.panelSide = new System.Windows.Forms.Panel();
            this.pnlInformation.SuspendLayout();
            this.pnlQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMagazine)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInformation
            // 
            this.pnlInformation.Controls.Add(this.lblPrice);
            this.pnlInformation.Controls.Add(this.lblIssue);
            this.pnlInformation.Controls.Add(this.lblType);
            this.pnlInformation.Controls.Add(this.lblName);
            this.pnlInformation.Font = new System.Drawing.Font("Corbel", 9F);
            this.pnlInformation.Location = new System.Drawing.Point(0, 156);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(220, 196);
            this.pnlInformation.TabIndex = 2;
            this.pnlInformation.MouseEnter += new System.EventHandler(this.pnlInformation_MouseEnter);
            this.pnlInformation.MouseLeave += new System.EventHandler(this.pnlInformation_MouseLeave);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPrice.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.lblPrice.Location = new System.Drawing.Point(21, 158);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price: ";
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblIssue.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.lblIssue.Location = new System.Drawing.Point(21, 111);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(44, 17);
            this.lblIssue.TabIndex = 8;
            this.lblIssue.Text = "Issue: ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblType.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.lblType.Location = new System.Drawing.Point(21, 64);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 17);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Type: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblName.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.lblName.Location = new System.Drawing.Point(21, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 17);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name: ";
            // 
            // pnlQuantity
            // 
            this.pnlQuantity.Controls.Add(this.panelBottom);
            this.pnlQuantity.Controls.Add(this.btnIncrease);
            this.pnlQuantity.Controls.Add(this.btnAdd);
            this.pnlQuantity.Controls.Add(this.btnDecrease);
            this.pnlQuantity.Controls.Add(this.lblNumber);
            this.pnlQuantity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlQuantity.Location = new System.Drawing.Point(0, 346);
            this.pnlQuantity.Name = "pnlQuantity";
            this.pnlQuantity.Size = new System.Drawing.Size(220, 79);
            this.pnlQuantity.TabIndex = 1;
            this.pnlQuantity.MouseEnter += new System.EventHandler(this.pnlQuantity_MouseEnter);
            this.pnlQuantity.MouseLeave += new System.EventHandler(this.pnlQuantity_MouseLeave);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panelBottom.Location = new System.Drawing.Point(0, 78);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(220, 18);
            this.panelBottom.TabIndex = 3;
            // 
            // btnIncrease
            // 
            this.btnIncrease.FlatAppearance.BorderSize = 0;
            this.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease.Image = global::Online_Book_Store.Properties.Resources.plus;
            this.btnIncrease.Location = new System.Drawing.Point(130, 11);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(24, 24);
            this.btnIncrease.TabIndex = 17;
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(172)))), ((int)(((byte)(197)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnAdd.Location = new System.Drawing.Point(66, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 28);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // btnDecrease
            // 
            this.btnDecrease.FlatAppearance.BorderSize = 0;
            this.btnDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrease.Image = global::Online_Book_Store.Properties.Resources.minus;
            this.btnDecrease.Location = new System.Drawing.Point(66, 11);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(24, 24);
            this.btnDecrease.TabIndex = 16;
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblNumber.Location = new System.Drawing.Point(100, 10);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(28, 33);
            this.lblNumber.TabIndex = 9;
            this.lblNumber.Text = "1";
            // 
            // picMagazine
            // 
            this.picMagazine.Location = new System.Drawing.Point(50, 8);
            this.picMagazine.Name = "picMagazine";
            this.picMagazine.Size = new System.Drawing.Size(120, 150);
            this.picMagazine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMagazine.TabIndex = 0;
            this.picMagazine.TabStop = false;
            this.picMagazine.MouseEnter += new System.EventHandler(this.picMagazine_MouseEnter);
            this.picMagazine.MouseLeave += new System.EventHandler(this.picMagazine_MouseLeave);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panelSide.Location = new System.Drawing.Point(219, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(200, 437);
            this.panelSide.TabIndex = 3;
            // 
            // MagazinDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.picMagazine);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.pnlQuantity);
            this.Controls.Add(this.pnlInformation);
            this.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MagazinDesign";
            this.Size = new System.Drawing.Size(220, 425);
            this.MouseEnter += new System.EventHandler(this.MagazinDesign_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MagazinDesign_MouseLeave);
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            this.pnlQuantity.ResumeLayout(false);
            this.pnlQuantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMagazine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMagazine;
        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Panel pnlQuantity;
        private System.Windows.Forms.Button btnIncrease;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDecrease;
        public System.Windows.Forms.Label lblNumber;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblIssue;
        public System.Windows.Forms.Label lblType;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelSide;
    }
}
