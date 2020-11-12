using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    /**   
    * @brief    This file includes to book information.
    */
    public class Book : Product
    {
        private string ISBN;
        private string author;
        private int pages;
        private string publisher;
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string Author { get => author; set => author = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string Publisher { get => publisher; set => publisher = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public int Pages { get => pages; set => pages = value; }
        /// <summary>
        /// This function is Constructor and holds the book's information.
        /// </summary>
        /// <param name="_name">The _name string hold the product name.</param>
        /// <param name="_id">The _id string hold the product id.</param>
        /// <param name="_price">The _price value hold the product price.</param>
        /// <param name="_ISBN">The _ISBN string hold the product ISBN.</param>
        /// <param name="_author">the _author string hold the product author.</param>
        /// <param name="_publisher">The _publisher string hold the product publisher.</param>
        /// <param name="_pages">The _pages value hold the product pages number.</param>
        /// <param name="_image">The _image hold the product image.</param>
        /// <returns> This function does not return a value </returns>
        public Book(string _name, string _id, double _price, string _ISBN, string _author, string _publisher, int _pages, Image _image)
        {
            this.Name = _name;
            this.ID1 = _id;
            this.Price = _price;
            this.ISBN1 = _ISBN;
            this.Author = _author;
            this.Publisher = _publisher;
            this.Pages = _pages;
            this.Image = _image;
        }
        /// <summary>
        /// This function used to print product properties.
        /// </summary>
        /// <returns>ID,Name,Price,ISBN,Authot,Publisher and Pages</returns>
        public override string PrintProperties()
        {
            return base.ID1 + base.Name + base.Price.ToString()
                   + ISBN1 + Author + Publisher + Pages;
        }
    }
}
