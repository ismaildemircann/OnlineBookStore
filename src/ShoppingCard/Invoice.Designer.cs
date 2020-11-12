namespace Online_Book_Store.shoppingCard
{
    partial class Invoice
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
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.chkSecondAddress = new System.Windows.Forms.CheckBox();
            this.chkFirstAddress = new System.Windows.Forms.CheckBox();
            this.pnlPaymentType = new System.Windows.Forms.Panel();
            this.pnlCreditCard = new System.Windows.Forms.Panel();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblCardInfo = new System.Windows.Forms.Label();
            this.mtxtboxCVV = new System.Windows.Forms.MaskedTextBox();
            this.mtxtboxCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtboxNameOnCard = new System.Windows.Forms.TextBox();
            this.lblExprity = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.lblNameOnCard = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.pnlTransfer = new System.Windows.Forms.Panel();
            this.lbDrawee = new System.Windows.Forms.Label();
            this.picGaranti = new System.Windows.Forms.PictureBox();
            this.picZiraat = new System.Windows.Forms.PictureBox();
            this.picFinans = new System.Windows.Forms.PictureBox();
            this.picYapı = new System.Windows.Forms.PictureBox();
            this.lblTR = new System.Windows.Forms.Label();
            this.mtxtboxIBAN = new System.Windows.Forms.MaskedTextBox();
            this.chkboxGaranti = new System.Windows.Forms.CheckBox();
            this.chkboxZiraat = new System.Windows.Forms.CheckBox();
            this.chkboxFinans = new System.Windows.Forms.CheckBox();
            this.chkboxYapıKredi = new System.Windows.Forms.CheckBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.chkboxTransfer = new System.Windows.Forms.CheckBox();
            this.chkCreditCard = new System.Windows.Forms.CheckBox();
            this.chkCash = new System.Windows.Forms.CheckBox();
            this.pnlVerification = new System.Windows.Forms.Panel();
            this.btnVerify = new System.Windows.Forms.Button();
            this.mtxtboxVerificationCode = new System.Windows.Forms.MaskedTextBox();
            this.lblVerificationInfo = new System.Windows.Forms.Label();
            this.lblVerification = new System.Windows.Forms.Label();
            this.pnlCargo = new System.Windows.Forms.Panel();
            this.chkboxArasCargo = new System.Windows.Forms.CheckBox();
            this.chkboxMNGCargo = new System.Windows.Forms.CheckBox();
            this.pnlInvoiceSummary = new System.Windows.Forms.Panel();
            this.btnContinueShopping = new System.Windows.Forms.Button();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCargoPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblInvioceSummary = new System.Windows.Forms.Label();
            this.pnlAddress.SuspendLayout();
            this.pnlPaymentType.SuspendLayout();
            this.pnlCreditCard.SuspendLayout();
            this.pnlTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGaranti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZiraat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYapı)).BeginInit();
            this.pnlVerification.SuspendLayout();
            this.pnlCargo.SuspendLayout();
            this.pnlInvoiceSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddress
            // 
            this.pnlAddress.Controls.Add(this.txtAddress);
            this.pnlAddress.Controls.Add(this.chkSecondAddress);
            this.pnlAddress.Controls.Add(this.chkFirstAddress);
            this.pnlAddress.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlAddress.Location = new System.Drawing.Point(19, 12);
            this.pnlAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(452, 199);
            this.pnlAddress.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(175, 18);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(265, 170);
            this.txtAddress.TabIndex = 2;
            // 
            // chkSecondAddress
            // 
            this.chkSecondAddress.AutoSize = true;
            this.chkSecondAddress.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSecondAddress.Location = new System.Drawing.Point(3, 121);
            this.chkSecondAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSecondAddress.Name = "chkSecondAddress";
            this.chkSecondAddress.Size = new System.Drawing.Size(154, 28);
            this.chkSecondAddress.TabIndex = 1;
            this.chkSecondAddress.Text = "Other Address";
            this.chkSecondAddress.UseVisualStyleBackColor = true;
            this.chkSecondAddress.CheckedChanged += new System.EventHandler(this.chkSecondAddress_CheckedChanged);
            // 
            // chkFirstAddress
            // 
            this.chkFirstAddress.AutoSize = true;
            this.chkFirstAddress.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkFirstAddress.Location = new System.Drawing.Point(4, 63);
            this.chkFirstAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFirstAddress.Name = "chkFirstAddress";
            this.chkFirstAddress.Size = new System.Drawing.Size(130, 28);
            this.chkFirstAddress.TabIndex = 0;
            this.chkFirstAddress.Text = "My Address";
            this.chkFirstAddress.UseVisualStyleBackColor = true;
            this.chkFirstAddress.CheckedChanged += new System.EventHandler(this.chkFirstAddress_CheckedChanged);
            // 
            // pnlPaymentType
            // 
            this.pnlPaymentType.Controls.Add(this.pnlCreditCard);
            this.pnlPaymentType.Controls.Add(this.pnlTransfer);
            this.pnlPaymentType.Controls.Add(this.btnPlaceOrder);
            this.pnlPaymentType.Controls.Add(this.chkboxTransfer);
            this.pnlPaymentType.Controls.Add(this.chkCreditCard);
            this.pnlPaymentType.Controls.Add(this.chkCash);
            this.pnlPaymentType.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlPaymentType.Location = new System.Drawing.Point(477, 12);
            this.pnlPaymentType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPaymentType.Name = "pnlPaymentType";
            this.pnlPaymentType.Size = new System.Drawing.Size(635, 358);
            this.pnlPaymentType.TabIndex = 1;
            // 
            // pnlCreditCard
            // 
            this.pnlCreditCard.Controls.Add(this.cmbYear);
            this.pnlCreditCard.Controls.Add(this.cmbMonth);
            this.pnlCreditCard.Controls.Add(this.lblCardInfo);
            this.pnlCreditCard.Controls.Add(this.mtxtboxCVV);
            this.pnlCreditCard.Controls.Add(this.mtxtboxCardNumber);
            this.pnlCreditCard.Controls.Add(this.txtboxNameOnCard);
            this.pnlCreditCard.Controls.Add(this.lblExprity);
            this.pnlCreditCard.Controls.Add(this.lblCVV);
            this.pnlCreditCard.Controls.Add(this.lblNameOnCard);
            this.pnlCreditCard.Controls.Add(this.lblCardNumber);
            this.pnlCreditCard.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlCreditCard.Location = new System.Drawing.Point(221, 30);
            this.pnlCreditCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCreditCard.Name = "pnlCreditCard";
            this.pnlCreditCard.Size = new System.Drawing.Size(413, 327);
            this.pnlCreditCard.TabIndex = 4;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbYear.Location = new System.Drawing.Point(293, 225);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(88, 32);
            this.cmbYear.TabIndex = 13;
            this.cmbYear.Text = "Year";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMonth.Location = new System.Drawing.Point(183, 224);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(89, 32);
            this.cmbMonth.TabIndex = 12;
            this.cmbMonth.Text = "Month";
            // 
            // lblCardInfo
            // 
            this.lblCardInfo.AutoSize = true;
            this.lblCardInfo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCardInfo.Location = new System.Drawing.Point(60, 33);
            this.lblCardInfo.Name = "lblCardInfo";
            this.lblCardInfo.Size = new System.Drawing.Size(302, 24);
            this.lblCardInfo.TabIndex = 11;
            this.lblCardInfo.Text = "Please Enter The Card Information";
            // 
            // mtxtboxCVV
            // 
            this.mtxtboxCVV.Location = new System.Drawing.Point(183, 182);
            this.mtxtboxCVV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtboxCVV.Mask = "  000";
            this.mtxtboxCVV.Name = "mtxtboxCVV";
            this.mtxtboxCVV.Size = new System.Drawing.Size(53, 32);
            this.mtxtboxCVV.TabIndex = 7;
            // 
            // mtxtboxCardNumber
            // 
            this.mtxtboxCardNumber.Location = new System.Drawing.Point(185, 140);
            this.mtxtboxCardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtboxCardNumber.Mask = "0000-0000-0000-0000";
            this.mtxtboxCardNumber.Name = "mtxtboxCardNumber";
            this.mtxtboxCardNumber.Size = new System.Drawing.Size(196, 32);
            this.mtxtboxCardNumber.TabIndex = 6;
            // 
            // txtboxNameOnCard
            // 
            this.txtboxNameOnCard.Location = new System.Drawing.Point(185, 98);
            this.txtboxNameOnCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxNameOnCard.Name = "txtboxNameOnCard";
            this.txtboxNameOnCard.Size = new System.Drawing.Size(196, 32);
            this.txtboxNameOnCard.TabIndex = 5;
            // 
            // lblExprity
            // 
            this.lblExprity.AutoSize = true;
            this.lblExprity.Location = new System.Drawing.Point(41, 228);
            this.lblExprity.Name = "lblExprity";
            this.lblExprity.Size = new System.Drawing.Size(119, 24);
            this.lblExprity.TabIndex = 3;
            this.lblExprity.Text = "Exprity Date:";
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Location = new System.Drawing.Point(43, 186);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(50, 24);
            this.lblCVV.TabIndex = 2;
            this.lblCVV.Text = "CVV:";
            // 
            // lblNameOnCard
            // 
            this.lblNameOnCard.AutoSize = true;
            this.lblNameOnCard.Location = new System.Drawing.Point(41, 102);
            this.lblNameOnCard.Name = "lblNameOnCard";
            this.lblNameOnCard.Size = new System.Drawing.Size(138, 24);
            this.lblNameOnCard.TabIndex = 1;
            this.lblNameOnCard.Text = "Name On Card:";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(43, 144);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(128, 24);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number:";
            // 
            // pnlTransfer
            // 
            this.pnlTransfer.Controls.Add(this.lbDrawee);
            this.pnlTransfer.Controls.Add(this.picGaranti);
            this.pnlTransfer.Controls.Add(this.picZiraat);
            this.pnlTransfer.Controls.Add(this.picFinans);
            this.pnlTransfer.Controls.Add(this.picYapı);
            this.pnlTransfer.Controls.Add(this.lblTR);
            this.pnlTransfer.Controls.Add(this.mtxtboxIBAN);
            this.pnlTransfer.Controls.Add(this.chkboxGaranti);
            this.pnlTransfer.Controls.Add(this.chkboxZiraat);
            this.pnlTransfer.Controls.Add(this.chkboxFinans);
            this.pnlTransfer.Controls.Add(this.chkboxYapıKredi);
            this.pnlTransfer.Location = new System.Drawing.Point(221, 30);
            this.pnlTransfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTransfer.Name = "pnlTransfer";
            this.pnlTransfer.Size = new System.Drawing.Size(413, 327);
            this.pnlTransfer.TabIndex = 3;
            // 
            // lbDrawee
            // 
            this.lbDrawee.AutoSize = true;
            this.lbDrawee.Location = new System.Drawing.Point(43, 266);
            this.lbDrawee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDrawee.Name = "lbDrawee";
            this.lbDrawee.Size = new System.Drawing.Size(229, 24);
            this.lbDrawee.TabIndex = 10;
            this.lbDrawee.Text = "Drawee: Yasemin Gerboğa";
            this.lbDrawee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picGaranti
            // 
            this.picGaranti.Location = new System.Drawing.Point(21, 194);
            this.picGaranti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picGaranti.Name = "picGaranti";
            this.picGaranti.Size = new System.Drawing.Size(51, 50);
            this.picGaranti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGaranti.TabIndex = 9;
            this.picGaranti.TabStop = false;
            // 
            // picZiraat
            // 
            this.picZiraat.Location = new System.Drawing.Point(21, 135);
            this.picZiraat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picZiraat.Name = "picZiraat";
            this.picZiraat.Size = new System.Drawing.Size(51, 50);
            this.picZiraat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picZiraat.TabIndex = 8;
            this.picZiraat.TabStop = false;
            // 
            // picFinans
            // 
            this.picFinans.Location = new System.Drawing.Point(21, 78);
            this.picFinans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFinans.Name = "picFinans";
            this.picFinans.Size = new System.Drawing.Size(51, 50);
            this.picFinans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFinans.TabIndex = 7;
            this.picFinans.TabStop = false;
            // 
            // picYapı
            // 
            this.picYapı.Location = new System.Drawing.Point(21, 18);
            this.picYapı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picYapı.Name = "picYapı";
            this.picYapı.Size = new System.Drawing.Size(51, 50);
            this.picYapı.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYapı.TabIndex = 6;
            this.picYapı.TabStop = false;
            // 
            // lblTR
            // 
            this.lblTR.AutoSize = true;
            this.lblTR.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTR.Location = new System.Drawing.Point(43, 302);
            this.lblTR.Name = "lblTR";
            this.lblTR.Size = new System.Drawing.Size(44, 24);
            this.lblTR.TabIndex = 5;
            this.lblTR.Text = "TR -";
            // 
            // mtxtboxIBAN
            // 
            this.mtxtboxIBAN.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtboxIBAN.Location = new System.Drawing.Point(95, 292);
            this.mtxtboxIBAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtboxIBAN.Mask = "00-00000-0-0000000000000000";
            this.mtxtboxIBAN.Name = "mtxtboxIBAN";
            this.mtxtboxIBAN.Size = new System.Drawing.Size(288, 32);
            this.mtxtboxIBAN.TabIndex = 4;
            // 
            // chkboxGaranti
            // 
            this.chkboxGaranti.AutoSize = true;
            this.chkboxGaranti.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkboxGaranti.Location = new System.Drawing.Point(107, 207);
            this.chkboxGaranti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkboxGaranti.Name = "chkboxGaranti";
            this.chkboxGaranti.Size = new System.Drawing.Size(165, 28);
            this.chkboxGaranti.TabIndex = 3;
            this.chkboxGaranti.Text = "Garanti Bankası";
            this.chkboxGaranti.UseVisualStyleBackColor = true;
            this.chkboxGaranti.CheckedChanged += new System.EventHandler(this.chkboxGaranti_CheckedChanged);
            // 
            // chkboxZiraat
            // 
            this.chkboxZiraat.AutoSize = true;
            this.chkboxZiraat.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkboxZiraat.Location = new System.Drawing.Point(107, 149);
            this.chkboxZiraat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkboxZiraat.Name = "chkboxZiraat";
            this.chkboxZiraat.Size = new System.Drawing.Size(153, 28);
            this.chkboxZiraat.TabIndex = 2;
            this.chkboxZiraat.Text = "Ziraat Bankası";
            this.chkboxZiraat.UseVisualStyleBackColor = true;
            this.chkboxZiraat.CheckedChanged += new System.EventHandler(this.chkboxZiraat_CheckedChanged);
            // 
            // chkboxFinans
            // 
            this.chkboxFinans.AutoSize = true;
            this.chkboxFinans.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkboxFinans.Location = new System.Drawing.Point(107, 91);
            this.chkboxFinans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkboxFinans.Name = "chkboxFinans";
            this.chkboxFinans.Size = new System.Drawing.Size(129, 28);
            this.chkboxFinans.TabIndex = 1;
            this.chkboxFinans.Text = "Finansbank";
            this.chkboxFinans.UseVisualStyleBackColor = true;
            this.chkboxFinans.CheckedChanged += new System.EventHandler(this.chkboxFinans_CheckedChanged);
            // 
            // chkboxYapıKredi
            // 
            this.chkboxYapıKredi.AutoSize = true;
            this.chkboxYapıKredi.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkboxYapıKredi.Location = new System.Drawing.Point(107, 33);
            this.chkboxYapıKredi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkboxYapıKredi.Name = "chkboxYapıKredi";
            this.chkboxYapıKredi.Size = new System.Drawing.Size(188, 28);
            this.chkboxYapıKredi.TabIndex = 0;
            this.chkboxYapıKredi.Text = "Yapı Kredi Bankası";
            this.chkboxYapıKredi.UseVisualStyleBackColor = true;
            this.chkboxYapıKredi.CheckedChanged += new System.EventHandler(this.chkboxYapıKredi_CheckedChanged);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(172)))), ((int)(((byte)(197)))));
            this.btnPlaceOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnPlaceOrder.Location = new System.Drawing.Point(28, 240);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(149, 34);
            this.btnPlaceOrder.TabIndex = 5;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // chkboxTransfer
            // 
            this.chkboxTransfer.AutoSize = true;
            this.chkboxTransfer.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkboxTransfer.Location = new System.Drawing.Point(23, 172);
            this.chkboxTransfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkboxTransfer.Name = "chkboxTransfer";
            this.chkboxTransfer.Size = new System.Drawing.Size(140, 28);
            this.chkboxTransfer.TabIndex = 4;
            this.chkboxTransfer.Text = "Transfer/EFT";
            this.chkboxTransfer.UseVisualStyleBackColor = true;
            this.chkboxTransfer.CheckedChanged += new System.EventHandler(this.chkboxTransfer_CheckedChanged);
            // 
            // chkCreditCard
            // 
            this.chkCreditCard.AutoSize = true;
            this.chkCreditCard.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkCreditCard.Location = new System.Drawing.Point(23, 70);
            this.chkCreditCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCreditCard.Name = "chkCreditCard";
            this.chkCreditCard.Size = new System.Drawing.Size(128, 28);
            this.chkCreditCard.TabIndex = 2;
            this.chkCreditCard.Text = "Credit Card";
            this.chkCreditCard.UseVisualStyleBackColor = true;
            this.chkCreditCard.CheckedChanged += new System.EventHandler(this.chkCreditCard_CheckedChanged);
            // 
            // chkCash
            // 
            this.chkCash.AutoSize = true;
            this.chkCash.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkCash.Location = new System.Drawing.Point(23, 121);
            this.chkCash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCash.Name = "chkCash";
            this.chkCash.Size = new System.Drawing.Size(73, 28);
            this.chkCash.TabIndex = 1;
            this.chkCash.Text = "Cash";
            this.chkCash.UseVisualStyleBackColor = true;
            this.chkCash.CheckedChanged += new System.EventHandler(this.chkCash_CheckedChanged);
            // 
            // pnlVerification
            // 
            this.pnlVerification.Controls.Add(this.btnVerify);
            this.pnlVerification.Controls.Add(this.mtxtboxVerificationCode);
            this.pnlVerification.Controls.Add(this.lblVerificationInfo);
            this.pnlVerification.Controls.Add(this.lblVerification);
            this.pnlVerification.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlVerification.Location = new System.Drawing.Point(20, 388);
            this.pnlVerification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlVerification.Name = "pnlVerification";
            this.pnlVerification.Size = new System.Drawing.Size(452, 208);
            this.pnlVerification.TabIndex = 2;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(172)))), ((int)(((byte)(197)))));
            this.btnVerify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnVerify.Location = new System.Drawing.Point(137, 161);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(149, 34);
            this.btnVerify.TabIndex = 3;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // mtxtboxVerificationCode
            // 
            this.mtxtboxVerificationCode.Location = new System.Drawing.Point(137, 90);
            this.mtxtboxVerificationCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtboxVerificationCode.Mask = "            0000";
            this.mtxtboxVerificationCode.Name = "mtxtboxVerificationCode";
            this.mtxtboxVerificationCode.Size = new System.Drawing.Size(151, 32);
            this.mtxtboxVerificationCode.TabIndex = 2;
            // 
            // lblVerificationInfo
            // 
            this.lblVerificationInfo.AutoSize = true;
            this.lblVerificationInfo.Location = new System.Drawing.Point(9, 46);
            this.lblVerificationInfo.Name = "lblVerificationInfo";
            this.lblVerificationInfo.Size = new System.Drawing.Size(406, 24);
            this.lblVerificationInfo.TabIndex = 1;
            this.lblVerificationInfo.Text = "Enter the code that was  sent to the your e-mail";
            // 
            // lblVerification
            // 
            this.lblVerification.AutoSize = true;
            this.lblVerification.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVerification.Location = new System.Drawing.Point(133, 10);
            this.lblVerification.Name = "lblVerification";
            this.lblVerification.Size = new System.Drawing.Size(156, 24);
            this.lblVerification.TabIndex = 0;
            this.lblVerification.Text = "Verification Code";
            // 
            // pnlCargo
            // 
            this.pnlCargo.Controls.Add(this.chkboxArasCargo);
            this.pnlCargo.Controls.Add(this.chkboxMNGCargo);
            this.pnlCargo.Location = new System.Drawing.Point(20, 270);
            this.pnlCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCargo.Name = "pnlCargo";
            this.pnlCargo.Size = new System.Drawing.Size(452, 63);
            this.pnlCargo.TabIndex = 3;
            // 
            // chkboxArasCargo
            // 
            this.chkboxArasCargo.AutoSize = true;
            this.chkboxArasCargo.Location = new System.Drawing.Point(251, 18);
            this.chkboxArasCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkboxArasCargo.Name = "chkboxArasCargo";
            this.chkboxArasCargo.Size = new System.Drawing.Size(101, 21);
            this.chkboxArasCargo.TabIndex = 1;
            this.chkboxArasCargo.Text = "Aras Cargo";
            this.chkboxArasCargo.UseVisualStyleBackColor = true;
            this.chkboxArasCargo.CheckedChanged += new System.EventHandler(this.chkboxArasCargo_CheckedChanged);
            // 
            // chkboxMNGCargo
            // 
            this.chkboxMNGCargo.AutoSize = true;
            this.chkboxMNGCargo.Location = new System.Drawing.Point(37, 18);
            this.chkboxMNGCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkboxMNGCargo.Name = "chkboxMNGCargo";
            this.chkboxMNGCargo.Size = new System.Drawing.Size(104, 21);
            this.chkboxMNGCargo.TabIndex = 0;
            this.chkboxMNGCargo.Text = "MNG Cargo";
            this.chkboxMNGCargo.UseVisualStyleBackColor = true;
            this.chkboxMNGCargo.CheckedChanged += new System.EventHandler(this.chkboxMNGCargo_CheckedChanged);
            // 
            // pnlInvoiceSummary
            // 
            this.pnlInvoiceSummary.Controls.Add(this.btnContinueShopping);
            this.pnlInvoiceSummary.Controls.Add(this.lblTax);
            this.pnlInvoiceSummary.Controls.Add(this.lblTotal);
            this.pnlInvoiceSummary.Controls.Add(this.lblCargoPrice);
            this.pnlInvoiceSummary.Controls.Add(this.lblPrice);
            this.pnlInvoiceSummary.Controls.Add(this.lblInvioceSummary);
            this.pnlInvoiceSummary.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlInvoiceSummary.Location = new System.Drawing.Point(477, 377);
            this.pnlInvoiceSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlInvoiceSummary.Name = "pnlInvoiceSummary";
            this.pnlInvoiceSummary.Size = new System.Drawing.Size(635, 219);
            this.pnlInvoiceSummary.TabIndex = 4;
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
            this.btnContinueShopping.Location = new System.Drawing.Point(441, 165);
            this.btnContinueShopping.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinueShopping.Name = "btnContinueShopping";
            this.btnContinueShopping.Size = new System.Drawing.Size(182, 34);
            this.btnContinueShopping.TabIndex = 22;
            this.btnContinueShopping.Text = "Continue Shopping";
            this.btnContinueShopping.UseVisualStyleBackColor = false;
            this.btnContinueShopping.Click += new System.EventHandler(this.btnContinueShopping_Click);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(437, 63);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(44, 24);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(19, 169);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(143, 24);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total (with Tax):";
            // 
            // lblCargoPrice
            // 
            this.lblCargoPrice.AutoSize = true;
            this.lblCargoPrice.Location = new System.Drawing.Point(224, 63);
            this.lblCargoPrice.Name = "lblCargoPrice";
            this.lblCargoPrice.Size = new System.Drawing.Size(112, 24);
            this.lblCargoPrice.TabIndex = 2;
            this.lblCargoPrice.Text = "Cargo Price:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(19, 63);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(104, 24);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Total Price:";
            // 
            // lblInvioceSummary
            // 
            this.lblInvioceSummary.AutoSize = true;
            this.lblInvioceSummary.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInvioceSummary.Location = new System.Drawing.Point(19, 11);
            this.lblInvioceSummary.Name = "lblInvioceSummary";
            this.lblInvioceSummary.Size = new System.Drawing.Size(160, 24);
            this.lblInvioceSummary.TabIndex = 0;
            this.lblInvioceSummary.Text = "Invoice Summary";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1124, 622);
            this.Controls.Add(this.pnlInvoiceSummary);
            this.Controls.Add(this.pnlCargo);
            this.Controls.Add(this.pnlVerification);
            this.Controls.Add(this.pnlPaymentType);
            this.Controls.Add(this.pnlAddress);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Invoice_FormClosing);
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            this.pnlPaymentType.ResumeLayout(false);
            this.pnlPaymentType.PerformLayout();
            this.pnlCreditCard.ResumeLayout(false);
            this.pnlCreditCard.PerformLayout();
            this.pnlTransfer.ResumeLayout(false);
            this.pnlTransfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGaranti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZiraat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYapı)).EndInit();
            this.pnlVerification.ResumeLayout(false);
            this.pnlVerification.PerformLayout();
            this.pnlCargo.ResumeLayout(false);
            this.pnlCargo.PerformLayout();
            this.pnlInvoiceSummary.ResumeLayout(false);
            this.pnlInvoiceSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.CheckBox chkSecondAddress;
        private System.Windows.Forms.CheckBox chkFirstAddress;
        private System.Windows.Forms.Panel pnlPaymentType;
        private System.Windows.Forms.Panel pnlTransfer;
        private System.Windows.Forms.CheckBox chkCreditCard;
        private System.Windows.Forms.CheckBox chkCash;
        private System.Windows.Forms.Panel pnlCreditCard;
        private System.Windows.Forms.MaskedTextBox mtxtboxCardNumber;
        private System.Windows.Forms.TextBox txtboxNameOnCard;
        private System.Windows.Forms.Label lblExprity;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.Label lblNameOnCard;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.MaskedTextBox mtxtboxCVV;
        private System.Windows.Forms.CheckBox chkboxGaranti;
        private System.Windows.Forms.CheckBox chkboxZiraat;
        private System.Windows.Forms.CheckBox chkboxFinans;
        private System.Windows.Forms.CheckBox chkboxYapıKredi;
        private System.Windows.Forms.Label lblTR;
        private System.Windows.Forms.MaskedTextBox mtxtboxIBAN;
        private System.Windows.Forms.PictureBox picGaranti;
        private System.Windows.Forms.PictureBox picZiraat;
        private System.Windows.Forms.PictureBox picFinans;
        private System.Windows.Forms.PictureBox picYapı;
        private System.Windows.Forms.Label lblCardInfo;
        private System.Windows.Forms.Panel pnlVerification;
        private System.Windows.Forms.MaskedTextBox mtxtboxVerificationCode;
        private System.Windows.Forms.Label lblVerificationInfo;
        private System.Windows.Forms.Label lblVerification;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Panel pnlCargo;
        private System.Windows.Forms.CheckBox chkboxArasCargo;
        private System.Windows.Forms.CheckBox chkboxMNGCargo;
        private System.Windows.Forms.Panel pnlInvoiceSummary;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblInvioceSummary;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCargoPrice;
        private System.Windows.Forms.CheckBox chkboxTransfer;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label lbDrawee;
        private System.Windows.Forms.Button btnContinueShopping;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
    }
}