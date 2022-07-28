
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Builder
{
    public class WindowDirector
    {
        private WindowBuilder _builder;

        public WindowDirector(WindowBuilder builder)
        {
            _builder = builder;
        }
        public void made(double height,double width)
        {
            _builder.GetWindow();
            _builder.Price(height,width);
        }


    }
}
