using System.Text;

namespace ExercicioEnum.Entities;

internal class Order
{
    private List<OrderItem> ProductList = new List<OrderItem>();
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public Client Client { get; set; } 

    public Order() { }

    public Order(OrderStatus status, Client client)
    {
        Moment = DateTime.Now;
        Status = status;
        Client = client; 
    }

    public void AddItem(OrderItem orderItem)
    {
        ProductList.Add(orderItem);
    }

    public void RemoveItem(OrderItem orderItem)
    {
        ProductList.Remove(orderItem);
    }

    public double TotalCompra()
    {
        double totalPedido = 0;
        foreach (OrderItem item in ProductList)
        {
            totalPedido += item.SubTotal();
        }
        return totalPedido;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Order Summary:");
        sb.Append("Order Moment: ");
        sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm"));
        sb.Append("Order status: ");
        sb.AppendLine(Status.ToString());
        sb.Append("Client: ");
        sb.AppendLine($"{Client.Name} ({Client.BirthDate:dd/MM/yyyy}) - {Client.Email}"); 
        sb.AppendLine("Order items:");
        foreach (OrderItem item in ProductList)
        {
            sb.AppendLine($"{item.Product.Name}, ${item.Product.Price:F2}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal():F2}");
        }
        sb.AppendLine($"Total price: ${TotalCompra():F2}");
        return sb.ToString();
    }
}

