using DesignPatternsBasicExamples.AbstractFactory;
using DesignPatternsBasicExamples.Factory;
using DesignPatternsBasicExamples.Singleton;
using System;
namespace DesignPatternsBasicExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            new SingletonClient().Main();
            new FactoryClient().Main();
            new AbstractFactoryClient().Main();
        }
    }
}
