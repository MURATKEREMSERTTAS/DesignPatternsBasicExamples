using DesignPatternsBasicExamples.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Bridge
{
    public class MethodChair : IFurnitureMethod
    {
        
        public string GetFurniture()
        {
            return "Modern Chair";
        }
    }
}
