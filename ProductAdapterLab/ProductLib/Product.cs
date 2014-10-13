using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class Product: IProduct
    {
        public Product()
        {
            UnitPrice = 20;
            BarCode = "55555";
            Title = "Boll";
        }
        public decimal UnitPrice { get; set; }
        public string BarCode { get; set; }
        public string Title { get; set; }
    }

}
