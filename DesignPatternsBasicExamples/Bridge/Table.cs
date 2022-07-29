using DesignPatternsBasicExamples.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Bridge
{
     class Table :Chair
    {
        public Table(IFurnitureMethod furnitureMethod) : base(furnitureMethod) { }

    public override string GetMethod()
    {
        return base.furnitureMethod.GetFurniture();
    }
}
}
