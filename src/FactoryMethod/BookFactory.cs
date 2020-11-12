using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    /**
    * @brief   This file includes to file convert operations.
    */
    class BookFactory : Creator
    {
        private string name;
        private string id;
        private double price;
        private string ISBN;
        private string author;
        private int pages;
        private string publisher;
        private Image image;
        /// <summary>
        /// This function holds the book's information.
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
        public BookFactory(string _name, string _id, double _price, string _ISBN, string _author, string _publisher, int _pages, Image _image)
        {
            this.name = _name;
            this.id = _id;
            this.price = _price;
            this.ISBN = _ISBN;
            this.author = _author;
            this.publisher = _publisher;
            this.pages = _pages;
            this.image = _image;
        }
        /// <summary>
        /// This funciton is used to create book product.
        /// </summary>
        /// <returns>Name,id,price, ISBN, author, publisher, pages,image</returns>
        public override Product FactoryMethod()
        {
            return new Book(name, id, price, ISBN, author, publisher, pages,image);
        }
    }
}
