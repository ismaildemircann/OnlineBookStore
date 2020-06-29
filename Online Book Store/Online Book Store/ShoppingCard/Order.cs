using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store.shoppingCard
{
    public enum OrderStatus
    {
        waitForShip,
        shipped,
        received,
        canceled
    }
    public enum paymentType
    {
        cash,
        creditCard,
        transfer
    }
    public class Order
    {
        private string userID;
        private int orderID;
        private double totalPrice;
        private int cargoPrice;
        private List<ItemToPurchase> items = new List<ItemToPurchase>();
        private OrderStatus status;

        public string UserID { get => userID; set => userID = value; }
        public int OrderID { get => orderID; set => orderID = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public List<ItemToPurchase> GetSetItems { get => items; set => items = value; }
        public OrderStatus Status { get => status; set => status = value; }
        public int CargoPrice { get => cargoPrice; set => cargoPrice = value; }

    }
}
