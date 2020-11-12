using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Book_Store.logger;

namespace Online_Book_Store.shoppingCard
{
    /**   
    * @brief    This file includes order operations.
    */
    public partial class Invoice : Form
    {
        /// <summary>
        /// This function is Constructor.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        public Invoice()
        {
            InitializeComponent();
        }
        private int mngCargo = 8;
        private int arasCargo = 16;
        private int cashAmount = 15;
        private double price = 0;
        public static double totalPrice = 0;
        public static int cargoAmount = 0;
        int verificationCode;
        private double tax;
        public ShoppingCard temp;
        public static PaymentType pType = PaymentType.creditcard;
        /// <summary>
        /// This function used to changed enabled and visible.
        /// This function used to calculate and write price ,tax and cargo amount.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void Invoice_Load(object sender, EventArgs e)
        {
            chkFirstAddress.Checked = true;
            txtAddress.Text = LoginedCustomer.getInstance().User.Address;
            txtAddress.Enabled = false;
            chkCreditCard.Checked = true;
            pnlCreditCard.Visible = true;
            pnlTransfer.Visible = false;
            pnlVerification.Visible = false;
            chkboxMNGCargo.Checked = true;
            for (int i = 0; i < StoreMainScreen.shoppingCards.Count; i++)
            {
                if (StoreMainScreen.shoppingCards[i].CustomerID == LoginedCustomer.getInstance().User.CustomerId)
                {
                    temp = StoreMainScreen.shoppingCards[i];
                    break;
                }
            }
            price = temp.PaymentAmount;
            lblPrice.Text += price.ToString() + "₺";
            tax = price * (0.18);
            lblTax.Text += tax.ToString() + "₺";
            if (price >= 75)
            {
                cargoAmount = 0;
            }
            else
            {
                cargoAmount = mngCargo;
            }
            lblCargoPrice.Text = "Cargo Price: " + cargoAmount.ToString() + "₺";
            totalPrice = price + tax + cargoAmount;
            lblTotal.Text = "Total (with Tax): " + totalPrice.ToString() + "₺";
        }
        /// <summary>
        /// This function used to check changed for address.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void chkSecondAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSecondAddress.Checked)
            {
                txtAddress.Text = "";
                txtAddress.Enabled = true;
                chkFirstAddress.Checked = false;
            }
        }
        /// <summary>
        /// This function used to check changed for address therefore textbox not enabled .
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void chkFirstAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFirstAddress.Checked)
            {
                txtAddress.Text = LoginedCustomer.getInstance().User.Address;
                txtAddress.Enabled = false;
                chkSecondAddress.Checked = false;
            }
        }
        /// <summary>
        /// This function used to check change for payment type cash.
        /// This function used to write total price (with tax) and cargo price.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void chkCash_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCash.Checked)
            {
                pnlCreditCard.Visible = false;
                pnlTransfer.Visible = false;
                chkCreditCard.Checked = false;
                chkboxTransfer.Checked = false;
                if (chkboxMNGCargo.Checked)
                    cargoAmount = mngCargo;
                else
                    cargoAmount = arasCargo;
                if (price >= 75)
                {
                    cargoAmount = 0;
                }
                lblCargoPrice.Text = "Cargo Price: " + (cargoAmount + cashAmount).ToString() + "₺";
                totalPrice = price + tax + cargoAmount + cashAmount;
                lblTotal.Text = "Total (with Tax): " + totalPrice.ToString() + "₺";
                pType = PaymentType.cash;
            }
        }
        /// <summary>
        /// This function used to check change for payment type transfer.
        /// This function used to write total price (with tax) and cargo price.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void chkboxTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxTransfer.Checked)
            {
                pnlTransfer.Visible = true;
                pnlCreditCard.Visible = false;
                chkCreditCard.Checked = false;
                chkCash.Checked = false;
                mtxtboxIBAN.Enabled = false;
                mtxtboxIBAN.Text = "";
                chkboxYapıKredi.Checked = true;
                chkboxZiraat.Checked = false;
                chkboxGaranti.Checked = false;
                chkboxFinans.Checked = false;
                lbDrawee.Text = "Drawee: Yasemin Gerboğa";
                mtxtboxIBAN.Text = "750006701000000058545814";
                if (chkboxMNGCargo.Checked)
                    cargoAmount = mngCargo;
                else
                    cargoAmount = arasCargo;
                if (price >= 75)
                {
                    cargoAmount = 0;
                }
                lblCargoPrice.Text = "Cargo Price: " + cargoAmount.ToString() + "₺";
                totalPrice = price + tax + cargoAmount;
                lblTotal.Text = "Total (with Tax): " + totalPrice.ToString() + "₺";
                pType = PaymentType.transfer;
            }
        }
        /// <summary>
        /// This function used to check change for payment type credit card.
        /// This function used to write total price (with tax) and cargo price.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void chkCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCreditCard.Checked)
            {
                txtboxNameOnCard.Text = "";
                mtxtboxCardNumber.Text = "";
                mtxtboxCVV.Text = "";
                mtxtboxIBAN.Text = "";
                pnlTransfer.Visible = false;
                pnlCreditCard.Visible = true;
                chkCash.Checked = false;
                chkboxTransfer.Checked = false;
                if (chkboxMNGCargo.Checked)
                    cargoAmount = mngCargo;
                else
                    cargoAmount = arasCargo;
                if (price >= 75)
                {
                    cargoAmount = 0;
                }
                lblCargoPrice.Text = "Cargo Price: " + cargoAmount.ToString() + "₺";
                totalPrice = price + tax + cargoAmount;
                lblTotal.Text = "Total (with Tax): " + totalPrice.ToString() + "₺";
                pType = PaymentType.creditcard;
            }
        }
        /// <summary>
        /// This function used to check change for MNG cargo amount .
        /// This function used to write total price (with tax) and cargo price.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void chkboxMNGCargo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxMNGCargo.Checked)
            {
                chkboxArasCargo.Checked = false;
                cargoAmount = mngCargo;
                if (price >= 75)
                {
                    cargoAmount = 0;
                }
                if (chkCash.Checked)
                {
                    cargoAmount += cashAmount;
                }
                lblCargoPrice.Text = "Cargo Price: " + cargoAmount.ToString() + "₺";
                totalPrice = price + tax + cargoAmount;
                lblTotal.Text = "Total (with Tax): " + totalPrice.ToString() + "₺";
            }
        }
        /// <summary>
        /// This function used to check change for Aras cargo amount .
        /// This function used to write total price (with tax) and cargo price.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void chkboxArasCargo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxArasCargo.Checked)
            {
                chkboxMNGCargo.Checked = false;
                cargoAmount = arasCargo;
                if (price >= 75)
                {
                    cargoAmount = 0;
                }
                if (chkCash.Checked)
                {
                    cargoAmount += cashAmount;
                }
                lblCargoPrice.Text = "Cargo Price: " + cargoAmount.ToString() + "₺";
                totalPrice = price + tax + cargoAmount;
                lblTotal.Text = "Total (with Tax): " + totalPrice.ToString() + "₺";
            }
        }
        /// <summary>
        /// This function includes Place order button click operation and send the email for verication code.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnPlaceOrder.Text, DateTime.Now);
            if (chkCreditCard.Checked)
            {
                if (!(mtxtboxCardNumber.MaskFull || mtxtboxCVV.MaskFull || cmbMonth.Text == "" || cmbYear.Text == ""))
                {
                    MessageBox.Show("Please enter empty fields!");
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtboxNameOnCard.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("Please enter valid name!");
                    return;
                }
            }
            //if address email telefon no control et
            DialogResult dr = MessageBox.Show("Your order will be placed. Do you want to proceed?", "Info",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                Random random = new Random();
                verificationCode = random.Next(1000, 9999);
                string mailMessage = "#" + (StoreMainScreen.orderList.Count + 1).ToString() + " order will be placed." + Environment.NewLine +
                    "Please enter code shown below" + Environment.NewLine + verificationCode.ToString();
                if (SendMail(mailMessage))
                    pnlVerification.Visible = true;
            }
        }
        /// <summary>
        /// This function used to hold email information .
        /// </summary>
        /// <param name="message">The message string hold the verication code.</param>
        /// <returns>If the email is sent successfully, the return value is correct. </returns>
        private bool SendMail(string message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("oceanbookstore2020@gmail.com");
                mail.To.Add(LoginedCustomer.getInstance().User.Email);
                mail.Subject = "#" + (StoreMainScreen.orderList.Count + 1).ToString() + " Order Verification Code";
                mail.Body = message;
                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("oceanbookstore2020@gmail.com", "fgjuzkjfdwihovpb");
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);
                return true;
            }
            catch
            {
                MessageBox.Show("Something went wrong!");
                return false;
            }
        }
        /// <summary>
        /// This function used to compare entered code and verification code.
        /// </summary>
        /// <param name="verificationCode">The verificationCode hold the verication code. </param>
        /// <returns>If the compare is correct, the return value is correct.</returns>
        private bool IsVerify(int verificationCode)
        {
            pnlVerification.Visible = true;
            int enteredCode = int.Parse(mtxtboxVerificationCode.Text);
            if (enteredCode == verificationCode)
            {
                StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].PlaceOrder();
                UtilUpdate.Delete(StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex]);
                MessageBox.Show("Your order has been taken.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Please enter code again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// This function used to check change for Finans bank.
        /// This function used to show iban and drawee.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void chkboxFinans_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxFinans.Checked)
            {
                mtxtboxIBAN.Text = "";
                chkboxZiraat.Checked = false;
                chkboxGaranti.Checked = false;
                chkboxYapıKredi.Checked = false;
                lbDrawee.Text = "Drawee: Sina Kuşoğlu";
                mtxtboxIBAN.Text = "630011100000000069698627";
            }
        }
        /// <summary>
        /// This function used to check change for Ziraat bank.
        /// This function used to show iban and drawee.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void chkboxZiraat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxZiraat.Checked)
            {
                mtxtboxIBAN.Text = "";
                chkboxGaranti.Checked = false;
                chkboxFinans.Checked = false;
                chkboxYapıKredi.Checked = false;
                lbDrawee.Text = "Drawee: Gökhan Samet Albayrak";
                mtxtboxIBAN.Text = "040001000223616750315001";
            }
        }
        /// <summary>
        /// This function used to check change for Garanti bank.
        /// This function used to show iban.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void chkboxGaranti_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxGaranti.Checked)
            {
                mtxtboxIBAN.Text = "";
                chkboxFinans.Checked = false;
                chkboxYapıKredi.Checked = false;
                chkboxZiraat.Checked = false;
                mtxtboxIBAN.Text = "111111111111111111111114";
            }
        }
        /// <summary>
        /// This function used to check change for YapiKredi bank.
        /// This function used to show iban and drawee.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void chkboxYapıKredi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxYapıKredi.Checked)
            {
                mtxtboxIBAN.Text = "";
                chkboxFinans.Checked = false;
                chkboxGaranti.Checked = false;
                chkboxZiraat.Checked = false;
                lbDrawee.Text = "Drawee: Yasemin Gerboğa";
                mtxtboxIBAN.Text = "750006701000000058545814";
            }
        }
        /// <summary>
        /// This function includes Verify button click operation and the IsVerify function is called.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnVerify_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnVerify.Text, DateTime.Now);
            if (mtxtboxVerificationCode.Text.Length < 16)
            {
                MessageBox.Show("Please enter verification code correctly!");
                return;
            }
            IsVerify(verificationCode);
        }
        /// <summary>
        /// This function includes continue shopping button click operation and show the store main screen.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnContinueShopping_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnContinueShopping.Text, DateTime.Now);
            StoreMainScreen.storeMainScreen.Show();
            this.Hide();
        }
        /// <summary>
        /// This function used to show the store main screen.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void Invoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            StoreMainScreen.storeMainScreen.Show();
        }
    }
}
