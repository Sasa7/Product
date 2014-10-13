using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class SomeExternalVendorProduct
    {
        public SomeExternalVendorProduct()
        {
            PricePerUnit = 1;
            EANCode = "4444";
            Description = "Description";
        }
        public int PricePerUnit { get; set; }
        public string EANCode { get; set; }
        public string Description { get; set; }
    }
}
