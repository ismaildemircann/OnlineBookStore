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
    public partial class ShoppingList : Form
    {
        public ShoppingList()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function includes cancel button click operation.
        /// This function used to called delete for util and cancel order for shopping shoppingCards function.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnCancel.Text, DateTime.Now);
            DialogResult dr = MessageBox.Show("Your order will be canceled. Do you want to proceed?", "Info",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                UtilUpdate.Delete(StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex]);
                StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].CancelOrder();
                flpShoppingList.Controls.Clear();
            }
        }
        /// <summary>
        /// This function used to load shopping list and add the shopping list.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void ShoppingList_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase.Count; i++)
            {
                ListProduct listProduct;
                listProduct = new ListProduct(StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i]);
                listProduct.btnRemove.Click += BtnRemove_Click;
                listProduct.btnDecrease.Click += BtnDecrease_Click;
                listProduct.btnIncrease.Click += BtnIncrease_Click;
                flpShoppingList.Controls.Add(listProduct);                
            }
        }

        private void BtnIncrease_Click(object sender, EventArgs e)
        {
        }

        private void BtnDecrease_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// This function includes remove button click operation.
        /// This function used to clear to controls and call again the ShoppingList_Load.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            flpShoppingList.Controls.Clear();
            ShoppingList_Load(sender, e);
        }
        /// <summary>
        /// This function includes checkout button click operation.
        /// This function used to hide the shopping card form and show the invoice screen.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnCheckout.Text, DateTime.Now);
            StoreMainScreen.ShoppingCardForm.Hide();
            Invoice invoiceScreen = new Invoice();
            invoiceScreen.Show();
        }
        /// <summary>
        /// This function includes continue shopping button click operation.
        /// This function used to hide the shopping card form and show the store main screen.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnContinueShopping_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnContinueShopping.Text, DateTime.Now);
            StoreMainScreen.storeMainScreen.Show();
            StoreMainScreen.ShoppingCardForm.Hide();
        }
        /// <summary>
        /// This function used to clear controls and called again shopping list load.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void ShoppingList_VisibleChanged(object sender, EventArgs e)
        {
            flpShoppingList.Controls.Clear();
            ShoppingList_Load(sender, e);
        }
    }
}
