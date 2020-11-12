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
    * @brief    This file update and delete from the xml file.
    */
    public class UtilUpdate
    {
        /// <summary>
        /// This function update elements of the ShoppingCard.xml file.
        /// </summary>
        /// <param name="shoppingCard">This parameter is a object of ShoppingCard class.</param>
        /// <returns> This function does not return a value </returns>
        public static void Update(ShoppingCard shoppingCard)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"data/ShoppingCard.xml");
                XElement shoppingCardRootElement = xDoc.Root;
                foreach (XElement Card in shoppingCardRootElement.Elements())
                {
                    int i = 0;
                    if (Card.Attribute("CustomerID").Value == shoppingCard.CustomerID)
                    {
                        Card.Element("PaymentAmount").Value = shoppingCard.PaymentAmount.ToString();
                        Card.Element("PaymentType").Value = shoppingCard.Type.ToString();
                        XElement itemToPurchaseRootElement = Card.Element("ItemToPurchaseList");
                        foreach (XElement item in itemToPurchaseRootElement.Elements())
                        {
                            if (item.Element("id").Value == shoppingCard.itemsToPurchase[i].Product.ID1)
                            {
                                item.Element("name").Value = shoppingCard.itemsToPurchase[i].Product.Name;
                                item.Element("price").Value = shoppingCard.itemsToPurchase[i].Product.Price.ToString();
                                item.Element("quantity").Value = shoppingCard.itemsToPurchase[i].Quantity.ToString();
                                break;
                            }
                            i++;
                        }
                    }
                    xDoc.Save(@"data/ShoppingCard.xml");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// This function update elements of the ProductList.xml file.
        /// </summary>
        /// <param name="product">This parameter is a object of Product class.</param>
        /// <returns> This function does not return a value </returns>
        public static void Update(Product product)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"data/ProductList.xml");
                XElement rootElement = xDoc.Root;
                foreach (XElement item in rootElement.Elements())
                {
                    if (item.Attribute("ID").Value == product.ID1)
                    {
                        if (product is Book)
                        {
                            Book temp = (Book)product;
                            item.Element("Name").Value = temp.Name;
                            item.Element("Price").Value = temp.Price.ToString();
                            item.Element("Image").Value = UtilConvert.ImageToBase64(temp.Image, temp.Image.RawFormat);
                            item.Element("ISBN").Value = temp.ISBN1;
                            item.Element("Author").Value = temp.Author;
                            item.Element("Publisher").Value = temp.Publisher;
                            item.Element("Pages").Value = temp.Pages.ToString();
                            xDoc.Save(@"data/ProductList.xml");
                            return;
                        }
                        else if (product is Magazine)
                        {
                            Magazine temp = (Magazine)product;
                            item.Element("Name").Value = temp.Name;
                            item.Element("Price").Value = temp.Price.ToString();
                            item.Element("Image").Value = UtilConvert.ImageToBase64(temp.Image, temp.Image.RawFormat);
                            item.Element("Issue").Value = temp.Issue;
                            item.Element("MagazineType").Value = temp.Type.ToString();
                            xDoc.Save(@"data/ProductList.xml");
                            return;
                        }
                        else
                        {
                            MusicCD temp = (MusicCD)product;
                            item.Element("Name").Value = temp.Name;
                            item.Element("Price").Value = temp.Price.ToString();
                            item.Element("Image").Value = UtilConvert.ImageToBase64(temp.Image, temp.Image.RawFormat);
                            item.Element("Singer").Value = temp.Singer;
                            item.Element("MusicCDType").Value = temp.Type.ToString();
                            xDoc.Save(@"data/ProductList.xml");
                            return;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// This function update elements of the MyOrders.xml file.
        /// </summary>
        /// <param name="shoppingCard">This parameter is a object of ShoppingCard class.</param>
        /// <returns> This function does not return a value </returns>
        public static void UpdateOrder(ShoppingCard shoppingCard)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"data/MyOrders.xml");
                XElement OrderRootElement = xDoc.Root;
                foreach (XElement order in OrderRootElement.Elements())
                {
                    if (order.Attribute("OrderID").Value == shoppingCard.OID.ToString())
                    {
                        order.Element("OrderStatus").Value = shoppingCard.Status.ToString();
                    }
                    xDoc.Save(@"data/MyOrders.xml");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// This function delete all of elements of the ShoppingCard.xml file.
        /// </summary>
        /// <param name="shoppingCard">This parameter is a object of ShoppingCard class.</param>
        /// <param name="index"> This parameter holds index of selected item.</param>
        /// <returns> This function does not return a value </returns>
        public static void Delete(ShoppingCard shoppingCard, int index)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"data/ShoppingCard.xml");
                XElement shoppingCardRootElement = xDoc.Root;
                foreach (XElement Card in shoppingCardRootElement.Elements())
                {
                    if (shoppingCard.CustomerID.ToString() == Card.FirstAttribute.Value)
                    {
                        double deletedAmount = shoppingCard.itemsToPurchase[index].Product.Price * shoppingCard.itemsToPurchase[index].Quantity;
                        Card.Element("PaymentAmount").Value = (shoppingCard.PaymentAmount - deletedAmount).ToString();
                        foreach (XElement item in Card.Element("ItemToPurchaseList").Elements())
                        {
                            if (item.Element("id").Value == shoppingCard.itemsToPurchase[index].Product.ID1)
                            {
                                item.Remove();
                                xDoc.Save(@"data/ShoppingCard.xml");
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// This function delete elements of the ShoppingCard.xml file.
        /// </summary>
        /// <param name="shoppingCard">This parameter is a object of ShoppingCard class.</param>
        /// <returns> This function does not return a value </returns>
        public static void Delete(ShoppingCard shoppingCard)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"data/ShoppingCard.xml");
                XElement shoppingCardRootElement = xDoc.Root;
                foreach (XElement Card in shoppingCardRootElement.Elements())
                {
                    if (shoppingCard.CustomerID.ToString() == Card.FirstAttribute.Value)
                    {
                        Card.Element("PaymentAmount").Value = "0";
                        Card.Element("PaymentType").Value = "cash";
                        Card.Element("ItemToPurchaseList").Remove();
                        XElement item = new XElement("ItemToPurchaseList");
                        Card.Add(item);
                        xDoc.Save(@"data/ShoppingCard.xml");
                        return;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// This function delete elements of the ProductList.xml file.
        /// </summary>
        /// <param name="product">This parameter is a object of Product class.</param>
        /// <returns> This function does not return a value </returns>
        public static void Delete(Product product)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"data/ProductList.xml");
                XElement rootElement = xDoc.Root;
                foreach (XElement item in rootElement.Elements())
                {
                    if (item.Attribute("ID").Value == product.ID1)
                    {
                        item.Remove();
                        xDoc.Save(@"data/ProductList.xml");
                        return;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
