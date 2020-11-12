using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Book_Store.logger;

namespace Online_Book_Store
{
    /**   
     * @brief    This file includes list product operations for usercontrol.
     */
    public partial class ListProduct : UserControl
    {
        /// <summary>
        /// This function used to write product information.
        /// </summary>
        /// <param name="itemToPurchase">This parameter is a object of ItemToPurchase class.</param>
        /// <returns> This function does not return a value  </returns>
        public ListProduct(ItemToPurchase itemToPurchase)
        {
            InitializeComponent();
            lblProductName.Text = itemToPurchase.Product.Name;
            lblNumber.Text = itemToPurchase.Quantity.ToString();
            lblPrice.Text = (itemToPurchase.Product.Price * itemToPurchase.Quantity).ToString() + " ₺";
            ProductImage.Image = itemToPurchase.Product.Image;
            if (itemToPurchase.Product is Book)
                lblItemtype.Text = "Book";
            else if (itemToPurchase.Product is Magazine)
                lblItemtype.Text = "Magazine";
            else
                lblItemtype.Text = "MusicCD";
        }
        /// <summary>
        /// This function includes decrease button click operation and updated shopping card.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnDecrease_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnDecrease.Text, DateTime.Now);
            for (int i = 0; i < StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase.Count; i++)
            {
                if (StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i].Product.Name == lblProductName.Text)
                {
                    if (StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i].Quantity == 1)
                        return;
                    StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i].Quantity--;
                    double paymentAmount = (StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i].Product.Price *
                        StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i].Quantity);
                    StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].PaymentAmount -=
                        StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i].Product.Price;
                    lblNumber.Text = StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i].Quantity.ToString();
                    lblPrice.Text = paymentAmount.ToString() + " ₺";
                    UtilUpdate.Update(StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex]);
                }
            }
        }
        /// <summary>
        /// This function includes increase button click operation and updated shopping card.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnIncrease.Text, DateTime.Now);
            for (int i = 0; i < StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase.Count; i++)
            {
                if (StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i].Product.Name == lblProductName.Text)
                {
                    StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i].Quantity++;
                    double paymentAmount = (StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i].Product.Price *
                        StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i].Quantity);
                    StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].PaymentAmount +=
                        StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i].Product.Price;
                    lblNumber.Text = StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i].Quantity.ToString();
                    lblPrice.Text = paymentAmount.ToString() + " ₺";
                    UtilUpdate.Update(StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex]);
                }
            }
        }
        /// <summary>
        /// This function includes remove button click operation.
        /// This function used to deleted this product and updated shopping card.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnRemove.Text, DateTime.Now);
            for (int i = 0; i < StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase.Count; i++)
            {
                if (StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i].Product.Name == lblProductName.Text)
                {
                    int index = i;
                    UtilUpdate.Delete(StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex], index);
                    StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].RemoveProduct(StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase[i]);
                }
            }
        }
        /// <summary>
        /// This function used to changed color when mouse enter.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void ListProduct_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(219, 226, 239);
        }
        /// <summary>
        /// This function used to changed color when mouse leave.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void ListProduct_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(249, 247, 247);
        }
    }
}