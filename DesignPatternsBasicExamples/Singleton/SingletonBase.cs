using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Singleton
{
     class SingletonBase
    {
        private SingletonBase() { }

        private static SingletonBase _instance;

        private static readonly object _lock = new object();

        public static SingletonBase GetInstance(string value)
        {
            if(_instance == null)
            {
                lock (_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new SingletonBase();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }
        public string Value { get; private set; }
    }
}
