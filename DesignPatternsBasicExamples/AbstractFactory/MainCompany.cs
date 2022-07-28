using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBasicExamples.AbstractFactory
{
    public class MainCompany
    {
        public  void ClientMethod(IProductFactory factory)
        {
            var product = factory.CreateProduct();
            var productType = factory.CreateProductType();

            Console.WriteLine(product.GetProduct());
            Console.WriteLine(productType.GetProductType());
        }
        
        
    }
}
