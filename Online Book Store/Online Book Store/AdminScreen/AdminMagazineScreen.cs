using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Book_Store.logger;

namespace Online_Book_Store
{
    /**
    * @brief   This file includes to admin Magazine information.
    */
    public partial class AdminMagazineScreen : Form
    {
        private static int selectedIndex = -1;
        private static string selectedID;
        public AdminMagazineScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  This function used to add to listviews for magazine information.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void AdminMagazineScreen_Load(object sender, EventArgs e)
        {
            panelAddMagazine.Visible = false;
            listViewMagazines.Columns.Add("ID", 50);
            listViewMagazines.Columns.Add("Name", 100);
            listViewMagazines.Columns.Add("Price", 50);
            listViewMagazines.Columns.Add("Issue", 100);
            listViewMagazines.Columns.Add("Type", 100);
            ToListView();
        }
        /// <summary>
        /// This function holds the magazine information and create listview item.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void ToListView()
        {
            foreach (Product product in StoreMainScreen.productList)
            {
                if (product is Magazine)
                {
                    Magazine magazine = (Magazine)product;
                    string id = magazine.ID1;
                    string name = magazine.Name;
                    string price = magazine.Price.ToString();
                    string issue = magazine.Issue;
                    string type = magazine.Type.ToString();
                    string[] stringItems = { id, name, price, issue, type };
                    ListViewItem item = new ListViewItem(stringItems);
                    listViewMagazines.Items.Add(item);
                }
            }
        }
        /// <summary>
        /// This function add new magazine button click operation.
        /// This function is used to changed enabled.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnAddNewMagazine_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnAddNewMagazine.Text, DateTime.Now);
            panelAddMagazine.Visible = true;
            pboxMagazine.Image = null;
            txtName.Text = "";
            txtID.Text = "";
            txtPrice.Text = "";
            txtIssue.Text = "";
            cBoxType.Text = "";
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            txtID.Enabled = true;
        }
        /// <summary>
        /// This function update selected magazine button click operation.
        /// This function is used to changed enabled.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnUpdateSelected.Text, DateTime.Now);
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a book from list!");
                return;
            }
            panelAddMagazine.Visible = true;
            selectedID = listViewMagazines.Items[selectedIndex].SubItems[0].Text;
            foreach (Product product in StoreMainScreen.productList)
            {
                if (product.ID1 == selectedID)
                {
                    Magazine magazine = (Magazine)product;
                    pboxMagazine.Image = magazine.Image;
                    txtName.Text = magazine.Name;
                    txtID.Text = magazine.ID1;
                    txtPrice.Text = magazine.Price.ToString();
                    txtIssue.Text = magazine.Issue;
                    switch (magazine.Type)
                    {
                        case Magazine_Type.Actual:
                            cBoxType.SelectedIndex = 0;
                            break;
                        case Magazine_Type.Computer:
                            cBoxType.SelectedIndex = 1;
                            break;
                        case Magazine_Type.News:
                            cBoxType.SelectedIndex = 2;
                            break;
                        case Magazine_Type.Sport:
                            cBoxType.SelectedIndex = 3;
                            break;
                        case Magazine_Type.Technology:
                            cBoxType.SelectedIndex = 4;
                            break;
                    }
                    break;
                }
            }
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            txtID.Enabled = false;
        }
        /// <summary>
        /// This function add magazine button click operation.
        /// This function is used to add product list and save for util function.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnAdd.Text, DateTime.Now);
            if (!isBlank())
            {
                MessageBox.Show("Please fill all blanks!");
                return;
            }
            else if (pboxMagazine.Image == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }
            else if (isExist())
            {
                MessageBox.Show("Please change product ID! It's already taken.");
                return;
            }
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            Magazine_Type type = Magazine_Type.Actual;
            switch (cBoxType.SelectedIndex)
            {
                case 1:
                    type = Magazine_Type.Computer;
                    break;
                case 2:
                    type = Magazine_Type.News;
                    break;
                case 3:
                    type = Magazine_Type.Sport;
                    break;
                case 4:
                    type = Magazine_Type.Technology;
                    break;
                default:
                    break;
            }
            Creator c = new MagazineFactory(txtName.Text, txtID.Text, Convert.ToDouble(txtPrice.Text, provider), 
                txtIssue.Text, type, pboxMagazine.Image);
            string[] lvItem = { txtID.Text, txtName.Text, txtPrice.Text, txtIssue.Text, cBoxType.Text };
            ListViewItem item = new ListViewItem(lvItem);
            listViewMagazines.Items.Add(item);
            StoreMainScreen.productList.Add(c.FactoryMethod());
            UtilSave.Save(c.FactoryMethod());
            MessageBox.Show("Added succesfully!");
            listViewMagazines.Refresh();
            panelAddMagazine.Visible = false;
        }
        /// <summary>
        /// This function used to control magazine information.
        /// </summary>
        /// <returns>if text box are not null ,return true</returns>
        private bool isBlank()
        {
            if (txtName.Text == "" || txtID.Text == "" || txtPrice.Text == "" || txtIssue.Text == "" || cBoxType.Text == "")
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// This function used to control exist product.
        /// </summary>
        /// <returns>if product id and textbox id is equal ,return true</returns>
        private bool isExist()
        {
            foreach (Product product in StoreMainScreen.productList)
            {
                if (product.ID1 == txtID.Text)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// This function used to select image.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnSelectImage.Text, DateTime.Now);
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG" +
            "|All files(*.*)|*.*";
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(dialog.FileName);
                pboxMagazine.Image = (Image)image;
            }
        }
        /// <summary>
        /// This function used to control for id.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// This function used to control for price.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            if ((e.KeyChar == '.' && txtPrice.Text.Contains(".")) || (e.KeyChar == '.' && txtPrice.Text == ""))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// This function used to hold selected index.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void listViewMagazines_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = listViewMagazines.FocusedItem.Index;
        }
        /// <summary>
        /// This function update magazine button click operation.
        /// This function is used to update product list and update for util function.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnUpdate.Text, DateTime.Now);
            if (!isBlank())
            {
                MessageBox.Show("Please fill all blanks!");
                return;
            }
            else if (pboxMagazine.Image == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            Magazine_Type type = Magazine_Type.Actual;
            switch (cBoxType.SelectedIndex)
            {
                case 1:
                    type = Magazine_Type.Computer;
                    break;
                case 2:
                    type = Magazine_Type.News;
                    break;
                case 3:
                    type = Magazine_Type.Sport;
                    break;
                case 4:
                    type = Magazine_Type.Technology;
                    break;
                default:
                    break;
            }
            Creator c = new MagazineFactory(txtName.Text, txtID.Text, Convert.ToDouble(txtPrice.Text, provider), 
                txtIssue.Text, type, pboxMagazine.Image);
            string[] lvItem = { txtID.Text, txtName.Text, txtPrice.Text, txtIssue.Text, cBoxType.Text };
            ListViewItem item = new ListViewItem(lvItem);
            for (int i = 0; i < listViewMagazines.Items.Count; i++)
            {
                if (listViewMagazines.Items[i].SubItems[0].Text == selectedID)
                {
                    listViewMagazines.Items[i] = item;
                    break;
                }
            }
            for (int i = 0; i < StoreMainScreen.productList.Count; i++)
            {
                if (StoreMainScreen.productList[i].ID1 == selectedID)
                {
                    StoreMainScreen.productList[i] = c.FactoryMethod();
                    break;
                }
            }
            UtilUpdate.Update(c.FactoryMethod());
            MessageBox.Show("Updated Succesfully!");
            panelAddMagazine.Visible = false;
            selectedIndex = -1;
        }
        /// <summary>
        /// This function delete magazine button click operation.
        /// This function is used to remove product list and delete for util function.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnDelete.Text, DateTime.Now);
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a book from list!");
                return;
            }
            selectedID = listViewMagazines.Items[selectedIndex].SubItems[0].Text;
            for (int i = 0; i < listViewMagazines.Items.Count; i++)
            {
                if (listViewMagazines.Items[i].SubItems[0].Text == selectedID)
                {
                    listViewMagazines.Items.RemoveAt(i);
                    break;
                }
            }
            for (int i = 0; i < StoreMainScreen.productList.Count; i++)
            {
                if (StoreMainScreen.productList[i].ID1 == selectedID)
                {
                    UtilUpdate.Delete(StoreMainScreen.productList[i]);
                    StoreMainScreen.productList.RemoveAt(i);
                    break;
                }
            }
            MessageBox.Show("Deleted Succesfully!");
            selectedIndex = -1;
        }
    }
}
