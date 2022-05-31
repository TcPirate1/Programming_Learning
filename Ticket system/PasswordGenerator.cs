using System;
using System.Text;

namespace Ticket_system_2
{
    class PasswordGenerator
    {
        public static string Conversion(string ID, int TN) 
        {//Generates password with staffID passed to the method
            string NstaffID=ID.Substring(0,2);
            string Timestamp=DateTime.Now.ToString().Substring(0,3);
            byte[]bytes=Encoding.UTF8.GetBytes(Timestamp);
            string hexTimestamp=Convert.ToHexString(bytes);
            string hexValue=TN.ToString("X");
            string newPassword= NstaffID+hexValue+hexTimestamp;
            return newPassword;
        }
    }
}