using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Book_Store.logger;

namespace Online_Book_Store
{
    /**   
    * @brief    This file includes signup operations.
    */
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function used to edit location for panel and picture box.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void SignUp_Load(object sender, EventArgs e)
        {
            pBoxLogo.Location = new Point
            {
                X = (panelBase.Width / 2) - (pBoxLogo.Width / 2),
                Y = 12
            };
            panelBase.Location = new Point
            {
                X = (panelBase.Width / 2) - (panelLogin.Width / 2),
                Y = 173,
            };
        }
        /// <summary>
        /// This function used to edit location for panel sign up.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void SignUp_Resize(object sender, EventArgs e)
        {
            panelBase.Location = new Point
            {
                X = (this.Width / 2) - (panelBase.Width / 2),
                Y = (this.Height / 2) - (panelBase.Height / 2)
            };
        }
        /// <summary>
        /// This function signup button click operation.
        /// This function is used to sign up application.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog("Unknown user", btnSignUp.Text, DateTime.Now);
            if (!IsEmptyTextbox())
            {
                MessageBox.Show("You have to fill all fields.");
                return;
            }
            else if (!IsValidEmail(txtMail.Text))
            {
                MessageBox.Show("You can't use this mail adress." + Environment.NewLine + "Ex: ocean@ocean.com");
                return;
            }
            foreach (Customer item in OceanBookStore.customerList)
            {
                if (item.Username == txtUsername.Text)
                {
                    MessageBox.Show("This username is already taken.");
                    return;
                }
            }
            string hashedPassword = UtilConvert.ComputeSha256Hash(txtPassword.Text);
            Customer customer = new Customer(txtName.Text, txtAddress.Text, txtMail.Text, txtUsername.Text,
                hashedPassword, UtilSave.registrationNo.ToString());
            Customer.SaveCustomer(customer);
            OceanBookStore.customerList.Add(customer);
            ShoppingCard shoppingCard = new ShoppingCard();
            shoppingCard.CustomerID = customer.CustomerId;
            UtilSave.Save(shoppingCard);
            StoreMainScreen.shoppingCards.Add(shoppingCard);
            MessageBox.Show("Your account was created!");
            RefreshForm();
            this.Hide();
            OceanBookStore.loginScreen.Show();
        }
        /// <summary>
        /// This function is used to control for email.
        /// </summary>
        /// <param name="email">The email string hold the email.</param>
        /// <returns>If the email is corret, return isEmail</returns>
        private bool IsValidEmail(string email)
        {
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'+/=?^`{|}~-]+(?:.[a-z0-9!#$%&'+/=?^`{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            return isEmail;
        }
        /// <summary>
        /// This function is used to control for textbox.
        /// </summary>
        /// <returns>If not empty textbox,return true</returns>
        private bool IsEmptyTextbox()
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtMail.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// This function used to clear text box.
        /// </summary>
        private void RefreshForm()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtMail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
