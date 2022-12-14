using DesignPatternsBasicExamples.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Adapter
{
    interface IProductAdapter
    {
        public IProductType CreateProductType();
        public ISteelProduct CreateProduct();
    }
}
