using Business.Abtract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;    //Soyut nesne ile bağlantı kurarız. Generate constructor dedik ve alttaki public oluştu.

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // İş kodlarını yazmaya geçiyorsa benim DataAccess'i çağırmam lazım.
            return _productDal.GetAll();
        }
    }
}
