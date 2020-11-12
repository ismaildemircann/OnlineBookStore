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
using Online_Book_Store.shoppingCard;
using Online_Book_Store.logger;

namespace Online_Book_Store
{
    /**   
     * @brief    This file includes order operations.
     */
    public partial class StoreMainScreen : Form
    {
        public static List<Product> productList = new List<Product>();
        public static List<ShoppingCard> shoppingCards = new List<ShoppingCard>();
        public static List<ShoppingCard> orderList = new List<ShoppingCard>();
        public static StoreMainScreen storeMainScreen = new StoreMainScreen();
        public static ShoppingCardForm ShoppingCardForm = new ShoppingCardForm();
        static BookScreen bookScreen = new BookScreen();
        static MagazineScreen magazineScreen = new MagazineScreen();
        static MusicCdScreen musicScreen = new MusicCdScreen();
        static MyOrders myOrdersScreen = new MyOrders();
        bool isFirst = true;
        /// <summary>
        /// This function is Constructor.
        /// This function is called to load the product list and order list.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        public StoreMainScreen()
        {
            InitializeComponent();
            UtilLoad.Load(productList);
            UtilLoad.LoadOrder(orderList);
        }
        /// <summary>
        /// This function is used to edit the screen size.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void StoreMainScreen_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                panelSidebar.Width = (int)(panelSidebar.Width * 1.7075);
                isFirst = false;
            }
            else if (this.WindowState == FormWindowState.Normal && isFirst == false)
            {
                panelSidebar.Width = (int)(panelSidebar.Width / 1.7075);
            }
        }
        /// <summary>
        /// This function is used to edit the Mdi form.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void StoreMainScreen_Load(object sender, EventArgs e)
        {
            bookScreen.MdiParent = this;
            bookScreen.Parent = panelBase;
            bookScreen.Dock = DockStyle.Fill;
            bookScreen.Show();
            musicScreen.MdiParent = this;
            musicScreen.Parent = panelBase;
            musicScreen.Dock = DockStyle.Fill;
            magazineScreen.MdiParent = this;
            magazineScreen.Parent = panelBase;
            magazineScreen.Dock = DockStyle.Fill;
            myOrdersScreen.MdiParent = this;
            myOrdersScreen.Parent = panelBase;
            myOrdersScreen.Dock = DockStyle.Fill;
            lblWelcome.Text = "Welcome " + LoginedCustomer.getInstance().User.Username + "!";
            if (LoginedCustomer.getInstance().User.CustomerId == "1")
                btnAdmin.Visible = true;
        }
        /// <summary>
        /// This function is used to edit panel side bar design.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void panelSidebar_Resize(object sender, EventArgs e)
        {
            lbDashbord.Location = new Point
            {
                X = (paneldashbord.Width / 2) - (lbDashbord.Width / 2),
                Y = (paneldashbord.Height / 2) - (lbDashbord.Height / 2)
            };
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnBook.TextAlign = ContentAlignment.MiddleCenter;
                btnMagazines.TextAlign = ContentAlignment.MiddleCenter;
                btnCDs.TextAlign = ContentAlignment.MiddleCenter;
                btnCart.TextAlign = ContentAlignment.MiddleCenter;
                btnAdmin.TextAlign = ContentAlignment.MiddleCenter;
                btnLogOut.TextAlign = ContentAlignment.MiddleCenter;
                btnMyOrders.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                btnBook.TextAlign = ContentAlignment.MiddleRight;
                btnMagazines.TextAlign = ContentAlignment.MiddleRight;
                btnCDs.TextAlign = ContentAlignment.MiddleRight;
                btnCart.TextAlign = ContentAlignment.MiddleRight;
                btnAdmin.TextAlign = ContentAlignment.MiddleRight;
                btnLogOut.TextAlign = ContentAlignment.MiddleRight;
                btnMyOrders.TextAlign = ContentAlignment.MiddleRight;
            }
        }
        /// <summary>
        /// This function includes Admin button click operation.
        /// This function used to show new the admin screen .
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnAdmin.Text, DateTime.Now);
            AdminScreen adminScreen = new AdminScreen();
            adminScreen.Show();
        }
        /// <summary>
        /// This function includes Book button click operation.
        /// This function used to show the book screen and hide the magazine and music screen.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnBook_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnBook.Text, DateTime.Now);
            if (bookScreen.Visible == true)
            {
                return;
            }
            bookScreen.Show();
            magazineScreen.Hide();
            musicScreen.Hide();
            myOrdersScreen.Hide();
        }
        /// <summary>
        /// This function includes Magazines button click operation.
        /// This function used to show the magazine screen and hide the book and music screen.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnMagazines_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnMagazines.Text, DateTime.Now);
            if (magazineScreen.Visible == true)
            {
                return;
            }
            bookScreen.Hide();
            magazineScreen.Show();
            musicScreen.Hide();
            myOrdersScreen.Hide();
        }
        /// <summary>
        /// This function includes CDs button click operation.
        /// This function used to show the music screen and hide the book and magazine screen.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnCDs_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnCDs.Text, DateTime.Now);
            if (musicScreen.Visible == true)
            {
                return;
            }
            bookScreen.Hide();
            magazineScreen.Hide();
            musicScreen.Show();
            myOrdersScreen.Hide();
        }
        /// <summary>
        /// This function includes Cart button click operation.
        /// This function used to show the shopping card form screen.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnCart_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnCart.Text, DateTime.Now);
            StoreMainScreen.ShoppingCardForm.Show();
            this.Hide();
        }
        /// <summary>
        /// This function used to exit the application.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void StoreMainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This function includes log out button click operation.
        /// This function used to login the application again.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnLogOut.Text, DateTime.Now);
            OceanBookStore oceanBookStore = new OceanBookStore();
            this.Hide();
            oceanBookStore.Show();
        }
        /// <summary>
        /// This function includes My orders button click operation.
        /// This function used to changed the my orders screen visible and show this screen.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnMyOrders.Text, DateTime.Now);
            if (myOrdersScreen.Visible == true)
            {
                return;
            }
            bookScreen.Hide();
            magazineScreen.Hide();
            musicScreen.Hide();
            myOrdersScreen.Show();
        }
    }
}
