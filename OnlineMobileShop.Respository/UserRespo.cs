using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMobileShop.Entity;
using System.Configuration;
using System.Data.SqlClient;

namespace OnlineMobileShop.Respository
{
    public class UserRespo
    {
        
        public static void SignUp(Account user)
        {
            DBContext dBContext = new DBContext();
            dBContext.account.Add(user);
            dBContext.SaveChanges();
        }

        public List<Account> GetUser()
        {
            DBContext dBContext = new DBContext();
            return dBContext.account.ToList();
        }
        public static Account LogIn(Account account)
        {
            using (DBContext dBContext = new DBContext())
            {
               Account fetchDetails= dBContext.account.Where(find => find.MailID == account.MailID && find.Password == account.Password).FirstOrDefault();
                return fetchDetails;
            }
            //var obj = dBContext.account.Where(a => a.MailID == mailid && a.Password == password).FirstOrDefault();  
            //if(obj!=null)
            //{
            //    return true;
            //}
            //return false;
        }
    }
}
