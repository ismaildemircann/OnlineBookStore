using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    class MusicCdFactory : Creator
    {
        private string name;
        private string id;
        private double price;
        private string singer;
        private MusicCD_Type type;
        private Image image;
        /// <summary>
        /// This function holds the music's information.
        /// </summary>
        /// <param name="_name">The _name string hold the product name.</param>
        /// <param name="_id">The _id string hold the product id.</param>
        /// <param name="_price">The _price value hold the product price.</param>
        /// <param name="_singer">The _singer string hold the product singer.</param>
        /// <param name="_type">The _type MusicCD_type hold the product type.</param>
        /// <param name="_image">The _image hold the product image.</param>
        /// <returns> This function does not return a value </returns>
        public MusicCdFactory(string _name, string _id, double _price, string _singer, MusicCD_Type type, Image _image)
        {
            this.name = _name;
            this.id = _id;
            this.price = _price;
            this.singer = _singer;
            this.type = type;
            this.image = _image;
        }
        /// <summary>
        /// This funciton is used to create MusicCd product.
        /// </summary>
        /// <returns>name, id, price, singer, type, image)</returns>
        public override Product FactoryMethod()
        {
            return new MusicCD(name, id, price, singer, type, image);
        }
    }
}
