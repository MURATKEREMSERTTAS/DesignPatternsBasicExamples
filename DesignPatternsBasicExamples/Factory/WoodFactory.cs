using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Factory
{
    public class WoodFactory : IWoodFactory
    {
        public IWood ProductWood(WoodType type)
        {
            IWood wood = null;
            switch (type)
            {
                case WoodType.Door:
                    wood = new Door();
                    break;
                case WoodType.Window:
                    wood = new Window();
                    break;
                case WoodType.Pergola:
                    wood = new Pergola();
                    break;
            }
            return wood;
        }
    }
}
