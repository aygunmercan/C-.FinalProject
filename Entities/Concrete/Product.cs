// DataAccess ürünü ekleyecek
// Business kontrol edecek
// Console ürünü gösterecek
// entity bizim yardımcı katmanımız olacak. Diğer 3 katman bu entities i kullanacak
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product: IEntity // public yapmak demek: bu classa diğer katmanlarda ulaşsın demek.
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }   //short: int'in bir küçüğü olan veri tipi
        public decimal UnitPrice { get; set; }

    }
}
