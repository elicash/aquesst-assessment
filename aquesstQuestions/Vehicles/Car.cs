using aquesstQuestions.Vehicles.Enum;

namespace aquesstQuestions.Vehicles
{
    public class Car : BaseVehicle
    {
        public bool HasSunRoof { get; set; }

        public Car()
        {
            Type = VehicleType.Car;
        }
    }
}
