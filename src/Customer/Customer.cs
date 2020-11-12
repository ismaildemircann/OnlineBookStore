using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Online_Book_Store
{
    /**
    * @brief   This file includes to customer information.
    */
    public class Customer
    {
        private string name;
        private string address;
        private string email;
        private string username;
        private string password;
        private string customerId;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">The name string hold the customer name.</param>
        /// <param name="address">The address string hold the customer address.</param>
        /// <param name="email">The email string hold the customer email.</param>
        /// <param name="username">The username string hold the customer username.</param>
        /// <param name="password">The password string hold the customer password.</param>
        /// <param name="customerId">The customer id string hold the customer id.</param>
        public Customer(string name, string address, string email, string username, string password, string customerId)
        {
            this.name = name;
            this.address = address;
            this.email = email;
            this.username = username;
            this.password = password;
            this.customerId = customerId;
        }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string Address { get => address; set => address = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string Email { get => email; set => email = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string Username { get => username; set => username = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string Password { get => password; set => password = value; }
        /// <summary>
        /// This function used to get and set operation.
        /// </summary>
        public string CustomerId { get => customerId; set => customerId = value; }
        /// <summary>
        /// This function used to print customer details.
        /// </summary>
        /// <returns>username, name,address, password ,email,customerId</returns>
        public string PrintCustomerDetails()
        {
            return username + "," + name + "," + address + "," + password + "," + email + "," + customerId;
        }
        /// <summary>
        /// This function write the xml file and save document.
        /// </summary>
        /// <param name="customer">This parameter is a oject Customer class.</param>
        /// <returns> This function does not return a value </returns>
        public static void SaveCustomer(Customer customer)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"data/Customer.xml");
                XElement rootElement = xDoc.Root;
                XElement newElementCustomer = new XElement("Customer");
                XAttribute customeerAttribute = new XAttribute("RegistrationNumber", UtilSave.registrationNo);
                UtilSave.registrationNo++;
                XElement name = new XElement("Name", customer.name);
                XElement address = new XElement("Address", customer.address);
                XElement email = new XElement("Email", customer.email);
                XElement username = new XElement("Username", customer.username);
                XElement password = new XElement("Password", customer.password);
                XElement customerID = new XElement("CustomerID", customer.customerId);
                newElementCustomer.Add(customeerAttribute, name, address, email, username, password, customerID);
                rootElement.Add(newElementCustomer);
                xDoc.Save(@"data/Customer.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void PrintCustomerPurchase()
        {
        }
        /// <summary>
        /// This function is used to control user information.
        /// </summary>
        /// <param name="Username">The username string hold the customer username.</param>
        /// <param name="Password">The password string hold the customer password.</param>
        /// <returns></returns>
        public bool IsValid(string Username, string Password)
        {
            return this.Username.Equals(Username) && this.Password.Equals(UtilConvert.ComputeSha256Hash(Password));
        }
    }
}
