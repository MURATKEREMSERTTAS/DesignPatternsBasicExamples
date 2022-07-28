using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Singleton
{
    class SingletonClient
    {
        public void Main()
        {
            Thread process = new Thread(() =>
            {
                TestSingleton.TestSngltn("Foo");
            });
            Thread thread = new Thread(() =>
            {
                TestSingleton.TestSngltn("Bar");
            });

            process.Start();
            thread.Start();
            process.Join();
            thread.Join();

        }
    }
}
