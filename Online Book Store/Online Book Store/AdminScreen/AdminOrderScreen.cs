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

namespace Online_Book_Store.adminScreen
{
    public partial class AdminOrderScreen : Form
    {
        List<AdminOrderDesign> designs = new List<AdminOrderDesign>();
        public static int selectedIndex;
        public AdminOrderScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// UserControl object created and it was added to flow layout panel.
        /// </summary>
        /// <returns> This function does not return a value</returns>
        private void AdminOrderScreen_Load(object sender, EventArgs e)
        {
            foreach (ShoppingCard card in StoreMainScreen.orderList)
            {
                AdminOrderDesign design = new AdminOrderDesign(card);
                designs.Add(design);
                design.btnShow.Click += BtnShow_Click;
                flpOrders.Controls.Add(design);
            }
        }
        /// <summary>
        /// It shows details of orders.
        /// </summary>
        /// <returns> This function does not return a value</returns>
        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (flpItems.Controls.Count > 0)
                flpItems.Controls.Clear();
            foreach (ItemToPurchase item in designs[selectedIndex].Card.itemsToPurchase)
            {
                MyOrdersDesign product = new MyOrdersDesign(item);
                flpItems.Controls.Add(product);
            }
            panelBottom.Visible = true;
            if (designs[selectedIndex].Card.Status == OrderStatus.waitForShip)
            {
                btnCancel.Enabled = true;
                btnShip.Enabled = true;
            }
            else
            {
                btnCancel.Enabled = false;
                btnShip.Enabled = false;
            }
        }
        /// <summary>
        /// It cancels the order.
        /// </summary>
        /// <returns> This function does not return a value</returns>
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
            btnShip.Enabled = false;
        }
        /// <summary>
        /// It uses for order's status for shipped.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShip_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnShip.Text, DateTime.Now);
            DialogResult dr = MessageBox.Show("Are you sure?", "Information",
    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Cancel)
                return;
            designs[selectedIndex].Card.Status = OrderStatus.shipped;
            designs[selectedIndex].SetStatus = "Status: Shipped";
            foreach (ShoppingCard order in StoreMainScreen.orderList)
            {
                if (order.OID == designs[selectedIndex].Card.OID)
                {
                    order.Status = OrderStatus.shipped;
                    UtilUpdate.UpdateOrder(order);
                }
            }
            flpOrders.Refresh();
            btnCancel.Enabled = false;
            btnShip.Enabled = false;
        }
    }
}
