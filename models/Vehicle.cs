namespace CarFactory.Models
{
    public class Vehicle
    {
        private string color;
        private string brand;
        private string vehicleType;

        public Vehicle(string color, string brand)
        {
            this.color = color;
            this.brand = brand;
        }

        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        public String GetVehicleType()
        {
            return this.vehicleType;
        }
    }
}