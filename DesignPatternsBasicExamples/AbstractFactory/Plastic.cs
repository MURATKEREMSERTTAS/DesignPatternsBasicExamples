using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.AbstractFactory
{
    public class Plastic : IProductType
    {
        public string GetProductType()
        {
            return "Produced By Pimapen";
        }
    }
}
