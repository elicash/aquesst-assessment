using aquesstQuestions.Vehicles.Enum;

namespace aquesstQuestions.Vehicles
{
    public class BaseVehicle
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int NumberOfWheels { get; set; }
        public float Length { get; set; }
        public float Weight { get; set; }
        public int MaxNumberOfPassengers { get; set; }
        public  VehicleType Type { get; set; }

        public BaseVehicle(VehicleType type)
        {
            Type = type;
        }

        public BaseVehicle()
        {

        }
    }
}
