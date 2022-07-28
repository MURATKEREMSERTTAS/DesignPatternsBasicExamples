using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.AbstractFactory
{
    public class WoodFactory : IProductFactory
    {
        public IProductType CreateProductType()
        {
            return new Wood();
        }
        public IProduct CreateProduct()
        {
            return new Pergole();
        }
    }
}
