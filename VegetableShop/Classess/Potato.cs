public class Potato : Product
{
    public int Grams { get; private set; }

    public Potato(decimal basePricePerKg, int grams) : base("Potato", basePricePerKg)
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
