using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Prototype
{
    interface IClonablePrototype<TPrototype>
    {
        TPrototype prototype();
    }
}
