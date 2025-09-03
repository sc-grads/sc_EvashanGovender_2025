using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaceConstraint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Product> productRepository = new Repository<Product>();
            var product = new Product ();
            productRepository.Add(product);
        }
    }

    class Product : IEntity
    {
        public int ID { get; set; }
       
    }
}
