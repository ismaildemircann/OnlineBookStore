using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    /**
    * @brief   This file includes to cd information.
    */
    /// <summary>
    /// This function holds the music types.
    /// </summary>
    public enum MusicCD_Type
    {
        Romance, HardRock, Country
    }
    public class MusicCD : Product
    {
        private string singer;
        private MusicCD_Type type;
        /// <summary>
        /// This function used to get and set operation.
        /// </summary
        public string Singer { get => singer; set => singer = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary
        public MusicCD_Type Type { get => type; set => type = value; }
        /// <summary>
        /// This function is Constructor and holds the music's information.
        /// </summary>
        /// <param name="_name">The _name string hold the product name.</param>
        /// <param name="_id">The _id string hold the product id.</param>
        /// <param name="_price">The _price value hold the product price.</param>
        /// <param name="_singer">The _singer string hold the product singer.</param>
        /// <param name="_type">The _type MusicCD_type hold the product type.</param>
        /// <param name="_image">The _image hold the product image.</param>
        /// <returns> This function does not return a value </returns>
        public MusicCD(string _name, string _id, double _price, string _singer, MusicCD_Type _type, Image _image)
        {
            this.Name = _name;
            this.ID1 = _id;
            this.Price = _price;
            this.Singer = _singer;
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
                   + Singer + Type;
        }
    }
}
