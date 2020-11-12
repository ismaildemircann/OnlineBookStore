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
    public partial class MusicCdDesign : UserControl
    {
        MusicCD musicCD;
        /// <summary>
        /// This function is Constructor.
        /// </summary>
        /// <param name="musicCD">This parameter is a list of MusicCD class.</param>
        /// <returns> This function does not return a value </returns>
        public MusicCdDesign(MusicCD musicCD)
        {
            InitializeComponent();
            this.musicCD = musicCD;
            lblName.Text += musicCD.Name;
            lblSinger.Text += musicCD.Singer;
            lblType.Text += musicCD.Type.ToString();
            lblPrice.Text += musicCD.Price.ToString() + " ₺";
            picMusicCD.Image = this.musicCD.Image;
        }
        public int quantityMusicCD = 1;
        /// <summary>
        /// This function includes Increase button click operation and increase the quantity.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnIncrease.Text, DateTime.Now);
            quantityMusicCD++;
            lblNumber.Text = quantityMusicCD.ToString();
        }
        /// <summary>
        /// This function includes Decrease button click operation and decrease the quantity.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnDecrease_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnDecrease.Text, DateTime.Now);
            if (quantityMusicCD == 1)
                return;
            quantityMusicCD--;
            lblNumber.Text = quantityMusicCD.ToString();
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
            itemToPurchase.Product = this.musicCD;
            foreach (ItemToPurchase item in StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase)
            {
                if (item.Product.ID1 == itemToPurchase.Product.ID1)
                {
                    MessageBox.Show("It's already in the cart!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            itemToPurchase.Quantity = quantityMusicCD;
            StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].AddProduct(itemToPurchase);
            int i = StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex].itemsToPurchase.Count;
            UtilSave.Save(StoreMainScreen.shoppingCards[LoginScreen.shoppingCardIndex], i);
            MessageBox.Show("Added!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// This function used to changed color when mouse enter.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void MusicCdDesign_MouseEnter(object sender, EventArgs e)
        {
            panelSide.BackColor = Color.FromArgb(78, 184, 206);
            panelBottom.BackColor = Color.FromArgb(78, 184, 206);
        }
        /// <summary>
        /// This function used to changed color when mouse leave.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void MusicCdDesign_MouseLeave(object sender, EventArgs e)
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
        /// This function used to changed color when mouse leave.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void pnlInformation_MouseLeave(object sender, EventArgs e)
        {
            panelSide.BackColor = Color.FromArgb(188, 188, 188);
            panelBottom.BackColor = Color.FromArgb(188, 188, 188);
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
        /// <summary>
        /// This function used to changed color when mouse hover.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void picMusicCD_MouseHover(object sender, EventArgs e)
        {
            panelSide.BackColor = Color.FromArgb(78, 184, 206);
            panelBottom.BackColor = Color.FromArgb(78, 184, 206);
        }
    }
}
