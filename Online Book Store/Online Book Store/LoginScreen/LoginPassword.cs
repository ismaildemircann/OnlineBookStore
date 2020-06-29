using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store
{
    /**   
    * @brief    This file includes login password operations.
    */
    public partial class LoginPassword : UserControl
    {
        public LoginPassword()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string GetSetText { get => tbPassword.Text; set => tbPassword.Text = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public bool getSetPasswordChar { get => tbPassword.UseSystemPasswordChar; set => tbPassword.UseSystemPasswordChar = value; }
    }
}
