using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.AbstractFactory
{
    public class Window : IProduct
    {
        public string GetProduct()
        {
            return "Window";
        }
    }
}
