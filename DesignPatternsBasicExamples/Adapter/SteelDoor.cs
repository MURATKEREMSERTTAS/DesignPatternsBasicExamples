using DesignPatternsBasicExamples.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Adapter
{
    class SteelDoor : ISteelProduct
    {
        public string GetNewMethod()
        {
            return "New Product SteelDoor";
        }
    }
}
