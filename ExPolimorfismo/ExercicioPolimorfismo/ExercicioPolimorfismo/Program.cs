using ExercicioPolimorfismo;

List<Product> products = new List<Product>();
Console.Write("Enter the number of products: ");
int qttProducts = int.Parse(Console.ReadLine());

for (int indice = 1; indice <= qttProducts; indice++)
{
    Console.WriteLine($"Product #{indice} data: ");
    Console.Write("Is this product common, used, imported (c/u/i): ");
    char type = char.Parse(Console.ReadLine().ToLower());

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());

    switch (type)
    {
        case 'i':
            Console.Write("Customs fee: ");
            double customsFee = double.Parse(Console.ReadLine());
            products.Add(new ImportedProduct(name, price, customsFee));
            break;

        case 'c':
            products.Add(new Product(name, price));
            break;

        case 'u':
            Console.Write("Manufacture date (DD/MM/YYYY): ");
            DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
            products.Add(new UsedProduct(name, price, manufactureDate));
            break;

        default:
            Console.WriteLine("Invalid product type!");
            break;
    }
}
Console.WriteLine("\nPRICE TAGS:");
foreach (var product in products)
{
    Console.WriteLine(product.PriceTag());
}


