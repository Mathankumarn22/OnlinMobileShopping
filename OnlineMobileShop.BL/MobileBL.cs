using OnlineMobileShop.Entity;
using OnlineMobileShop.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMobileShop.BL
{
    public class MobileBL
    {
        MobileRespository mobileRespository = new MobileRespository();

        public Mobile AddMobiles { get; private set; }

        public int Add(Mobile mobile)
        {
            return mobileRespository.Add(mobile);
        }
        public Mobile Edit(int id)
        {
            return mobileRespository.Edit(id);
        }
        public void Delete(int id)
        {
            mobileRespository.Delete(id);
        }
        public void update(Mobile mobile)
        {
            mobileRespository.Update(mobile);
        }
        public IEnumerable<Mobile> MobileDetails()
        {
           return mobileRespository.Display();
        }
       
        public void AddBrand(Entity.Brand brand)
        {
            BrandRepository repository = new BrandRepository();
            repository.AddBrand(brand);
        }
    }
}
