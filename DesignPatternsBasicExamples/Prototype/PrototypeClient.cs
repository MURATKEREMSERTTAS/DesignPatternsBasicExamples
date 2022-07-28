using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Prototype
{
    class PrototypeClient
    {
        public void Main()
        {
            Pergola client1 = new Pergola(2.5, 10.0, 4.2);
            Pergola clone = client1.prototype();
            Console.WriteLine($"orijinal object=clone => {client1 == clone}");
        }
    }
}
