Console.Clear();
var shop = new VegetableShop();
bool running = true;

while (running)
{
    Console.WriteLine("\n==== Меню ====");
    Console.WriteLine("1. Додати Carrot");
    Console.WriteLine("2. Додати Potato");
    Console.WriteLine("3. Додати Cucumber");
    Console.WriteLine("4. Додати Tomato");
    Console.WriteLine("5. Переглянути кошик");
    Console.WriteLine("6. Вийти");
    Console.Write("Оберіть дію: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Введіть ціну для Carrot: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal carrotPrice))
                shop.AddProduct(new Carrot(carrotPrice));
            break;

        case "2":
            Console.Write("Ціна за кг Potato: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal pPrice)) break;
            Console.Write("Вага в грамах: ");
            if (!int.TryParse(Console.ReadLine(), out int pGrams)) break;
            shop.AddProduct(new Potato(pPrice, pGrams));
            break;

        case "3":
            Console.Write("Ціна за кг Cucumber: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal cPrice)) break;
            Console.Write("Вага в грамах: ");
            if (!int.TryParse(Console.ReadLine(), out int cGrams)) break;
            shop.AddProduct(new Cucumber(cPrice, cGrams));
            break;

        case "4":
            Console.Write("Введіть ціну для Tomato: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal tomatoPrice))
                shop.AddProduct(new Tomato(tomatoPrice));
            break;

        case "5":
            shop.PrintProductsInfo();
            break;

        case "6":
            Console.WriteLine("Вихід з програми.");
            return;

        default:
            Console.WriteLine("Невідомий вибір.");
            break;
    }
}
