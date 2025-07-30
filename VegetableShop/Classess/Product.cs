public class Product
{
    public string Name { get; protected set; }
    protected decimal BasePrice;

    public Product(string name, decimal basePrice)
    {
        Name = name;
        BasePrice = basePrice;
    }

    public virtual decimal GetTotalPrice()
    {
        return BasePrice;
    }

    public virtual string GetInfo()
    {
        return $"Product: {Name}, Price: {BasePrice}";
    }
}
