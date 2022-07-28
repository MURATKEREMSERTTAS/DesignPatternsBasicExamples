using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Builder
{
    class BuilderClient
    {
        public void Main()
        {
            WindowBuilder windowBuilder = new WoodWindowBuildercs();
            WindowDirector windowDirector = new WindowDirector(windowBuilder);
            windowDirector.made(1.5,3.2);

            Window window = windowBuilder.GetResult();

            Console.WriteLine("---------------------");
            Console.WriteLine($"{window.description} - {window.price} - {window.id}");
            Console.WriteLine("---------------------");

            WindowBuilder windowBuilder2 = new PlasticWindowBuilder();
            WindowDirector windowDirector2 = new WindowDirector(windowBuilder2);
            windowDirector2.made(1.5, 3.2);

            Window window2 = windowBuilder2.GetResult();

            Console.WriteLine("---------------------");
            Console.WriteLine($"{window2.description} - {window2.price} - {window2.id}");
            Console.WriteLine("---------------------");


        }
    }
}
