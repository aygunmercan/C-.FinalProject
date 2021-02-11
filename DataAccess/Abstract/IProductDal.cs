 using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


// IProductDal : I=Interface, Product=Hangi tabloya karşılık geldiği, Dal= Hangi katmana karşılık geldiği
// Dal= Data Access Layer

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        List<Product> GetAllByCategory(int categoryId);  //ürünleri kategoriye göre filtrele demek.
    }
}
