namespace CarFactory.Models
{
    public class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }

        public Vehicle(string color, string brand)
        {
            this.Color = color;
            this.Brand = brand;
        }
    }
}