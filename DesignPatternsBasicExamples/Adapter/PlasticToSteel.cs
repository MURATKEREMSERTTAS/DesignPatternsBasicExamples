using DesignPatternsBasicExamples.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Adapter
{
    class PlasticToSteel
    {
        public IProductType CreateProductType()
        {
            return new Plastic();
        }
        public ISteelProduct CreateProduct()
        {
            return new SteelDoor();
        }
    }
}
