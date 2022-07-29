using DesignPatternsBasicExamples.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Bridge
{
    public class BridgeClient
    {
        

        public void Main()
        {
            Chair chair;
            chair = new Chair(new MethodChair());
            Console.WriteLine(chair.GetMethod());
            Console.WriteLine("--------------------------");
            Table table;
            table = new Table(new MethodTable());
            Console.WriteLine(table.GetMethod());
        }
    }
}
