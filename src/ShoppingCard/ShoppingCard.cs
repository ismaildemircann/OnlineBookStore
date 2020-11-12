using Online_Book_Store.shoppingCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.codec;
using System.IO;
using Online_Book_Store.Properties;
using System.Windows.Forms;
using System.Net.Mail;
using System.Drawing;

namespace Online_Book_Store
{
    /**   
     * @brief    This file includes shopping card operations .
     */
    public enum PaymentType { cash, creditcard, transfer }
    public enum OrderStatus { waitForShip, shipped, received, canceled }
    public class ShoppingCard
    {
        public List<ItemToPurchase> itemsToPurchase;
        ShoppingCard temp;
        private string customerID;
        private double paymentAmount = 0;
        private PaymentType paymentType;
        private OrderStatus status;
        private int cargoAmount;
        private int oID;
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public PaymentType Type { get => paymentType; set => paymentType = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string CustomerID { get => customerID; set => customerID = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public double PaymentAmount { get => paymentAmount; set => paymentAmount = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public OrderStatus Status { get => status; set => status = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public int CargoAmount { get => cargoAmount; set => cargoAmount = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public int OID { get => oID; set => oID = value; }
        /// <summary>
        /// This function is Constructor and create new ItemToPurchase list.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        public ShoppingCard()
        {
            itemsToPurchase = new List<ItemToPurchase>();
        }
        /// <summary>
        /// This function used to add product in item to purchase and to calculate the payment amount.
        /// </summary>
        /// <param name="item">This parameter is a object of ItemToPurchase class.</param>
        /// <returns> This function does not return a value </returns>
        public void AddProduct(ItemToPurchase item)
        {
            itemsToPurchase.Add(item);
            PaymentAmount += (item.Product.Price * item.Quantity);
        }
        /// <summary>
        /// This function used to remove product in item to purchase and to calculate the payment amount.
        /// </summary>
        /// <param name="item">This parameter is a object of ItemToPurchase class.</param>
        /// <returns> This function does not return a value </returns>
        public void RemoveProduct(ItemToPurchase item)
        {
            for (int i = 0; i < itemsToPurchase.Count(); i++)
            {
                if (itemsToPurchase[i] == item)
                {
                    paymentAmount -= (item.Product.Price * item.Quantity);
                    itemsToPurchase.Remove(item);
                }
            }
        }
        /// <summary>
        /// This function used to clear itemstopurchase and the payment amount value is reset.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        public void CancelOrder()
        {
            itemsToPurchase.Clear();
            paymentAmount = 0.0;
        }
        /// <summary>
        /// This function used to call order operations.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        public void PlaceOrder()
        {
            temp = this;
            temp.Status = OrderStatus.waitForShip;
            temp.Type = Invoice.pType;
            temp.cargoAmount = Invoice.cargoAmount;
            temp.PaymentAmount = Invoice.totalPrice;
            temp.OID = StoreMainScreen.orderList.Count + 1;
            StoreMainScreen.orderList.Add(temp);
            UtilSave.SaveOrder(temp);
            string pdfFilePath = CreatePDF();
            SendMail(pdfFilePath);
            itemsToPurchase.Clear();
            paymentAmount = 0.0;
            StoreMainScreen.orderList.Clear();
            UtilLoad.LoadOrder(StoreMainScreen.orderList);
        }
        /// <summary>
        /// This function used to sent email.
        /// </summary>
        /// <param name="pdfFilePath">the pdfFilePath string hold the pdf path.</param>
        /// <returns> This function does not return a value </returns>
        private void SendMail(string pdfFilePath)
        {
            string message = "Hi Dear " + LoginedCustomer.getInstance().User.Username + "," + Environment.NewLine
                + "We received your order. It will be shipped as soon as possible." + Environment.NewLine
                + "Thank you for choosing Ocean Store!" + Environment.NewLine + "Your Sincerely," + Environment.NewLine + "Ocean Store Team";
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("oceanbookstore2020@gmail.com");
                mail.To.Add(LoginedCustomer.getInstance().User.Email);
                mail.Subject = "#" + temp.OID.ToString() + " Order Invoice";
                Attachment attachment;
                attachment = new Attachment(pdfFilePath);
                attachment.Name = LoginedCustomer.getInstance().User.Username +  temp.CustomerID.ToString() + temp.OID.ToString() + ".pdf";
                mail.Attachments.Add(attachment);
                mail.Body = message;
                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("oceanbookstore2020@gmail.com", "fgjuzkjfdwihovpb");
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);
            }
            catch
            {
                MessageBox.Show("Something went wrong!");
            }
        }
        /// <summary>
        /// This function used to create pdf.
        /// </summary>
        /// <returns>Return the pdf file path </returns>
        private string CreatePDF()
        {
            var document = new Document(PageSize.A4, 40f, 40f, 80f, 80f);
            string path = @"pdfFiles/" + temp.CustomerID.ToString() + temp.OID.ToString() + ".pdf";
            PdfWriter.GetInstance(document, new FileStream(path, FileMode.OpenOrCreate));
            document.Open();
            var logo = iTextSharp.text.Image.GetInstance(Resources.banner, Resources.banner.RawFormat);
            logo.ScalePercent(35f);
            logo.SetAbsolutePosition(document.Left, document.Top);
            document.Add(logo);
            Paragraph spacer = new Paragraph("")
            {
                SpacingBefore = 10f,
                SpacingAfter = 10f
            };
            document.Add(spacer);
            PdfPTable table = new PdfPTable(new[] { .75f, 2f })
            {
                HorizontalAlignment = 0,
                WidthPercentage = 75,
                DefaultCell = { MinimumHeight = 22f }
            };
            table.AddCell("Date");
            table.AddCell(DateTime.Now.ToString());
            table.AddCell("Username");
            table.AddCell(LoginedCustomer.getInstance().User.Username);
            table.AddCell("Order ID");
            table.AddCell(temp.OID.ToString());
            table.AddCell("Cargo Amount");
            table.AddCell(temp.CargoAmount.ToString());
            table.AddCell("Payment Amount");
            table.AddCell(temp.PaymentAmount.ToString());
            document.Add(table);
            document.Add(spacer);
            var columnWidths = new[] { .5f, 1f, 2f, .5f, 1f };
            PdfPTable itemTable = new PdfPTable(columnWidths)
            {
                HorizontalAlignment = 0,
                WidthPercentage = 100
            };
            itemTable.DefaultCell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            itemTable.DefaultCell.MinimumHeight = 22f;
            itemTable.AddCell("Image");
            itemTable.AddCell("ID");
            itemTable.AddCell("Name");
            itemTable.AddCell("Quantity");
            itemTable.AddCell("Total Price");
            foreach (ItemToPurchase item in temp.itemsToPurchase)
            {
                Bitmap temp = new Bitmap(item.Product.Image);
                var image = iTextSharp.text.Image.GetInstance(temp, item.Product.Image.RawFormat);
                image.ScalePercent(2f);
                itemTable.AddCell(image);
                itemTable.AddCell(item.Product.ID1);
                itemTable.AddCell(item.Product.Name);
                itemTable.AddCell(item.Quantity.ToString());
                itemTable.AddCell((item.Product.Price * item.Quantity).ToString());
            }
            document.Add(itemTable);
            document.Close();
            return path;
        }
    }
}
