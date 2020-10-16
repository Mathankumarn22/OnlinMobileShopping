using System.Collections.Generic;
using OnlineMobileShop.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.Entity;
using System.Linq;

namespace OnlineMobileShop.Respository
{
    public class MobileRespository
    {
        DBContext dBContext = new DBContext();
        public int Add(Mobile mobile)
        {
            
            dBContext.mobile.Add(mobile);
            return dBContext.SaveChanges();
            
        }
        public Mobile Edit(int id)
        {
         
         Mobile   mobile = dBContext.mobile.Find(id);
            return mobile;
            
        }
        public IEnumerable<Mobile> Display()
        {
            return dBContext.mobile.ToList();            
        }

        public void Delete(int id)
        {
            Mobile mobile = dBContext.mobile.Find(id);
            dBContext.mobile.Remove(mobile);
            dBContext.SaveChanges();
           
        }

        public  void Update(Mobile mobile)
        {
            dBContext.Entry(mobile).State = EntityState.Modified;
            dBContext.SaveChanges();
        }
      

    }
}