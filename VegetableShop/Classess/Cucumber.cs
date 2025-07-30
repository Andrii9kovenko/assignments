public class Cucumber : Product
{
    public int Grams { get; private set; }

    public Cucumber(decimal basePricePerKg, int grams) : base("Cucumber", basePricePerKg)
    {
        Grams = grams;
    }

    public override decimal GetTotalPrice()
    {
        return BasePrice * (Grams / 1000m);
    }

    public override string GetInfo()
    {
        return $"Product: {Name}, Price: {BasePrice} per kg, Grams: {Grams}, Total price: {GetTotalPrice():0.00}";
    }
}
