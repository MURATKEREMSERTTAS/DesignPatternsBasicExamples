using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Builder
{
    public interface WindowBuilder
    {
        void GetWindow();
        void Price(double height,double width);
        Window GetResult();


    }
}
