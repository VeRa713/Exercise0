using CarFactory.Models;

namespace CarFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Console.WriteLine("\n======= WELCOME =======");

            Console.Write("How may vehicles would you like to add? ");
            int loop = Convert.ToInt32(Console.ReadLine());

            int successfulTransaction = 0;

            while (successfulTransaction < loop)
            {
                Console.WriteLine("\n\n======= MENU ======= ");
                Console.WriteLine("C - Car");
                Console.WriteLine("T - truck");
                Console.Write("\nWhat vehicle would you like to create? ");
                string choice = Console.ReadLine();

                string color = "";
                string model = "";
                float capacity = 0.00f;

                Car car;
                Truck truck;

                switch (choice.ToUpper())
                {
                    case "C":
                        Console.WriteLine("\n===== Create Car =====");

                        Console.Write("Enter brand: ");
                        model = Console.ReadLine();

                        Console.Write("Enter color: ");
                        color = Console.ReadLine();

                        car = new Car(color, model, choice);

                        vehicles.Add(car);

                        successfulTransaction++;
                        Console.WriteLine("Car order successfully created!");

                        break;

                    case "T":
                        Console.WriteLine("\n===== Create Truck =====");

                        Console.Write("Enter brand: ");
                        model = Console.ReadLine();

                        Console.Write("Enter color: ");
                        color = Console.ReadLine();

                        Console.Write("Enter Capacity: ");
                        capacity = float.Parse(Console.ReadLine());

                        truck = new Truck(color, model, choice, capacity);

                        vehicles.Add(truck);

                        successfulTransaction++;
                        Console.WriteLine("Truck order successfully created!");

                        break;

                    default:
                        Console.WriteLine("Choice invalid...Try again.");
                        break;
                }
            }

            Console.WriteLine("\n\n======= VEHICLE LIST =======");

            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].GetType() == typeof(Car))
                {
                    // Typecasting temp to be treated as a CheckingAccount
                    Car temp = (Car)vehicles[i];
                    Console.WriteLine("\nVehicle #" + (i + 1) + " is a Car");
                }
                else if (vehicles[i].GetType() == typeof(Truck))
                {
                    Truck temp = (Truck)vehicles[i];
                    Console.WriteLine("\nVehicle #" + (i + 1) + " is a Truck");
                }
            }

            Console.WriteLine("\n\n=============================");
        }
    }
}
