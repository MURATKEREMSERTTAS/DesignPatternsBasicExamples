using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Singleton
{
    class TestSingleton
    {
        public static void TestSngltn(string value)
        {
            SingletonBase singleton = SingletonBase.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
