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
            var customOperation = new CustomOperation(new PlasticPergoleAdapter());
            IProductType productType = customOperation.CreateProductType();
            IProduct product = customOperation.CreateProduct();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Adapting plastic pergole");
            Console.WriteLine(product.GetProduct());
            Console.WriteLine(productType.GetProductType());
        }
    }
}
