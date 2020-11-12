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
    * @brief   This file includes to admin MusicCd information.
    */
    public partial class AdminMusicCDScreen : Form
    {
        private static int selectedIndex = -1;
        private static string selectedID;
        public AdminMusicCDScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  This function used to add to listviews for MusicCD information.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void AdminMusicCDScreen_Load(object sender, EventArgs e)
        {
            panelAddMusicCD.Visible = false;
            listViewMusicCDs.Columns.Add("ID", 50);
            listViewMusicCDs.Columns.Add("Name", 100);
            listViewMusicCDs.Columns.Add("Price", 50);
            listViewMusicCDs.Columns.Add("Singer", 100);
            listViewMusicCDs.Columns.Add("Type", 100);
            ToListView();
        }
        /// <summary>
        /// This function holds the music cd information and create listview item.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void ToListView()
        {
            foreach (Product product in StoreMainScreen.productList)
            {
                if (product is MusicCD)
                {
                    MusicCD musicCD = (MusicCD)product;
                    string id = musicCD.ID1;
                    string name = musicCD.Name;
                    string price = musicCD.Price.ToString();
                    string singer = musicCD.Singer;
                    string type = musicCD.Type.ToString();
                    string[] stringItems = { id, name, price, singer, type };
                    ListViewItem item = new ListViewItem(stringItems);
                    listViewMusicCDs.Items.Add(item);
                }
            }
        }
        /// <summary>
        /// This function add new music cd button click operation.
        /// This function is used to changed enabled.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnAddNewMusicCD_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnAddNewMusicCD.Text, DateTime.Now);
            panelAddMusicCD.Visible = true;
            pboxMusicCD.Image = null;
            txtName.Text = "";
            txtID.Text = "";
            txtPrice.Text = "";
            txtSinger.Text = "";
            cBoxType.Text = "";
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            txtID.Enabled = true;
        }
        /// <summary>
        /// This function update selected music cd button click operation.
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
            panelAddMusicCD.Visible = true;
            selectedID = listViewMusicCDs.Items[selectedIndex].SubItems[0].Text;
            foreach (Product product in StoreMainScreen.productList)
            {
                if (product.ID1 == selectedID)
                {
                    MusicCD musicCD = (MusicCD)product;
                    pboxMusicCD.Image = musicCD.Image;
                    txtName.Text = musicCD.Name;
                    txtID.Text = musicCD.ID1;
                    txtPrice.Text = musicCD.Price.ToString();
                    txtSinger.Text = musicCD.Singer;
                    switch (musicCD.Type)
                    {
                        case MusicCD_Type.Romance:
                            cBoxType.SelectedIndex = 0;
                            break;
                        case MusicCD_Type.HardRock:
                            cBoxType.SelectedIndex = 1;
                            break;
                        case MusicCD_Type.Country:
                            cBoxType.SelectedIndex = 2;
                            break;
                        default:
                            break;
                    }
                }
            }
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            txtID.Enabled = false;
        }
        /// <summary>
        /// This function add music cd button click operation.
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
            else if (pboxMusicCD.Image == null)
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
            MusicCD_Type type = MusicCD_Type.Romance;
            switch (cBoxType.SelectedIndex)
            {
                case 1:
                    type = MusicCD_Type.HardRock;
                    break;
                case 2:
                    type = MusicCD_Type.Country;
                    break;
                default:
                    break;
            }
            Creator c = new MusicCdFactory(txtName.Text, txtID.Text, Convert.ToDouble(txtPrice.Text, provider),
                txtSinger.Text, type, pboxMusicCD.Image);
            string[] lvItem = { txtID.Text, txtName.Text, txtPrice.Text, txtSinger.Text, cBoxType.Text };
            ListViewItem item = new ListViewItem(lvItem);
            listViewMusicCDs.Items.Add(item);
            StoreMainScreen.productList.Add(c.FactoryMethod());
            UtilSave.Save(c.FactoryMethod());
            MessageBox.Show("Added succesfully!");
            listViewMusicCDs.Refresh();
            panelAddMusicCD.Visible = false;
        }
        /// <summary>
        /// This function used to control music cd information.
        /// </summary>
        /// <returns>if text box are not null ,return true</returns>
        private bool isBlank()
        {
            if (txtName.Text == "" || txtID.Text == "" || txtPrice.Text == "" || txtSinger.Text == "" || cBoxType.Text == "")
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
                pboxMusicCD.Image = (Image)image;
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
        private void listViewMusicCDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = listViewMusicCDs.FocusedItem.Index;
        }
        /// <summary>
        /// This function update music cd button click operation.
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
            else if (pboxMusicCD.Image == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            MusicCD_Type type = MusicCD_Type.Romance;
            switch (cBoxType.SelectedIndex)
            {
                case 1:
                    type = MusicCD_Type.HardRock;
                    break;
                case 2:
                    type = MusicCD_Type.Country;
                    break;
                default:
                    break;
            }
            Creator c = new MusicCdFactory(txtName.Text, txtID.Text, Convert.ToDouble(txtPrice.Text, provider),
                txtSinger.Text,type,pboxMusicCD.Image);
            string[] lvItem = { txtID.Text, txtName.Text, txtPrice.Text, txtSinger.Text, cBoxType.Text };
            ListViewItem item = new ListViewItem(lvItem);
            for (int i = 0; i < listViewMusicCDs.Items.Count; i++)
            {
                if (listViewMusicCDs.Items[i].SubItems[0].Text == selectedID)
                {
                    listViewMusicCDs.Items[i] = item;
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
            panelAddMusicCD.Visible = false;
            selectedIndex = -1;
        }
        /// <summary>
        /// This function delete music cd button click operation.
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
            selectedID = listViewMusicCDs.Items[selectedIndex].SubItems[0].Text;
            for (int i = 0; i < listViewMusicCDs.Items.Count; i++)
            {
                if (listViewMusicCDs.Items[i].SubItems[0].Text == selectedID)
                {
                    listViewMusicCDs.Items.RemoveAt(i);
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
