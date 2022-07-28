using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Prototype
{
    class Pergola : IClonablePrototype<Pergola>
    {
        double heigth;
        double weight;
        double length;

        public Pergola(double heigth, double weight, double length)
        {
            this.heigth = heigth;
            this.weight = weight;
            this.length = length;
        }

        public Pergola prototype()
        {
            return base.MemberwiseClone() as Pergola;
        }
    }
}
