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
    * @brief   This file includes to magazine information.
    */
    public partial class MagazineScreen : Form
    {
        private List<MagazinDesign> magazineDesigns = new List<MagazinDesign>();
        public MagazineScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function used to add magazineDesign and controls.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void MagazineScreen_Load(object sender, EventArgs e)
        {
            foreach (Product product in StoreMainScreen.productList)
            {
                if (product is Magazine)
                {
                    MagazinDesign magazineDesign = new MagazinDesign((Magazine)product);
                    magazineDesigns.Add(magazineDesign);
                    flpMagazinList.Controls.Add(magazineDesign);
                }
            }
        }
        /// <summary>
        /// This function used to clear and add for magazineDesign and controls.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void flpMagazinList_VisibleChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "Search here";
            if (magazineDesigns.Count > 0) 
            {
                magazineDesigns.Clear();
                flpMagazinList.Controls.Clear();
            }
            foreach (Product product in StoreMainScreen.productList)
            {
                if (product is Magazine)
                {
                    MagazinDesign magazineDesign = new MagazinDesign((Magazine)product);
                    magazineDesigns.Add(magazineDesign);
                    flpMagazinList.Controls.Add(magazineDesign);
                }
            }
        }
        /// <summary>
        /// This function used to search product.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            flpMagazinList.Controls.Clear();
            if (txtSearch.Text == "")
                MagazineScreen_Load(sender, e);
            else
            {
                foreach (Product product in StoreMainScreen.productList)
                {
                    if (product is Magazine)
                    {
                        if (product.Name.ToUpper().Contains(txtSearch.Text.ToUpper()) || product.Name.ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            MagazinDesign magazineDesign = new MagazinDesign((Magazine)product);
                            magazineDesigns.Add(magazineDesign);
                            flpMagazinList.Controls.Add(magazineDesign);
                        }
                    }
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
        /// This function price range button click operation.
        /// This function is used to filter operation.
        /// </summary>
        /// <returns> This function does not return a value  </returns>
        private void btnPriceRange_Click(object sender, EventArgs e)
        {
            flpMagazinList.Controls.Clear();
            if (txtMinPrice.Text == "" || txtMaxPrice.Text == "")
            {
                MessageBox.Show("Please fill in the blanks. (min - max)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MagazineScreen_Load(sender, e);
                txtMaxPrice.Text = "";
                txtMinPrice.Text = "";
            }
            else
            {
                foreach (Product product in StoreMainScreen.productList)
                {
                    if (product is Magazine)
                    {
                        if (product.Price >= Int32.Parse(txtMinPrice.Text) && product.Price <= Int32.Parse(txtMaxPrice.Text))
                        {
                            MagazinDesign magazineDesing = new MagazinDesign((Magazine)product);
                            magazineDesigns.Add(magazineDesing);
                            flpMagazinList.Controls.Add(magazineDesing);
                        }
                    }
                }
            }
            if (flpMagazinList.Controls.Count == 0)
            {
                MessageBox.Show("There is no product in the range you are looking for.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MagazineScreen_Load(sender, e);
                txtMinPrice.Text = "";
                txtMaxPrice.Text = "";
            }
        }
    }
}
