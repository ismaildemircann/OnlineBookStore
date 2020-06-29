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
    public partial class OceanBookStore : Form
    {
        static SignUp signUp = new SignUp();
        public static LoginScreen loginScreen = new LoginScreen();
        public static List<Customer> customerList = new List<Customer>();
        /// <summary>
        /// This function used to load customer list and shopping cards.
        /// </summary>
        public OceanBookStore()
        {
            InitializeComponent();
            UtilLoad.Load(customerList);
            UtilLoad.Load(StoreMainScreen.shoppingCards);
        }
        /// <summary>
        /// This function used to show login screen.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void OceanBookStore_Load(object sender, EventArgs e)
        {
            menuStripMain.ForeColor = Color.FromArgb(249, 247, 247);
            signUp.MdiParent = this;
            signUp.Parent = panelMain;
            signUp.Dock = DockStyle.Fill;
            loginScreen.MdiParent = this;
            loginScreen.Parent = panelMain;
            loginScreen.Dock = DockStyle.Fill;
            loginScreen.Show();
        }
        /// <summary>
        /// This function is used to show the login screen and hide the sign up.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginScreen.Show();
            signUp.Hide();
        }
        /// <summary>
        /// This function is used to hide the login screen and show the sign up.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            signUp.Show();
            loginScreen.Hide();
        }
        /// <summary>
        /// This function is used to exit application.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void OceanBookStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
