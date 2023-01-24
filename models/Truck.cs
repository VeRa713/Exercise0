namespace CarFactory.Models
{
    public class Truck
    {
        private string model;
        private float capacity;

        private Truck(string model, float capacity){
            this.model = model;
            this.capacity = capacity;
        }
    }
}