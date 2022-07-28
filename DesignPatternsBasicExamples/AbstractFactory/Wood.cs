using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.AbstractFactory
{
    public class Wood : IProductType
    {
        public string GetProductType()
        {
            return "Produced By WoodStaff";
        }
    }
}
