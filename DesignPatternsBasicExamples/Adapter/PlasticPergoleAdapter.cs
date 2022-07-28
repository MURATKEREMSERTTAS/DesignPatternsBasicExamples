using DesignPatternsBasicExamples.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Adapter
{
    class PlasticPergoleAdapter : IProductAdapter
    {
        PlasticPergole plasticPergole = new PlasticPergole();
        public IProduct CreateProduct()
        {
            
            return plasticPergole.CreateProduct();
        }

        public IProductType CreateProductType()
        {
           return plasticPergole.CreateProductType();
        }
    }
}
