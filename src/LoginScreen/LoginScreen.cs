using Online_Book_Store.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Book_Store.logger;
namespace Online_Book_Store
{
    /**   
    * @brief    This file includes login password operations.
    */
    public partial class LoginScreen : Form
    {
        public static int shoppingCardIndex;
        public LoginScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function used to edit location for panels.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            panelLogin.Location = new Point
            {
                X = (panelBase.Width / 2) - (panelLogin.Width / 2),
                Y = (panelBase.Height / 2) - (panelLogin.Height / 2)
            };
            panelChild.Location = new Point
            {
                X = (panelLogin.Width / 2) - (panelChild.Width / 2),
                Y = 23
            };
        }
        /// <summary>
        /// This function used to create tag for password.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void pboxShowHide_Click(object sender, EventArgs e)
        {
            if (pboxShowHide.Tag.ToString() == "show")
            {
                pboxShowHide.Image = Resources.hidepassword;
                pboxShowHide.Refresh();
                pboxShowHide.Tag = "hide";
                pboxShowHide.Visible = true;
                loginPassword.getSetPasswordChar = false;
            }
            else
            {
                pboxShowHide.Image = Resources.showpassword;
                pboxShowHide.Refresh();
                pboxShowHide.Tag = "show";
                pboxShowHide.Visible = true;
                loginPassword.getSetPasswordChar = true;
            }
        }
        /// <summary>
        /// This function login button click operation.
        /// This function is used to login application.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(loginUsername.GetSetText, btnLogin.Text, DateTime.Now);
            if (loginUsername.GetSetText == "" || loginPassword.GetSetText == "")
            {
                MessageBox.Show("Please fill all blanks.");
                return;
            }
            string username = loginUsername.GetSetText;
            string password = loginPassword.GetSetText;
            int i = 0;
            foreach (Customer customer in OceanBookStore.customerList)
            {
                if (customer.IsValid(username, password))
                {
                    shoppingCardIndex = i;
                    LoginedCustomer.getInstance().User = customer;
                    MessageBox.Show("Succesful Login!");
                    this.Parent.Parent.Hide();
                    StoreMainScreen.storeMainScreen.ShowDialog();
                    return;
                }
                i++;
            }
            MessageBox.Show("Username or password is wrong.");
            loginUsername.GetSetText = "";
            loginPassword.GetSetText = "";
        }
        /// <summary>
        /// This function used to edit location for panel login.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void LoginScreen_Resize(object sender, EventArgs e)
        {
            panelLogin.Location = new Point
            {
                X = (panelBase.Width / 2) - (panelLogin.Width / 2),
                Y = (panelBase.Height / 2) - (panelLogin.Height / 2)
            };
        }
        /// <summary>
        /// This function used to change visible for username and password.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void LoginScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                loginUsername.GetSetText = "";
                loginPassword.GetSetText = "";
            }
        }
    }
}
