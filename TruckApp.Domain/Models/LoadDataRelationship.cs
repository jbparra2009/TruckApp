namespace TruckApp.Domain.Models
{
    public class LoadDataRelationship
    {
        public int LoadId { get; set; }
        public Load Load { get; set; }

        public int BrokerId { get; set; }
        public Broker Broker { get; set; }

        public int DispatchId { get; set; }
        public Dispatch Dispatch { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public int FactoryId { get; set; }
        public Factory Factory { get; set; }

        public int TrailerId { get; set; }
        public Trailer Trailer { get; set; }

        public int TruckId { get; set; }
        public Truck Truck { get; set; }
    }
}
