using ExercicioEnum.Entities;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter client data:");
        Console.Write("Name: ");
        string clientName = Console.ReadLine();
        Console.Write("Email: ");
        string clientEmail = Console.ReadLine();
        Console.Write("Birth Date (DD/MM/YYYY): ");
        DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());
        Client client = new Client
        {
            Name = clientName,
            Email = clientEmail,
            BirthDate = clientBirthDate
        };

        Console.WriteLine("Enter order data:");
        Console.Write("Order status (PendingPayment = 0, Processing = 1, Shipped = 2, Delivered = 3): ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
        Order order = new Order(status, client); 

        Console.Write("Enter the number of items: ");
        int itensQtd = int.Parse(Console.ReadLine());

        for (int i = 1; i <= itensQtd; i++)
        {
            Console.WriteLine($"Enter #{i} item data:");
            Console.Write("Product name: ");
            string productName = Console.ReadLine();
            Console.Write("Product price: ");
            double productPrice = double.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product(productName, productPrice);
            OrderItem orderItem = new OrderItem(product, quantity);
            order.AddItem(orderItem);
        }

        Console.WriteLine(order.ToString());
    }
}




