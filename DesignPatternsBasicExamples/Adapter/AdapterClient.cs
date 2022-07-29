using DesignPatternsBasicExamples.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.Adapter
{
    public class AdapterClient
    {
        public void Main()
        {
            var customOperation = new CustomOperation(new PlasticToSteelAdapter());
            IProductType productType = customOperation.CreateProductType();
            ISteelProduct product = customOperation.CreateProduct();
            Console.WriteLine("------------------------------");
            Console.WriteLine("New Product Adapting");
            Console.WriteLine(product.GetNewMethod());
            Console.WriteLine(productType.GetProductType());
        }
    }
}
