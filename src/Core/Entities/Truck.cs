using RhinoForge.Core.Entities.Bases;

namespace RhinoForge.Core.Entities
{
    public class Truck : EntityBase
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Axles { get; set; }
        public string Country { get; set; }
        public string Bodywork { get; set; }
    }
}