using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Builder
{
    public class PlasticWindowBuilder : WindowBuilder
    {
        Window window = new Window();
        public void GetWindow()
        {

            window.id = 2;
            window.description = "This window made of plastic";

        }
        public void Price(double height, double width)
        {
            window.height = height;
            window.width = width;
            var pricedoublee = (height * width * 375).ToString().Split(",");
            window.price = $"{pricedoublee[0]}tl";
        }



        public Window GetResult()
        {
            return window;
        }
    }
}
