// test ortamı burası
//Abstract klasörü içinde; abstractlar, interfaceler, base classlar oluyor. Burda referans tutucular olacak
// Concrete(somut) klasörü içinde ise gerçek işe yapanlar konulur. 
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
           
        }
    }
}
