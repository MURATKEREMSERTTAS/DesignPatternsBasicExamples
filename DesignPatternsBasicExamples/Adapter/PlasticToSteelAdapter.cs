using DesignPatternsBasicExamples.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Adapter
{
    class PlasticToSteelAdapter : IProductAdapter
    {
        PlasticToSteel plasticPergole = new PlasticToSteel();
        public ISteelProduct CreateProduct()
        {
            
            return plasticPergole.CreateProduct();
        }

        public IProductType CreateProductType()
        {
           return plasticPergole.CreateProductType();
        }
    }
}
