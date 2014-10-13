using ProductLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAdapterLib
{
    public class SomeExternalVendorProduct: IProduct
    {
        public SomeExternalVendorProduct()
        {
            PricePerUnit = 1;
            Description = "Description";
            EANCode = "4444";
        }
        public int PricePerUnit{ get; set; }
        public string Description { get; set; }
        public string EANCode { get; set; }
    }
}
