using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Book_Store.adminScreen;
using Online_Book_Store.logger;

namespace Online_Book_Store
{
    /**
    * @brief   This file includes to admin screen information.
    */
    public partial class AdminScreen : Form
    {
        AdminBookScreen adminBookScreen = new AdminBookScreen();
        AdminMagazineScreen adminMagazineScreen = new AdminMagazineScreen();
        AdminMusicCDScreen adminMusicCDScreen = new AdminMusicCDScreen();
        AdminOrderScreen adminOrderScreen = new AdminOrderScreen();
        public AdminScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  This function used to edit Mdi form information.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void AdminScreen_Load(object sender, EventArgs e)
        {
            if (adminBookScreen == null)
                adminBookScreen = new AdminBookScreen();
            adminBookScreen.MdiParent = this;
            adminBookScreen.Parent = panelBase;
            adminBookScreen.Dock = DockStyle.Fill;
            adminBookScreen.Show();
            if (adminMagazineScreen == null)
                adminMagazineScreen = new AdminMagazineScreen();
            adminMagazineScreen.MdiParent = this;
            adminMagazineScreen.Parent = panelBase;
            adminMagazineScreen.Dock = DockStyle.Fill;
            if (adminMusicCDScreen == null)
                adminMusicCDScreen = new AdminMusicCDScreen();
            adminMusicCDScreen.MdiParent = this;
            adminMusicCDScreen.Parent = panelBase;
            adminMusicCDScreen.Dock = DockStyle.Fill;
            if (adminOrderScreen == null)
                adminOrderScreen = new AdminOrderScreen();
            adminOrderScreen.MdiParent = this;
            adminOrderScreen.Parent = panelBase;
            adminOrderScreen.Dock = DockStyle.Fill;
        }
        /// <summary>
        ///  This function is used to show the admin book screen and hide the order, magazin and music cd screen.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnBook_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnBook.Text, DateTime.Now);
            if (adminBookScreen.Visible == true)
            {
                return;
            }
            adminBookScreen.Show();
            adminMagazineScreen.Hide();
            adminMusicCDScreen.Hide();
            adminOrderScreen.Hide();
        }
        /// <summary>
        ///  This function is used to show the admin magazin screen and hide the order, book and music cd screen.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnMagazines_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnMagazines.Text, DateTime.Now);
            if (adminMagazineScreen.Visible == true)
            {
                return;
            }
            adminBookScreen.Hide();
            adminMagazineScreen.Show();
            adminMusicCDScreen.Hide();
            adminOrderScreen.Hide();
        }
        /// <summary>
        ///  This function is used to show the admin music cd screen and hide the order, magazin and book screen.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnCDs_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnCDs.Text, DateTime.Now);
            if (adminMusicCDScreen.Visible == true)
            {
                return;
            }
            adminBookScreen.Hide();
            adminMagazineScreen.Hide();
            adminMusicCDScreen.Show();
            adminOrderScreen.Hide();
        }
        /// <summary>
        ///  This function is used to show the admin order screen and hide the book,magazin and music cd screen.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnOrders_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnOrders.Text, DateTime.Now);
            if (adminOrderScreen.Visible == true)
            {
                return;
            }
            adminBookScreen.Hide();
            adminMagazineScreen.Hide();
            adminMusicCDScreen.Hide();
            adminOrderScreen.Show();
        }
    }
}
