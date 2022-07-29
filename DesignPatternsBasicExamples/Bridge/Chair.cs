using DesignPatternsBasicExamples.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Bridge
{
    class Chair
    {
        protected IFurnitureMethod furnitureMethod;

        public Chair(IFurnitureMethod furnitureMethod)
        {
            this.furnitureMethod = furnitureMethod;
        }
        public virtual string GetMethod()
        {
            return furnitureMethod.GetFurniture();
        }
    }
}
