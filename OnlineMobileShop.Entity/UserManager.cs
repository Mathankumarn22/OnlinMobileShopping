using System;
using OnlineMobileShop.Common;

namespace OnlineMobileShop.Entity
{
    public class UserManager
    {
        public int userId { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string mailID { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public UserManager(string name, string number, string mailID, string password)
        {
          
            this.name = name;
            this.number = number;
            this.mailID = mailID;
            this.password = password;
        }
    }
}        