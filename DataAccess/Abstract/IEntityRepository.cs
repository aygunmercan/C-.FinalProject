using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


// Entityler Product, Category gibi nesneler. Biz her seferinde ICategoryDal'daki gibi aynı şeyleri  (Generic Repository)
// oluşturmak ama category, product gibi nesneleri değiştirmek zorunda kalıuyorsak burda 'Generic' yapıyı oluşturmalıyız.
// Bu interface bu amaçla kullanılacak.

namespace DataAccess.Abstract
{
    // T yerine yazılabilecek şeyleri sınırlandıralım. Buna "Generic Constraint" denir.
    // class : Referans Tip olabilir demek. Class olabilir demek değil
    // IEntity: IEntity veya IEntity implemente eden bir nesne olabilir.
    // new(): new'lenebilir olmalı. IEntity'nin kendisi bu sayede kullanılamaz product vb kullanılabilir.
    public interface IEntityRepository<T> where T:class,IEntity,new()                        
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);                    //istediğimiz şekilde filtreleme yapabiliriz getireceğimiz şeylerde bu linq ile. filter=null demek filtre vermeyedebilirsin demek
        T Get(Expression<Func<T, bool>> filter);                                 // bu bize bir T döndüren bir operasyon.ama filtreleme yaparak     , filtre zorunlu
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
