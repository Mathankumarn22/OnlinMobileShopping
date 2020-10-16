using OnlineMobileShop.DAL;
using OnlineMobileShop.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace OnlineMobileShop.BL
{
    public class UserBL
    {
        ProductRepository productRepository = new ProductRepository();
       
       
       
        public bool GetCustomerDetails(Product product)
        {
            return productRepository.GetProduct(product);
        }
        public DataTable ToBind()
        {
            return productRepository.ToBind();
        }
        public bool UpdateCustomerDetails(Product product)
        {
            return productRepository.UpdateCustomerDetails(product);
        }
        public bool DeleteCustomer(Product product)
        {
            return productRepository.DeleteCustomer(product);
        }
    }
}
