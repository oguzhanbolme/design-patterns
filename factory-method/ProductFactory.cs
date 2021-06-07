public class ProductFactory
{
    public IProduct createProduct(ProductTypes productTypes)
    {
        IProduct product = null;
        switch (productTypes)
        {
            case ProductTypes.Computer:
                product = new Computer();
                break;
            case ProductTypes.Phone:
                product = new Phone();
                break;
            case ProductTypes.Television:
                product = new Television();
                break;
        }
        return product;
    }
}