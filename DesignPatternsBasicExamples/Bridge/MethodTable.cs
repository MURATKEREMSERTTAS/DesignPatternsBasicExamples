using DesignPatternsBasicExamples.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Bridge
{
    class MethodTable : IFurnitureMethod
    {

        public string GetFurniture()
        {
            return "Vintage Table";
        }
    }
}
