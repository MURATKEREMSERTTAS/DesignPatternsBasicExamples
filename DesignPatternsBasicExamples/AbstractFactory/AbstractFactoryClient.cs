using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.AbstractFactory
{
    public class AbstractFactoryClient
    {
        public void Main()
        {
            new MainCompany().ClientMethod(new PlasticFactory());
            new MainCompany().ClientMethod(new WoodFactory());
        }
    }
}
