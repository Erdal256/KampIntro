using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        //hangi kategoriye ait olduğu
        public int CategoryId { get; set; }
        //ürünün adı
        public string ProductName  { get; set; }
        //ürünün birim fiyatı
        public double UnitPrice { get; set; }
        //ürünün stok adedi
        public int UnitInStock { get; set; }

     
    }
}
