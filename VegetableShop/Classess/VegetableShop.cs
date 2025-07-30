public class VegetableShop
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void PrintProductsInfo()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products in the shop.");
            return;
        }

        decimal total = 0;

        foreach (var product in products)
        {
            Console.WriteLine(product.GetInfo());
            total += product.GetTotalPrice();
        }

        Console.WriteLine($"Total products price: {total:0.00}");
    }
}
