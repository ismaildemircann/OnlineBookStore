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
    * @brief   This file includes to book information.
    */
    public partial class BookScreen : Form
    {
        List<BookDesign> bookDesignList = new List<BookDesign>();
        public BookScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function used to add bookDesignList and controls.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void BookScreen_Load(object sender, EventArgs e)
        {
            foreach (Product product in StoreMainScreen.productList)
            {
                if (product is Book)
                {
                    BookDesign bookDesign = new BookDesign((Book)product);
                    bookDesignList.Add(bookDesign);
                    flpBookList.Controls.Add(bookDesign);
                }
            }
        }
        /// <summary>
        /// This function used to clear and add for bookDesignList and controls.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void flpBookList_VisibleChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "Search here";
            if (bookDesignList.Count > 0)
            {
                bookDesignList.Clear();
                flpBookList.Controls.Clear();
            }
            foreach (Product product in StoreMainScreen.productList)
            {
                if (product is Book)
                {
                    BookDesign bookDesign = new BookDesign((Book)product);
                    bookDesignList.Add(bookDesign);
                    flpBookList.Controls.Add(bookDesign);
                }
            }
        }
        /// <summary>
        /// This function used to hold the search text.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
        /// <summary>
        /// This function used to search product.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            flpBookList.Controls.Clear();
            if (txtSearch.Text == "")
                BookScreen_Load(sender, e);
            else
            {
                foreach (Product product in StoreMainScreen.productList)
                {
                    if (product is Book)
                    {
                        if (product.Name.ToUpper().Contains(txtSearch.Text.ToUpper()) || product.Name.ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            BookDesign bookDesign = new BookDesign((Book)product);
                            bookDesignList.Add(bookDesign);
                            flpBookList.Controls.Add(bookDesign);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// This function price range button click operation.
        /// This function is used to filter operation.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnPriceRange_Click(object sender, EventArgs e)
        {
            flpBookList.Controls.Clear();
            if (txtMinPrice.Text == "" || txtMaxPrice.Text == "")
            {
                MessageBox.Show("Please fill in the blanks. (min - max)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BookScreen_Load(sender, e);
                txtMaxPrice.Text = "";
                txtMinPrice.Text = "";
            }
            else
            {
                foreach (Product product in StoreMainScreen.productList)
                {
                    if (product is Book)
                    {
                        if (product.Price >= Int32.Parse(txtMinPrice.Text) && product.Price <= Int32.Parse(txtMaxPrice.Text))
                        {
                            BookDesign bookDesign = new BookDesign((Book)product);
                            bookDesignList.Add(bookDesign);
                            flpBookList.Controls.Add(bookDesign);
                        }
                    }
                }
            }
            if (flpBookList.Controls.Count == 0)
            {
                MessageBox.Show("There is no product in the range you are looking for.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BookScreen_Load(sender, e);
                txtMinPrice.Text = "";
                txtMaxPrice.Text = "";
            }
        }
    }
}
