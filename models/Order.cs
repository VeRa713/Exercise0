namespace CarFactory.Models
{
    public class Order
    {
        private List<Vehicle> vehicles;

        public Order()
        {
            this.vehicles = new List<Vehicle>();
        }

        public void AddTransaction(Vehicle v)
        {
            this.vehicles.Add(v);
        }

        public List<Vehicle> GetVehicles()
        {
            return this.vehicles;
        }
    }
}

