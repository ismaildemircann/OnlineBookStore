using Online_Book_Store.shoppingCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Online_Book_Store
{
    /**
    * @brief    This file save from the xml file.
    */
    public class UtilSave
    {
        public static int registrationNo = 1;
        /// <summary>
        /// This function save elements of the ShoppingCard.xml file.
        /// </summary>
        /// <param name="shoppingCard">This parameter is a object of ShoppingCard class.</param>
        /// <returns> This function does not return a value </returns>
        public static void Save(ShoppingCard shoppingCard)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"data/ShoppingCard.xml");
                XElement rootElement = xDoc.Root;
                XElement newElementShoppingCard = new XElement("ShoppingCard");
                XAttribute ShoppingCardAttribute = new XAttribute("CustomerID", shoppingCard.CustomerID);
                XElement PaymentAmount = new XElement("PaymentAmount", shoppingCard.PaymentAmount);
                XElement PaymentType = new XElement("PaymentType", shoppingCard.Type);
                XElement ItemToPurchaseListElement = new XElement("ItemToPurchaseList", shoppingCard.itemsToPurchase);
                newElementShoppingCard.Add(ShoppingCardAttribute, PaymentAmount, PaymentType, ItemToPurchaseListElement);
                rootElement.Add(newElementShoppingCard);
                xDoc.Save(@"data/ShoppingCard.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// This function save elements of the ShoppingCard.xml file.
        /// </summary>
        /// <param name="shoppingCard">This parameter is a object of ShoppingCard class.</param>
        /// <param name="i">This parameter  hold a last element.</param>
        /// <returns> This function does not return a value </returns>
        public static void Save(ShoppingCard shoppingCard, int i)
        {
            i--;
            XDocument xDoc = XDocument.Load(@"data/ShoppingCard.xml");
            XElement shoppingCardRootElement = xDoc.Root;
            foreach (XElement Card in shoppingCardRootElement.Elements())
            {
                if (Card.Attribute("CustomerID").Value == shoppingCard.CustomerID)
                {
                    Card.Element("PaymentAmount").Value = shoppingCard.PaymentAmount.ToString();
                    XElement newElementItemToPurchase = new XElement("ItemToPurchase");
                    XAttribute classType;
                    XElement ID = new XElement("id", shoppingCard.itemsToPurchase[i].Product.ID1);
                    XElement name = new XElement("name", shoppingCard.itemsToPurchase[i].Product.Name);
                    XElement price = new XElement("price", shoppingCard.itemsToPurchase[i].Product.Price);
                    XElement image = new XElement("image", UtilConvert.ImageToBase64(shoppingCard.itemsToPurchase[i].Product.Image,
                        shoppingCard.itemsToPurchase[i].Product.Image.RawFormat));
                    XElement quantity = new XElement("quantity", shoppingCard.itemsToPurchase[i].Quantity);
                    if (shoppingCard.itemsToPurchase[i].Product is Book)
                        classType = new XAttribute("classType", "Book");
                    else if (shoppingCard.itemsToPurchase[i].Product is Magazine)
                        classType = new XAttribute("classType", "Magazine");
                    else
                        classType = new XAttribute("classType", "MusicCD");
                    newElementItemToPurchase.Add(classType, ID, name, price, image, quantity);
                    Card.Element("ItemToPurchaseList").Add(newElementItemToPurchase);
                }
                xDoc.Save(@"data/ShoppingCard.xml");
            }
        }
        /// <summary>
        /// This function save elements of the ProductList.xml file.
        /// </summary>
        /// <param name="product">This parameter is a object of Product class.</param>
        /// <returns> This function does not return a value </returns>
        public static void Save(Product product)
        {
            XDocument xDoc = XDocument.Load(@"data/ProductList.xml");
            XElement rootElement = xDoc.Root;
            XElement newElementProduct = new XElement("Product");
            if (product is Book)
            {
                Book temp = (Book)product;
                XAttribute attClassType = new XAttribute("Class", "Book");
                XAttribute attID = new XAttribute("ID", temp.ID1);
                XElement name = new XElement("Name", temp.Name);
                XElement price = new XElement("Price", temp.Price);
                XElement image = new XElement("Image", UtilConvert.ImageToBase64(temp.Image, temp.Image.RawFormat));
                XElement isbn = new XElement("ISBN", temp.ISBN1);
                XElement author = new XElement("Author", temp.Author);
                XElement publisher = new XElement("Publisher", temp.Publisher);
                XElement pages = new XElement("Pages", temp.Pages);
                newElementProduct.Add(attClassType, attID, name, price, image, isbn, author, publisher, pages);
                rootElement.Add(newElementProduct);
                xDoc.Save(@"data/ProductList.xml");
                return;
            }
            else if (product is Magazine)
            {
                Magazine temp = (Magazine)product;
                XAttribute attClassType = new XAttribute("Class", "Magazine");
                XAttribute attID = new XAttribute("ID", temp.ID1);
                XElement name = new XElement("Name", temp.Name);
                XElement price = new XElement("Price", temp.Price);
                XElement image = new XElement("Image", UtilConvert.ImageToBase64(temp.Image, temp.Image.RawFormat));
                XElement issue = new XElement("Issue", temp.Issue);
                XElement magazineType = new XElement("MagazineType", temp.Type);
                newElementProduct.Add(attClassType, attID, name, price, image, issue, magazineType);
                rootElement.Add(newElementProduct);
                xDoc.Save(@"data/ProductList.xml");
                return;
            }
            else
            {
                MusicCD temp = (MusicCD)product;
                XAttribute attClassType = new XAttribute("Class", "MusicCD");
                XAttribute attID = new XAttribute("ID", temp.ID1);
                XElement name = new XElement("Name", temp.Name);
                XElement price = new XElement("Price", temp.Price);
                XElement image = new XElement("Image", UtilConvert.ImageToBase64(temp.Image, temp.Image.RawFormat));
                XElement singer = new XElement("Singer", temp.Singer);
                XElement musicCDType = new XElement("MusicCDType", temp.Type);
                newElementProduct.Add(attClassType, attID, name, price, image, singer, musicCDType);
                rootElement.Add(newElementProduct);
                xDoc.Save(@"data/ProductList.xml");
                return;
            }
        }
        /// <summary>
        /// This function save elements of the MyOrders.xml file.
        /// </summary>
        /// <param name="shoppingCard">This parameter is a object of ShoppingCard class.</param>
        /// <returns> This function does not return a value </returns>
        public static void SaveOrder(ShoppingCard shoppingCard)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"data/MyOrders.xml");
                XElement rootElement = xDoc.Root;
                XElement newElementOrder = new XElement("Order");
                XAttribute OrderAttribute = new XAttribute("CustomerID", shoppingCard.CustomerID);
                XAttribute orderID = new XAttribute("OrderID", (shoppingCard.OID).ToString());
                XElement PaymentAmount = new XElement("PaymentAmount", shoppingCard.PaymentAmount);
                XElement PaymentType = new XElement("PaymentType", shoppingCard.Type);
                XElement OrderStatus = new XElement("OrderStatus", shoppingCard.Status);
                XElement CargoAmount = new XElement("CargoAmount", shoppingCard.CargoAmount);
                XElement ItemToPurchaseListElement = new XElement("ItemToPurchaseList");
                for (int i = 0; i < shoppingCard.itemsToPurchase.Count; i++)
                {
                    XElement newElementItemToPurchase = new XElement("ItemToPurchase");
                    XAttribute classType;
                    XElement ID = new XElement("id", shoppingCard.itemsToPurchase[i].Product.ID1);
                    XElement name = new XElement("name", shoppingCard.itemsToPurchase[i].Product.Name);
                    XElement price = new XElement("price", shoppingCard.itemsToPurchase[i].Product.Price);
                    XElement image = new XElement("image", UtilConvert.ImageToBase64(shoppingCard.itemsToPurchase[i].Product.Image,
                        shoppingCard.itemsToPurchase[i].Product.Image.RawFormat));
                    XElement quantity = new XElement("quantity", shoppingCard.itemsToPurchase[i].Quantity);
                    if (shoppingCard.itemsToPurchase[i].Product is Book)
                        classType = new XAttribute("classType", "Book");
                    else if (shoppingCard.itemsToPurchase[i].Product is Magazine)
                        classType = new XAttribute("classType", "Magazine");
                    else
                        classType = new XAttribute("classType", "MusicCD");
                    newElementItemToPurchase.Add(classType, ID, name, price, image, quantity);
                    ItemToPurchaseListElement.Add(newElementItemToPurchase);
                }
                newElementOrder.Add(OrderAttribute, orderID, PaymentAmount, PaymentType, OrderStatus, CargoAmount, ItemToPurchaseListElement);
                rootElement.Add(newElementOrder);
                xDoc.Save(@"data/MyOrders.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
