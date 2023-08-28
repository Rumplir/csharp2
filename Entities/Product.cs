using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S09EP05.Entities
{
    internal class Product
    {
        public String NameP { get; set; }
        public double PriceP { get; set; }

        public Product() { }

        public Product(string nameP, double priceP)
        {
            NameP = nameP;
            PriceP = priceP;
        }

        
    }
}
