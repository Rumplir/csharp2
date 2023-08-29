using S09EP05.Entities;
using S09EP05.Entities.Enums;
using System.Globalization;

namespace S09EP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order: ");
            int qntOrder = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order();
            OrderItem item = new OrderItem();

            for (int i = 1; i <= qntOrder; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int pQnt = int.Parse(Console.ReadLine()); 

                Product product = new Product(pName, pPrice);
                item = new OrderItem(pQnt, pPrice, product);
                order.AddItem(item);

            }
            Console.WriteLine();
            Console.WriteLine("SUMMARY:");
            Console.WriteLine(order);
        }
    }
}