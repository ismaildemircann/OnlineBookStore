using Online_Book_Store.shoppingCard;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Online_Book_Store
{
    /**
     * @brief   This file load from the XML files.
     */
    public class UtilLoad
    {
        /// <summary>
        ///  This function loads the elements of the Customer.xml file.
        /// </summary>
        /// <param name="customerList">This parameter is a list of Customer class.</param>
        /// <returns> This function does not return a value  </returns>
        public static void Load(List<Customer> customerList)
        {
            if (!File.Exists(@"data/Customer.xml"))
            {
                XmlTextWriter writer = new XmlTextWriter(@"data/Customer.xml", System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("Customers");
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                return;
            }
            XDocument xDoc = XDocument.Load(@"data/Customer.xml");
            XElement rootElement = xDoc.Root;
            foreach (XElement customer in rootElement.Elements())
            {
                UtilSave.registrationNo = Int32.Parse(customer.FirstAttribute.Value);
                Customer tempCustomer = new Customer(customer.Element("Name").Value, customer.Element("Address").Value,
                    customer.Element("Email").Value, customer.Element("Username").Value, customer.Element("Password").Value,
                    customer.Element("CustomerID").Value);
                customerList.Add(tempCustomer);
            }
            UtilSave.registrationNo++;
        }
        /// <summary>
        ///  This function loads the elements of the ShoppingCard.xml file.
        /// </summary>
        /// <param name="shoppingCardList">This parameter is a list of ShoppingCard class.</param>
        /// <returns> This function does not return a value  </returns>
        public static void Load(List<ShoppingCard> shoppingCardList)
        {
            if (!File.Exists(@"data/ShoppingCard.xml"))
            {
                XmlTextWriter writer = new XmlTextWriter(@"data/ShoppingCard.xml", System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("ShoppingCards");
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                return;
            }
            XDocument xDoc = XDocument.Load(@"data/ShoppingCard.xml");
            XElement shoppingCardRootElement = xDoc.Root;
            NumberFormatInfo info = new NumberFormatInfo();
            info.NumberDecimalSeparator = ".";
            foreach (XElement shoppingCard in shoppingCardRootElement.Elements())
            {
                string customerID = shoppingCard.FirstAttribute.Value;
                double amount = Convert.ToDouble(shoppingCard.Element("PaymentAmount").Value, info);
                PaymentType type = PaymentType.cash;
                if (shoppingCard.Element("PaymentType").Value == "creditcard")
                    type = PaymentType.creditcard;
                List<ItemToPurchase> tempitemsToPurchase = new List<ItemToPurchase>();
                XElement itemToPurchaseRootElement = shoppingCard.Element("ItemToPurchaseList");
                foreach (XElement item in itemToPurchaseRootElement.Elements())
                {
                    ItemToPurchase itemToPurchase = new ItemToPurchase();
                    string classType = item.FirstAttribute.Value;
                    string ID = item.Element("id").Value;
                    string name = item.Element("name").Value;
                    double price = Convert.ToDouble(item.Element("price").Value, info);
                    Image image = UtilConvert.Base64ToImage(item.Element("image").Value);
                    Creator c;
                    if (classType == "Book")
                    {
                        c = new BookFactory(name, ID, price, "", "", "", 0, image);
                        itemToPurchase.Product = c.FactoryMethod();
                    }
                    else if (classType == "Magazine")
                    {
                        c = new MagazineFactory(name, ID, price, "", Magazine_Type.Actual, image);
                        itemToPurchase.Product = c.FactoryMethod();
                    }
                    else
                    {
                        c = new MusicCdFactory(name, ID, price, "", MusicCD_Type.Country, image);
                        itemToPurchase.Product = c.FactoryMethod();
                    }
                    itemToPurchase.Quantity = Int32.Parse(item.Element("quantity").Value);
                    tempitemsToPurchase.Add(itemToPurchase);
                }
                ShoppingCard shoppCard = new ShoppingCard();
                shoppCard.itemsToPurchase = tempitemsToPurchase;
                shoppCard.PaymentAmount = amount;
                shoppCard.CustomerID = customerID;
                shoppCard.Type = type;
                shoppingCardList.Add(shoppCard);
            }
        }
        /// <summary>
        ///  This function loads the elements of the ProductList.xml file.
        /// </summary>
        /// <param name="productList">This parameter is a list of Product class.</param>
        /// <returns> This function does not return a value  </returns>
        public static void Load(List<Product> productList)
        {
            if (!File.Exists(@"data/ProductList.xml"))
            {
                XmlTextWriter writer = new XmlTextWriter(@"data/ProductList.xml", System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("Products");
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                return;
            }
            XDocument xDoc = XDocument.Load(@"data/ProductList.xml");
            XElement rootElement = xDoc.Root;
            foreach (XElement product in rootElement.Elements())
            {
                Creator c;
                string classType = product.FirstAttribute.Value;
                NumberFormatInfo info = new NumberFormatInfo();
                info.NumberDecimalSeparator = ".";
                string name = product.Element("Name").Value;
                string id = product.LastAttribute.Value;
                double price = Convert.ToDouble(product.Element("Price").Value, info);
                Image image = UtilConvert.Base64ToImage(product.Element("Image").Value);
                if (classType == "Book")
                {
                    string isbn = product.Element("ISBN").Value;
                    string author = product.Element("Author").Value;
                    string publisher = product.Element("Publisher").Value;
                    int pages = Convert.ToInt32(product.Element("Pages").Value);
                    c = new BookFactory(name, id, price, isbn, author, publisher, pages, image);
                }
                else if (classType == "Magazine")
                {
                    string issue = product.Element("Issue").Value;
                    Magazine_Type type = Magazine_Type.Actual;
                    switch (product.Element("MagazineType").Value)
                    {
                        case "Computer":
                            type = Magazine_Type.Computer;
                            break;
                        case "News":
                            type = Magazine_Type.News;
                            break;
                        case "Sport":
                            type = Magazine_Type.Sport;
                            break;
                        case "Technology":
                            type = Magazine_Type.Technology;
                            break;
                        default:
                            break;
                    }
                    c = new MagazineFactory(name, id, price, issue, type, image);
                }
                else
                {
                    string singer = product.Element("Singer").Value;
                    MusicCD_Type type = MusicCD_Type.Country;
                    switch (product.Element("MusicCDType").Value)
                    {
                        case "HardRock":
                            type = MusicCD_Type.HardRock;
                            break;
                        case "Romance":
                            type = MusicCD_Type.Romance;
                            break;
                        default:
                            break;
                    }
                    c = new MusicCdFactory(name, id, price, singer, type, image);
                }
                productList.Add(c.FactoryMethod());
            }
        }
        /// <summary>
        ///  This function loads the elements of the MyOrders.xml file.
        /// </summary>
        /// <param name="OrderList">This parameter is a list of ShoppingCard class.</param>
        /// <returns> This function does not return a value  </returns>
        public static void LoadOrder(List<ShoppingCard> OrderList)
        {
            if (!File.Exists(@"data/MyOrders.xml"))
            {
                XmlTextWriter writer = new XmlTextWriter(@"data/MyOrders.xml", System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("Orders");
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                return;
            }
            XDocument xDoc = XDocument.Load(@"data/MyOrders.xml");
            XElement OrderRootElement = xDoc.Root;
            NumberFormatInfo info = new NumberFormatInfo();
            info.NumberDecimalSeparator = ".";
            foreach (XElement order in OrderRootElement.Elements())
            {
                string customerID = order.FirstAttribute.Value;
                double amount = Convert.ToDouble(order.Element("PaymentAmount").Value, info);
                PaymentType type = PaymentType.cash;
                if (order.Element("PaymentType").Value == "creditcard")
                    type = PaymentType.creditcard;
                else if (order.Element("PaymentType").Value == "transfer")
                    type = PaymentType.transfer;
                OrderStatus orderStatus = OrderStatus.canceled;
                if (order.Element("OrderStatus").Value == "received")
                    orderStatus = OrderStatus.received;
                else if (order.Element("OrderStatus").Value == "shipped")
                    orderStatus = OrderStatus.shipped;
                else if (order.Element("OrderStatus").Value == "waitForShip")
                    orderStatus = OrderStatus.waitForShip;
                int cargoamount = Convert.ToInt32(order.Element("CargoAmount").Value);
                int oid = Convert.ToInt32(order.LastAttribute.Value);
                List<ItemToPurchase> tempitemsToPurchase = new List<ItemToPurchase>();
                XElement itemToPurchaseRootElement = order.Element("ItemToPurchaseList");
                foreach (XElement item in itemToPurchaseRootElement.Elements())
                {
                    ItemToPurchase itemToPurchase = new ItemToPurchase();
                    string id = item.Element("id").Value;
                    string name = item.Element("name").Value;
                    double price = Convert.ToDouble(item.Element("price").Value, info);
                    int quantity = Convert.ToInt32(item.Element("quantity").Value);
                    Image image = UtilConvert.Base64ToImage(item.Element("image").Value);
                    Creator c;
                    if (item.FirstAttribute.Value == "Book")
                    {
                        c = new BookFactory(name, id, price, "", "", "", 0, image);
                        itemToPurchase.Product = c.FactoryMethod();
                        itemToPurchase.Quantity = quantity;
                        tempitemsToPurchase.Add(itemToPurchase);
                    }
                    else if (item.FirstAttribute.Value == "Magazine")
                    {
                        c = new MagazineFactory(name, id, price, "", Magazine_Type.Actual, image);
                        itemToPurchase.Product = c.FactoryMethod();
                        itemToPurchase.Quantity = quantity;
                        tempitemsToPurchase.Add(itemToPurchase);
                    }
                    else
                    {
                        c = new MusicCdFactory(name, id, price, "", MusicCD_Type.Country, image);
                        itemToPurchase.Product = c.FactoryMethod();
                        itemToPurchase.Quantity = quantity;
                        tempitemsToPurchase.Add(itemToPurchase);
                    }
                }
                ShoppingCard _order = new ShoppingCard();
                _order.itemsToPurchase = tempitemsToPurchase;
                _order.PaymentAmount = amount;
                _order.CustomerID = customerID;
                _order.Type = type;
                _order.Status = orderStatus;
                _order.CargoAmount = cargoamount;
                _order.OID = oid;
                OrderList.Add(_order);
            }
        }
    }
}