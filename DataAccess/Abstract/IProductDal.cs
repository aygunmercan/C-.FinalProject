 using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


// IProductDal : I=Interface, Product=Hangi tabloya karşılık geldiği, Dal= Hangi katmana karşılık geldiği
// Dal= Data Access Layer

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
         
    }
}
