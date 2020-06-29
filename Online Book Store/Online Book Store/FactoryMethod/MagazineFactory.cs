using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    /**   
    * @brief    This file includes to Magazine information.
    */
    class MagazineFactory : Creator
    {
        private string name;
        private string id;
        private double price;
        private string issue;
        private Magazine_Type type;
        private Image image;
        /// <summary>
        /// This function  holds the magazine's information.
        /// </summary>
        /// <param name="_name">The _name string hold the product name.</param>
        /// <param name="_id">The _id string hold the product id.</param>
        /// <param name="_price">The _price value hold the product price.</param>
        /// <param name="_issue">The _issue string hold the product issue.</param>
        /// <param name="_type">The _type Magazine_Type hold the product type.</param>
        /// <param name="_image">The _image hold the product image.</param>
        /// <returns> This function does not return a value </returns>
        public MagazineFactory(string _name, string _id, double _price, string _issue, Magazine_Type _type, Image _image)
        {
            this.name = _name;
            this.id = _id;
            this.price = _price;
            this.issue = _issue;
            this.type = _type;
            this.image = _image;
        }
        /// <summary>
        /// This funciton is used to create magazine product.
        /// </summary>
        /// <returns>name, id, price, issue, type, image</returns>
        public override Product FactoryMethod()
        {
            return new Magazine(name, id, price, issue, type, image);
        }
    }
}
