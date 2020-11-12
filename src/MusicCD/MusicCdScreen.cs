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
    * @brief    This file includes MusicCd form.
    */
    public partial class MusicCdScreen : Form
    {
        List<MusicCdDesign> musicCdDesignsList = new List<MusicCdDesign>();

        public MusicCdScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function used to add musicCdDesign list and controls.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void MusicCdScreen_Load(object sender, EventArgs e)
        {
            foreach (Product product in StoreMainScreen.productList)
            {
                if(product is MusicCD)
                {
                    MusicCdDesign musicCdDesign = new MusicCdDesign((MusicCD)product);
                    musicCdDesignsList.Add(musicCdDesign);
                    flpMusicCdList.Controls.Add(musicCdDesign);
                }
            }
        }
        /// <summary>
        /// This function used to clear and add for musicCdDesign list and controls.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void flpMusicCdList_VisibleChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "Search here";
            if (musicCdDesignsList.Count > 0)
            {
                musicCdDesignsList.Clear();
                flpMusicCdList.Controls.Clear();
            }
            foreach (Product product in StoreMainScreen.productList)
            {
                if (product is MusicCD)
                {
                    MusicCdDesign musicCdDesign = new MusicCdDesign((MusicCD)product);
                    musicCdDesignsList.Add(musicCdDesign);
                    flpMusicCdList.Controls.Add(musicCdDesign);
                }
            }
        }
        /// <summary>
        /// This function used to search product.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            flpMusicCdList.Controls.Clear();
            if (txtSearch.Text == "")
                MusicCdScreen_Load(sender, e);
            else
            {
                foreach (Product product in StoreMainScreen.productList)
                {
                    if (product is MusicCD)
                    {
                        if (product.Name.ToUpper().Contains(txtSearch.Text.ToUpper()) || product.Name.ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            MusicCdDesign musicCdDesign = new MusicCdDesign((MusicCD)product);
                            musicCdDesignsList.Add(musicCdDesign);
                            flpMusicCdList.Controls.Add(musicCdDesign);
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
            flpMusicCdList.Controls.Clear();
            if (txtMinPrice.Text == "" || txtMaxPrice.Text == "")
            {
                MessageBox.Show("Please fill in the blanks. (min - max)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MusicCdScreen_Load(sender, e);
                txtMaxPrice.Text = "";
                txtMinPrice.Text = "";
            }
            else
            {
                foreach (Product product in StoreMainScreen.productList)
                {
                    if (product is MusicCD)
                    {
                        if (product.Price >= Int32.Parse(txtMinPrice.Text) && product.Price <= Int32.Parse(txtMaxPrice.Text))
                        {
                            MusicCdDesign musicCdScreen = new MusicCdDesign((MusicCD)product);
                            musicCdDesignsList.Add(musicCdScreen);
                            flpMusicCdList.Controls.Add(musicCdScreen);
                        }
                    }
                }
            }
            if (flpMusicCdList.Controls.Count == 0)
            {
                MessageBox.Show("There is no product in the range you are looking for.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MusicCdScreen_Load(sender, e);
                txtMinPrice.Text = "";
                txtMaxPrice.Text = "";
            }
        }
    }
}
