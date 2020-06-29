using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store
{
    /**
     * @brief    This file includes order operations for usercontrol.
     */
    public partial class MyOrdersDesign : UserControl
    {
        /// <summary>
        /// This function write product information.
        /// </summary>
        /// <param name="item">This parameter is a object of ItemToPurchase class.</param>
        /// <returns> This function does not return a value  </returns>
        public MyOrdersDesign(ItemToPurchase item)
        {
            InitializeComponent();
            lbName.Text = item.Product.Name;
            lbPrice.Text = item.Product.Price.ToString() + " ₺";
            if (item.Quantity == 1)
                lbQuantity.Text = item.Quantity.ToString() + " piece";
            else
                lbQuantity.Text = item.Quantity.ToString() + " pcs";
            ProductPic.Image = item.Product.Image;
        }
    }
}
