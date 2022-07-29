using DesignPatternsBasicExamples.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Adapter
{
    class CustomOperation
    {
        private IProductAdapter productAdapter;

        public CustomOperation(IProductAdapter productAdapter)
        {
            this.productAdapter = productAdapter;
        }

        public IProductType CreateProductType()
        {
            return productAdapter.CreateProductType();
        }
        public ISteelProduct CreateProduct()
        {
            return productAdapter.CreateProduct();
        }
    }
}
