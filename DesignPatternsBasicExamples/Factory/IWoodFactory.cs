using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Factory
{
    public interface IWoodFactory
    {
        IWood ProductWood(WoodType woodType);
    }
}
