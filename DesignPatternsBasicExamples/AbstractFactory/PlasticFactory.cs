using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.AbstractFactory
{
    public class PlasticFactory : IProductFactory
    {
        public IProductType CreateProductType()
        {
            return new Plastic();
        }
        public IProduct CreateProduct()
        {
            return new Window();
        }
    }
}
