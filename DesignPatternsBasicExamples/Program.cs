using DesignPatternsBasicExamples.AbstractFactory;
using DesignPatternsBasicExamples.Adapter;
using DesignPatternsBasicExamples.Bridge;
using DesignPatternsBasicExamples.Builder;
using DesignPatternsBasicExamples.Factory;
using DesignPatternsBasicExamples.Prototype;
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
            new AdapterClient().Main();
            new BuilderClient().Main();
            new PrototypeClient().Main();
            new BridgeClient().Main();
        }
    }
}
