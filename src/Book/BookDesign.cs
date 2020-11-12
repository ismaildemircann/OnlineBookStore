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
    * @brief   This file includes to cd information.
    */
    public partial class BookDesign : UserControl
    {
        Book book;
        /// <summary>
        /// This function is Constructor.
        /// </summary>
        /// <param name="book">This parameter is a list of Book class.</param>
        /// <returns> This function does not return a value </returns>
        public BookDesign(Book book)
        {
            InitializeComponent();
            this.book = book;
            lblName.Text += book.Name;
            lblISBN.Text += book.ISBN1;
            lblAuthor.Text += book.Author;
            lblPublisher.Text += book.Publisher;
            lblPage.Text += book.Pages.ToString();
            lblPrice.Text += book.Price.ToString() + " ₺";
            picBook.Image = book.Image;
        }
        /// <summary>
        /// This function includes Add button click operation.
        /// This function used to called the add product for shopping card and save for util function.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnAdd.Text, DateTime.Now);
            ItemToPurchase itemToPurchase = new ItemToPurchase();
            itemToPurchase.Product = book;
            foreach (ItemToPurchase item in StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase)
            {
                if (item.Product.ID1 == itemToPurchase.Product.ID1)
                {
                    MessageBox.Show("It's already in the cart!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            itemToPurchase.Quantity = quantityBook;
            StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].AddProduct(itemToPurchase);
            int i = StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase.Count;
            UtilSave.Save(StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex], i);
            MessageBox.Show("Added!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public int quantityBook = 1;
        /// <summary>
        /// This function includes Increase button click operation and increase the quantity.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnIncrease.Text, DateTime.Now);
            quantityBook++;
            lblNumber.Text = quantityBook.ToString();
        }
        /// <summary>
        /// This function includes Decrease button click operation and decrease the quantity.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnDecrease_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnDecrease.Text, DateTime.Now);
            if (quantityBook == 1)
            {
                return;
            }
            quantityBook--;
            lblNumber.Text = quantityBook.ToString();
        }
        /// <summary>
        /// This function used to changed color when mouse enter.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void BookDesign_MouseEnter(object sender, EventArgs e)
        {
            panelSide.BackColor = Color.FromArgb(78, 184, 206);
            panelBottom.BackColor = Color.FromArgb(78, 184, 206);
        }
        /// <summary>
        /// This function used to changed color when mouse leave.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void BookDesign_MouseLeave(object sender, EventArgs e)
        {
            panelSide.BackColor = Color.FromArgb(78, 184, 206);
            panelBottom.BackColor = Color.FromArgb(78, 184, 206);
        }
        /// <summary>
        /// This function used to changed color when mouse enter.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void pnlInformation_MouseEnter(object sender, EventArgs e)
        {
            panelSide.BackColor = Color.FromArgb(78, 184, 206);
            panelBottom.BackColor = Color.FromArgb(78, 184, 206);
        }
        /// <summary>
        /// This function used to changed color when mouse enter.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void pnlQuantity_MouseEnter(object sender, EventArgs e)
        {
            panelSide.BackColor = Color.FromArgb(78, 184, 206);
            panelBottom.BackColor = Color.FromArgb(78, 184, 206);
        }
        /// <summary>
        /// This function used to changed color when mouse leave.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void pnlInformation_MouseLeave(object sender, EventArgs e)
        {
            panelSide.BackColor = Color.FromArgb(188, 188, 188);
            panelBottom.BackColor = Color.FromArgb(188, 188, 188);
        }
        /// <summary>
        /// This function used to changed color when mouse leave.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void pnlQuantity_MouseLeave(object sender, EventArgs e)
        {
            panelSide.BackColor = Color.FromArgb(188, 188, 188);
            panelBottom.BackColor = Color.FromArgb(188, 188, 188);
        }
        /// <summary>
        /// This function used to changed color when mouse hover.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            panelSide.BackColor = Color.FromArgb(78, 184, 206);
            panelBottom.BackColor = Color.FromArgb(78, 184, 206);
        }
    }
}
