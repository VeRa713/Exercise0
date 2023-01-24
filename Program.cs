using CarFactory.Models;

namespace CSharpDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n======= WELCOME =======");

            Console.Write("How may vehicles would you like to add? ");
            int loop = Convert.ToInt32(Console.ReadLine());

            int successfulTransaction = 0;

            Order order = new Order();

            while (successfulTransaction < loop)
            {
                Console.WriteLine("\n\n======= MENU ======= ");
                Console.WriteLine("C - Car");
                Console.WriteLine("T - truck");
                Console.Write("\nWhat vehicle would you like to create? ");
                string choice = Console.ReadLine();

                string model = "";
                float capacity = 0;

                Vehicle vehicle;

                switch (choice.ToUpper())
                {
                    case "C":
                        Console.WriteLine("\n===== Create Car =====");

                        Console.Write("Enter model: ");
                        model = Console.ReadLine();

                        vehicle = new Vehicle("Car");
                        order.AddTransaction(vehicle);

                        successfulTransaction++;
                        Console.WriteLine("Car order successfully created!");

                        break;

                    case "T":
                        Console.WriteLine("\n===== Create Truck =====");

                        Console.Write("Enter model: ");
                        model = Console.ReadLine();

                        Console.Write("Enter Capacity: ");
                        capacity = float.Parse(Console.ReadLine());

                        vehicle = new Vehicle("Truck");
                        order.AddTransaction(vehicle);

                        successfulTransaction++;
                        Console.WriteLine("Truck order successfully created!");

                        break;

                    default:
                        Console.WriteLine("Choice invalid...Try again.");
                        break;
                }
            }

            Console.WriteLine("\n\n======= ORDER SUMMARY =======");

            for (int i = 0; i < order.GetVehicles().Count; i++)
            {
                Vehicle v = order.GetVehicles()[i];
                Console.WriteLine("\nOrder #" + (i + 1));
                Console.WriteLine("Vehicle Type: " + v.GetVehicleType());
            }

            Console.WriteLine("\n\n=============================");
        }
    }
}
