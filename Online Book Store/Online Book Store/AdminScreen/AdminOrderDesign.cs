using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store.adminScreen
{
    public partial class AdminOrderDesign : UserControl
    {
        private ShoppingCard card;
        /// <summary>
        /// This function fill the user control from shopping cards.
        /// </summary>
        /// <param name="_card"></param>
        /// <returns>This function returns AdminOrderDesign</returns>
        public AdminOrderDesign(ShoppingCard _card)
        {
            InitializeComponent();
            this.card = _card;
            string customerName = "";
            foreach (Customer cst in OceanBookStore.customerList)
            {
                if (card.CustomerID == cst.CustomerId)
                {
                    customerName = cst.Name;
                    break;
                }
            }
            string payType = "";
            switch (card.Type)
            {
                case PaymentType.cash:
                    payType = "Cash";
                    break;
                case PaymentType.creditcard:
                    payType = "Credit Card";
                    break;
                case PaymentType.transfer:
                    payType = "Transfer/EFT";
                    break;
            }
            string status = "";
            switch (card.Status)
            {
                case OrderStatus.waitForShip:
                    status = "Waiting for ship";
                    break;
                case OrderStatus.shipped:
                    status = "Shipped";
                    break;
                case OrderStatus.received:
                    status = "Received";
                    break;
                case OrderStatus.canceled:
                    status = "Canceled";
                    break;
            }
            lbCustomer.Text += customerName;
            lbPaymentType.Text += payType;
            lbAmount.Text += card.PaymentAmount.ToString() + " ₺";
            lbStatus.Text += status;
        }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public ShoppingCard Card { get => card; set => card = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public String SetStatus { set => lbStatus.Text = value; }
        /// <summary>
        /// It shows details of orders.
        /// </summary>
        /// <returns> </returns>
        private void btnShow_Click(object sender, EventArgs e)
        {
            AdminOrderScreen.selectedIndex = this.card.OID - 1;
            MyOrders.selectedOrderID = this.card.OID;
        }
    }
}
