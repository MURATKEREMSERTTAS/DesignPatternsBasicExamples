using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Builder
{
    public class WoodWindowBuildercs : WindowBuilder
    {
        Window window = new Window();
        public void GetWindow()
        {
           
            window.id = 1;
            window.description = "This window made of wood";

        }
        public void Price(double height,double width)
        {
            window.height = height;
            window.width = width;
            var pricedouble = (height * width * 500).ToString().Split(",");
            window.price= $"{pricedouble[0]}tl";
        }

        

        public Window GetResult()
        {
            return window;
        }

       
    }
}
