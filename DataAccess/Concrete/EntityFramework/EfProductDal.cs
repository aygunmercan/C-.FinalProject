using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet 
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            // using: IDispossable pattern implemantation of c#
            
            using (NorthwindContext context = new NorthwindContext())            // using yaz tabtab: using ile nesne kullanılır sonra atılır,bellekte yer kaplamaz.
            {
                var addedEntity = context.Entry(entity);     //veri kaynağında gönderilen product'ı eşleştir.
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                 
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())           
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter); 
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null                               //filtre null mı?
                    ? context.Set<Product>().ToList()                 // null sa bunu yap              // veritabanındaki product tablosunu listeye çeviriyor içindeki her veriyle birlikte.          
                    : context.Set<Product>().Where(filter).ToList();    // null değilse bunu yap               
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
