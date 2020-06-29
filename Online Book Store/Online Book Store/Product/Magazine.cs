using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    /**
    * @brief   This file includes to magazine information.
    */
    /// <summary>
    /// This function holds the magazine types.
    /// </summary>
    public enum Magazine_Type
    {
        Actual, News, Sport, Computer, Technology
    }
    public class Magazine : Product
    {
        private string issue;
        private Magazine_Type type;
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string Issue { get => issue; set => issue = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public Magazine_Type Type { get => type; set => type = value; }
        /// <summary>
        /// This function is Constructor and holds the magazine's information.
        /// </summary>
        /// <param name="_name">The _name string hold the product name.</param>
        /// <param name="_id">The _id string hold the product id.</param>
        /// <param name="_price">The _price value hold the product price.</param>
        /// <param name="_issue">The _issue string hold the product issue.</param>
        /// <param name="_type">The _type Magazine_Type hold the product type.</param>
        /// <param name="_image">The _image hold the product image.</param>
        /// <returns> This function does not return a value </returns>
        public Magazine(string _name, string _id, double _price, string _issue, Magazine_Type _type, Image _image)
        {
            this.Name = _name;
            this.ID1 = _id;
            this.Price = _price;
            this.Issue = _issue;
            this.Type = _type;
            this.Image = _image;
        }
        /// <summary>
        /// This function used to print product properties.
        /// </summary>
        /// <returns>ID,Name,Price,Issue and type.</returns>
        public override string PrintProperties()
        {
            return base.ID1 + base.Name + base.Price.ToString()
                   + Issue + Type;
        }
    }
}
