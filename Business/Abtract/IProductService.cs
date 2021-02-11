using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abtract
{
    public interface IProductService
    {
        List<Product> GetAll();   // tüm ürünleri listeleyecek bir ortam oluşturalım
    }
}
