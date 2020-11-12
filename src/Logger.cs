using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store.logger
{
    /**
    * @brief    This file writes the click history. .
    */
    class Logger
    {
        private static Logger logger = null;
        /// <summary>
        /// This function is Constructor.
        /// </summary>
        /// <returns> This function does not return a value </returns>
        private Logger() { }
        /// <summary>
        /// This function creates a logger object.
        /// </summary>
        /// <returns>This function return a logger </returns>
        public static Logger GetLogger()
        {
            if (logger == null)
            {
                logger = new Logger();
            }
            return logger;
        }
        /// <summary>
        /// This function saves user information, button name and time.
        /// </summary>
        /// <param name="username">This parameter holds the username.</param>
        /// <param name="button_name">This parameter holds the button name.</param>
        /// <param name="dateTime">This parameter holds the date.</param>
        /// <returns> This function does not return a value </returns>
        public void WriteLog(string username, string button_name, DateTime dateTime)
        {
            string str = "Username: " + username + " -" + " Clicked Button: " + button_name + " -" + " Date Time: " + dateTime.ToString();
            try
            {
                using (StreamWriter writer = File.AppendText("User.log"))
                {
                    writer.WriteLine(str);
                    writer.Close();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be write:");
            }
        }
    }
}
