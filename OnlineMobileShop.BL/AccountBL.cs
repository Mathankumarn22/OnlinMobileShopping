using OnlineMobileShop.Entity;
using OnlineMobileShop.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMobileShop.BL
{
    public class AccountBL
    {
        public static bool SignUp(Account user)
        {
            DBContext dBContext = new DBContext();
            Account mailID = dBContext.account.Where(s => s.MailID == user.MailID).FirstOrDefault();
            if(mailID!=null)
            {
                return false;
            }
           UserRespo.SignUp(user);
            return true;
        }
        public static Account LogIn(Account account)
        {
            return UserRespo.LogIn(account);
        }
    }
}
