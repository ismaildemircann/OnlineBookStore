using Online_Book_Store.shoppingCard;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Online_Book_Store
{
    /**
     * @brief   This file includes to file convert operations.
     */
    public class UtilConvert
    {
        /// <summary>
        /// This function hashes an incoming string using the SHA256 hash algorithm.
        /// It is used to keep the given password in hash.
        /// </summary>
        /// <param name="rawData">the rawData string hold the user password.</param>
        /// <returns> This function return a hash string </returns>
        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("x2"));
                return builder.ToString();
            }
        }
        /// <summary>
        /// This function convert base 64 string to byte[].
        /// After that Convert byte[] to Image.
        /// </summary>
        /// <param name="base64String">the base64String string hold the image data.</param>
        /// <returns> This function return a image </returns>
        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
        /// <summary>
        /// This function convert from Image to base 64 string.
        /// After that convert Image to byte[].
        /// </summary>
        /// <param name="image">the image hold the Image.</param>
        /// <param name="format">the format hold the Image format.</param>
        /// <returns> This function return base 64 string </returns>
        public static string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap bitmap = new Bitmap(image);
                bitmap.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
    }
}