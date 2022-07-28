using DesignPatternsBasicExamples.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Adapter
{
    class PlasticPergole
    {
        public IProductType CreateProductType()
        {
            return new Plastic();
        }
        public IProduct CreateProduct()
        {
            return new Pergole();
        }
    }
}
