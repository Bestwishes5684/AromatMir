using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AromatMir.ModelResponce
{
    public class ProductResponce
    {

        public string ProductArticleNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public Image ProductPhoto { get; set; }
        public string ProductManufacturer { get; set; }
        public decimal ProductCost { get; set; }
        public byte? ProductDiscountAmount { get; set; }
        public int ProductQuantityInStock { get; set; }
        public string ProductStatus { get; set; }

    }
}
