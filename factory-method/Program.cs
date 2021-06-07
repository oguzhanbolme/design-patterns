using System;

namespace factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            var productFactory = new ProductFactory();

            var computer = productFactory.createProduct(ProductTypes.Computer);
            var phone = productFactory.createProduct(ProductTypes.Phone);
            var television = productFactory.createProduct(ProductTypes.Television);

            Console.WriteLine(computer.getProductInfo());
            Console.WriteLine(phone.getProductInfo());
            Console.WriteLine(television.getProductInfo());
        }
    }
}
