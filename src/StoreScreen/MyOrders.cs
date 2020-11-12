using Online_Book_Store.adminScreen;
using Online_Book_Store.logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store
{
    /**   
    * @brief    This file includes order operations.
    */
    public partial class MyOrders : Form
    {
        List<AdminOrderDesign> designs = new List<AdminOrderDesign>();
        public static int selectedOrderID;
        private int selectedIndex;
        /// <summary>
        /// This function is Constructor.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        public MyOrders()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function loads the MyOrders design.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void MyOrders_Load(object sender, EventArgs e)
        {
            foreach (ShoppingCard card in StoreMainScreen.orderList)
            {
                if(card.CustomerID == LoginedCustomer.getInstance().User.CustomerId)
                {
                    AdminOrderDesign design = new AdminOrderDesign(card);
                    designs.Add(design);
                    design.btnShow.Click += BtnShow_Click;
                    flpOrders.Controls.Add(design);
                }
            }
        }
        /// <summary>
        /// This function includes show button click operation and changed the buttons' enable.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (flpItems.Controls.Count > 0)
                flpItems.Controls.Clear();
            int i = 0;
            foreach (AdminOrderDesign design in designs)
            {
                if (selectedOrderID == design.Card.OID)
                {
                    selectedIndex = i;
                    break;
                }
                i++;
            }
            foreach (ItemToPurchase item in designs[selectedIndex].Card.itemsToPurchase)
            {
                MyOrdersDesign product = new MyOrdersDesign(item);
                flpItems.Controls.Add(product);
            }
            panelBottom.Visible = true;
            if (designs[selectedIndex].Card.Status == OrderStatus.waitForShip)
            {
                btnCancel.Enabled = true;
                btnReceive.Enabled = false;
            }
            else if(designs[selectedIndex].Card.Status == OrderStatus.shipped)
            {
                btnCancel.Enabled = true;
                btnReceive.Enabled = true;
            }
            else
            {
                btnCancel.Enabled = false;
                btnReceive.Enabled = false;
            }
        }
        /// <summary>
        /// This function includes receive button click operation.
        /// This function changed the order status and buttons' enable.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnReceive_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnReceive.Text, DateTime.Now);
            DialogResult dr = MessageBox.Show("Are you sure?", "Information",
    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Cancel)
                return;
            designs[selectedIndex].Card.Status = OrderStatus.received;
            designs[selectedIndex].SetStatus = "Status: Received";
            foreach (ShoppingCard order in StoreMainScreen.orderList)
            {
                if (order.OID == designs[selectedIndex].Card.OID)
                {
                    order.Status = OrderStatus.received;
                    UtilUpdate.UpdateOrder(order);
                }
            }
            flpOrders.Refresh();
            btnCancel.Enabled = false;
            btnReceive.Enabled = false;
        }
        /// <summary>
        /// This function includes cancel button click operation. 
        /// This function changed the order status and buttons' enable.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnCancel.Text, DateTime.Now);
            DialogResult dr = MessageBox.Show("Are you sure?", "Information",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Cancel)
                return;
            designs[selectedIndex].Card.Status = OrderStatus.canceled;
            designs[selectedIndex].SetStatus = "Status: Canceled";
            foreach (ShoppingCard order in StoreMainScreen.orderList)
            {
                if (order.OID == designs[selectedIndex].Card.OID)
                {
                    order.Status = OrderStatus.canceled;
                    UtilUpdate.UpdateOrder(order);
                }
            }
            flpOrders.Refresh();
            btnCancel.Enabled = false;
            btnReceive.Enabled = false;
        }
        /// <summary>
        /// This function includes visible changed operation for my orders.
        /// This function clear controls and design.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void MyOrders_VisibleChanged(object sender, EventArgs e)
        {
            flpOrders.Controls.Clear();
            flpItems.Controls.Clear();
            panelBottom.Visible = false;
            designs.Clear();
            foreach (ShoppingCard card in StoreMainScreen.orderList)
            {
                if (card.CustomerID == LoginedCustomer.getInstance().User.CustomerId)
                {
                    AdminOrderDesign design = new AdminOrderDesign(card);
                    designs.Add(design);
                    design.btnShow.Click += BtnShow_Click;
                    flpOrders.Controls.Add(design);
                }
            }
        }
    }
}
