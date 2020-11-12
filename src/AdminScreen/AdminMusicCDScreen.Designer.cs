namespace Online_Book_Store
{
    partial class AdminMusicCDScreen
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNewMusicCD = new System.Windows.Forms.Button();
            this.btnUpdateSelected = new System.Windows.Forms.Button();
            this.panelAddMusicCD = new System.Windows.Forms.Panel();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSinger = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbSinger = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pboxMusicCD = new System.Windows.Forms.PictureBox();
            this.listViewMusicCDs = new System.Windows.Forms.ListView();
            this.panelAddMusicCD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMusicCD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(316, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 40);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Selected Music CD";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNewMusicCD
            // 
            this.btnAddNewMusicCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnAddNewMusicCD.FlatAppearance.BorderSize = 0;
            this.btnAddNewMusicCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewMusicCD.Location = new System.Drawing.Point(415, 430);
            this.btnAddNewMusicCD.Name = "btnAddNewMusicCD";
            this.btnAddNewMusicCD.Size = new System.Drawing.Size(83, 40);
            this.btnAddNewMusicCD.TabIndex = 12;
            this.btnAddNewMusicCD.Text = "Add New Music CD";
            this.btnAddNewMusicCD.UseVisualStyleBackColor = false;
            this.btnAddNewMusicCD.Click += new System.EventHandler(this.btnAddNewMusicCD_Click);
            // 
            // btnUpdateSelected
            // 
            this.btnUpdateSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnUpdateSelected.FlatAppearance.BorderSize = 0;
            this.btnUpdateSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSelected.Location = new System.Drawing.Point(504, 430);
            this.btnUpdateSelected.Name = "btnUpdateSelected";
            this.btnUpdateSelected.Size = new System.Drawing.Size(101, 40);
            this.btnUpdateSelected.TabIndex = 13;
            this.btnUpdateSelected.Text = "Update Selected Music CD";
            this.btnUpdateSelected.UseVisualStyleBackColor = false;
            this.btnUpdateSelected.Click += new System.EventHandler(this.btnUpdateSelected_Click);
            // 
            // panelAddMusicCD
            // 
            this.panelAddMusicCD.Controls.Add(this.cBoxType);
            this.panelAddMusicCD.Controls.Add(this.btnSelectImage);
            this.panelAddMusicCD.Controls.Add(this.btnUpdate);
            this.panelAddMusicCD.Controls.Add(this.btnAdd);
            this.panelAddMusicCD.Controls.Add(this.txtSinger);
            this.panelAddMusicCD.Controls.Add(this.txtPrice);
            this.panelAddMusicCD.Controls.Add(this.txtID);
            this.panelAddMusicCD.Controls.Add(this.txtName);
            this.panelAddMusicCD.Controls.Add(this.lbType);
            this.panelAddMusicCD.Controls.Add(this.lbSinger);
            this.panelAddMusicCD.Controls.Add(this.lbPrice);
            this.panelAddMusicCD.Controls.Add(this.lbID);
            this.panelAddMusicCD.Controls.Add(this.lbName);
            this.panelAddMusicCD.Controls.Add(this.pboxMusicCD);
            this.panelAddMusicCD.Location = new System.Drawing.Point(637, 66);
            this.panelAddMusicCD.Name = "panelAddMusicCD";
            this.panelAddMusicCD.Size = new System.Drawing.Size(281, 358);
            this.panelAddMusicCD.TabIndex = 11;
            // 
            // cBoxType
            // 
            this.cBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.Items.AddRange(new object[] {
            "Romance",
            "HardRock",
            "Country"});
            this.cBoxType.Location = new System.Drawing.Point(79, 227);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(100, 21);
            this.cBoxType.TabIndex = 18;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSelectImage.FlatAppearance.BorderSize = 0;
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.Location = new System.Drawing.Point(194, 81);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(84, 23);
            this.btnSelectImage.TabIndex = 17;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(92, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(92, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSinger
            // 
            this.txtSinger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtSinger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSinger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtSinger.Location = new System.Drawing.Point(79, 202);
            this.txtSinger.Name = "txtSinger";
            this.txtSinger.Size = new System.Drawing.Size(100, 20);
            this.txtSinger.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtPrice.Location = new System.Drawing.Point(79, 176);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtID.Location = new System.Drawing.Point(79, 150);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 9;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.txtName.Location = new System.Drawing.Point(79, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 8;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(36, 230);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(37, 13);
            this.lbType.TabIndex = 5;
            this.lbType.Text = "Type: ";
            // 
            // lbSinger
            // 
            this.lbSinger.AutoSize = true;
            this.lbSinger.Location = new System.Drawing.Point(33, 204);
            this.lbSinger.Name = "lbSinger";
            this.lbSinger.Size = new System.Drawing.Size(40, 13);
            this.lbSinger.TabIndex = 4;
            this.lbSinger.Text = "Singer:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(36, 178);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(37, 13);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Price: ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(52, 152);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "ID:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(35, 126);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name:";
            // 
            // pboxMusicCD
            // 
            this.pboxMusicCD.Location = new System.Drawing.Point(87, 18);
            this.pboxMusicCD.Name = "pboxMusicCD";
            this.pboxMusicCD.Size = new System.Drawing.Size(80, 100);
            this.pboxMusicCD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMusicCD.TabIndex = 0;
            this.pboxMusicCD.TabStop = false;
            // 
            // listViewMusicCDs
            // 
            this.listViewMusicCDs.FullRowSelect = true;
            this.listViewMusicCDs.HideSelection = false;
            this.listViewMusicCDs.Location = new System.Drawing.Point(59, 66);
            this.listViewMusicCDs.Name = "listViewMusicCDs";
            this.listViewMusicCDs.Size = new System.Drawing.Size(555, 358);
            this.listViewMusicCDs.TabIndex = 10;
            this.listViewMusicCDs.UseCompatibleStateImageBehavior = false;
            this.listViewMusicCDs.View = System.Windows.Forms.View.Details;
            this.listViewMusicCDs.SelectedIndexChanged += new System.EventHandler(this.listViewMusicCDs_SelectedIndexChanged);
            // 
            // AdminMusicCDScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1198, 545);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNewMusicCD);
            this.Controls.Add(this.btnUpdateSelected);
            this.Controls.Add(this.panelAddMusicCD);
            this.Controls.Add(this.listViewMusicCDs);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMusicCDScreen";
            this.Text = "AdminMusicCDScreen";
            this.Load += new System.EventHandler(this.AdminMusicCDScreen_Load);
            this.panelAddMusicCD.ResumeLayout(false);
            this.panelAddMusicCD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMusicCD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNewMusicCD;
        private System.Windows.Forms.Button btnUpdateSelected;
        private System.Windows.Forms.Panel panelAddMusicCD;
        private System.Windows.Forms.ComboBox cBoxType;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSinger;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbSinger;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pboxMusicCD;
        private System.Windows.Forms.ListView listViewMusicCDs;
    }
}