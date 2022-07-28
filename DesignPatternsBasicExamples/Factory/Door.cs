using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Factory
{
    public class Door : IWood
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Door Produced");
            //Bu sınıfa özel davranış ve öznitelikleri özelleştirebilirsiniz.
        }
    }
}
