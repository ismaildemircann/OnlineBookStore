using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    /**
    * @brief   This file includes to logined customer information.
    */
    public class LoginedCustomer
    {
        private Customer customer;
        private static LoginedCustomer loginedCustomer;
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public Customer User { get => customer; set => customer = value; }
        /// <summary>
        /// This function is used to create new loginedcustomer.
        /// </summary>
        /// <returns>loginedCustomer</returns>
        public static LoginedCustomer getInstance()
        {
            if (loginedCustomer == null)
            {
                loginedCustomer = new LoginedCustomer();
            }
            return loginedCustomer;
        }
    }
}
