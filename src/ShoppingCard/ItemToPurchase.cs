using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    /**   
    * @brief    This file includes order operations.
    */
    public class ItemToPurchase
    {
        private Product product;
        private int quantity;
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public Product Product { get => product; set => product = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
