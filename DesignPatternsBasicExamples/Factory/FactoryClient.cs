using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Factory
{
    class FactoryClient
    {
        public void Main()
        {
            var woodFactory = new WoodFactory();
            IWood woodDoor = woodFactory.ProductWood(WoodType.Door);
            woodDoor.DisplayInfo();

            IWood woodPergola = woodFactory.ProductWood(WoodType.Pergola);
            woodPergola.DisplayInfo();
        }
       
    }
}
