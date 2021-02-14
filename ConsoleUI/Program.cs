// test ortamı burası
//Abstract klasörü içinde; abstractlar, interfaceler, base classlar oluyor. Burda referans tutucular olacak
// Concrete(somut) klasörü içinde ise gerçek işe yapanlar konulur. 
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    // SOLID 
    // O : Open Closed Principle :yeni bir özellik ekliyorsan mevcut koduna dokunamazsın
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
           
        }
    }
}
