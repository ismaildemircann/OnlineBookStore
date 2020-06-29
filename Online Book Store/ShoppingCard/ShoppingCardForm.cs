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
     * @brief    This file includes shopping card operations .
     */
    public partial class ShoppingCardForm : Form
    {
        static ShoppingList shoppingList = new ShoppingList();
        public ShoppingCardForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function used to load shopping card form and show shopping list.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void ShoppingCardForm_Load(object sender, EventArgs e)
        {
            menuStripShoppingCard.ForeColor = Color.FromArgb(249, 247, 247);
            shoppingList.MdiParent = this;
            shoppingList.Parent = pnlShoppingCard;
            shoppingList.Dock = DockStyle.Fill;
            shoppingList.Show();
        }
        /// <summary>
        /// This function includes shopping list tool strip menu item button click operation.
        /// This function used to show the shopping list.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void shoppingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, shoppingListToolStripMenuItem.Text, DateTime.Now);
            shoppingList.Show();
        }
        /// <summary>
        /// This function used to exit application.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void ShoppingCardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}