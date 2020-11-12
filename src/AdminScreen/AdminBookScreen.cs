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
    * @brief   This file includes to admin book information.
    */
    public partial class AdminBookScreen : Form
    {
        private static int selectedIndex = -1;
        private static string selectedID;
        public AdminBookScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  This function used to add to listviews for book information.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void AdminBookScreen_Load(object sender, EventArgs e)
        {
            panelAddBook.Visible = false;
            listViewBooks.Columns.Add("ID", 50);
            listViewBooks.Columns.Add("Name", 100);
            listViewBooks.Columns.Add("Price", 50);
            listViewBooks.Columns.Add("ISBN1", 100);
            listViewBooks.Columns.Add("Author", 100);
            listViewBooks.Columns.Add("Publisher", 100);
            listViewBooks.Columns.Add("Pages", 50);
            ToListView();
        }
        /// <summary>
        /// This function holds the book information and create listview item.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void ToListView()
        {
            foreach (Product product in StoreMainScreen.productList)
            {
                if (product is Book)
                {
                    Book book = (Book)product;
                    string id = book.ID1;
                    string name = book.Name;
                    string price = book.Price.ToString();
                    string isbn = book.ISBN1;
                    string author = book.Author;
                    string publisher = book.Publisher;
                    string pages = book.Pages.ToString();
                    string[] stringItems = { id, name, price, isbn, author, publisher, pages };
                    ListViewItem item = new ListViewItem(stringItems);
                    listViewBooks.Items.Add(item);
                }
            }
        }
        /// <summary>
        /// This function add new book button click operation.
        /// This function is used to changed enabled.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            Logger.GetLogger().WriteLog(LoginedCustomer.getInstance().User.Username, btnAddNewBook.Text, DateTime.Now);
            panelAddBook.Visible = true;
            pboxBook.Image = null;
            txtName.Text = "";
            txtID.Text = "";
            txtPrice.Text = "";
            txtISBN.Text = "";
            txtAuthor.Text = "";
            txtPublisher.Text = "";
            txtPages.Text = "";
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            txtID.Enabled = true;
        }
        /// <summary>
        /// This function update selected book button click operation.
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
            panelAddBook.Visible = true;
            selectedID = listViewBooks.Items[selectedIndex].SubItems[0].Text;
            foreach (Product product in StoreMainScreen.productList)
            {
                if (product.ID1 == selectedID)
                {
                    Book book = (Book)product;
                    pboxBook.Image = book.Image;
                    txtName.Text = book.Name;
                    txtID.Text = book.ID1;
                    txtPrice.Text = book.Price.ToString();
                    txtISBN.Text = book.ISBN1;
                    txtAuthor.Text = book.Author;
                    txtPublisher.Text = book.Publisher;
                    txtPages.Text = book.Pages.ToString();
                }
            }
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            txtID.Enabled = false;
        }
        /// <summary>
        /// This function add book button click operation.
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
            else if (pboxBook.Image == null)
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
            Creator c = new BookFactory(txtName.Text, txtID.Text, Convert.ToDouble(txtPrice.Text,provider), txtISBN.Text, txtAuthor.Text,
                txtPublisher.Text, Convert.ToInt32(txtPages.Text), pboxBook.Image);
            string[] lvItem = {txtID.Text, txtName.Text, txtPrice.Text, txtISBN.Text, txtAuthor.Text, txtPublisher.Text,txtPages.Text};
            ListViewItem item = new ListViewItem(lvItem);
            listViewBooks.Items.Add(item);
            StoreMainScreen.productList.Add(c.FactoryMethod());
            UtilSave.Save(c.FactoryMethod());
            MessageBox.Show("Added succesfully!");
            listViewBooks.Refresh();
            panelAddBook.Visible = false;
        }
        /// <summary>
        /// This function used to control book information.
        /// </summary>
        /// <returns>if text box are not null ,return true</returns>
        private bool isBlank()
        {
            if (txtName.Text == "" || txtID.Text == "" || txtPrice.Text == "" || txtISBN.Text == "" ||
                txtAuthor.Text == "" || txtPublisher.Text == "" || txtPages.Text == "")
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// This function used to select image.
        /// </summary>
        /// <returns>if text box are not null ,return true</returns>
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
                pboxBook.Image = (Image)image;
            }
        }
        /// <summary>
        /// This function used to control for id.
        /// </summary>
        /// <returns>if text box are not null ,return true</returns>
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
        /// <returns>if text box are not null ,return true</returns>
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
        /// This function used to control for pages number.
        /// </summary>
        /// <returns>if text box are not null ,return true</returns>
        private void txtPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// This function used to hold selected index.
        /// </summary>
        /// <returns>if text box are not null ,return true</returns>
        private void listViewBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = listViewBooks.FocusedItem.Index;
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
        /// This function update book button click operation.
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
            else if (pboxBook.Image == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            Creator c = new BookFactory(txtName.Text, txtID.Text, Convert.ToDouble(txtPrice.Text, provider), txtISBN.Text, txtAuthor.Text,
                txtPublisher.Text, Convert.ToInt32(txtPages.Text), pboxBook.Image);
            string[] lvItem = { txtID.Text, txtName.Text, txtPrice.Text, txtISBN.Text, txtAuthor.Text, txtPublisher.Text, txtPages.Text };
            ListViewItem item = new ListViewItem(lvItem);
            for (int i = 0; i < listViewBooks.Items.Count; i++)
            {
                if (listViewBooks.Items[i].SubItems[0].Text == selectedID)
                {
                    listViewBooks.Items[i] = item;
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
            panelAddBook.Visible = false;
            selectedIndex = -1;
        }
        /// <summary>
        /// This function delete book button click operation.
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
            selectedID = listViewBooks.Items[selectedIndex].SubItems[0].Text;
            for (int i = 0; i < listViewBooks.Items.Count; i++)
            {
                if (listViewBooks.Items[i].SubItems[0].Text == selectedID)
                {
                    listViewBooks.Items.RemoveAt(i);
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
