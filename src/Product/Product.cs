using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    /**
    * @brief   This file includes to product information.
    */
    public abstract class Product
    {
        private string name;
        private string ID;
        private double price;
        private Image image;
        /// <summary>
        /// This function used to get and set operation.
        /// </summary
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary
        public string ID1 { get => ID; set => ID = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary
        public double Price { get => price; set => price = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary
        public Image Image { get => image; set => image = value; }
        public abstract string PrintProperties();
    }
}
