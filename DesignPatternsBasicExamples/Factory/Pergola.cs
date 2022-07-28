using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Factory
{
    public class Pergola : IWood
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Pergola produced");
        }
    }
}
