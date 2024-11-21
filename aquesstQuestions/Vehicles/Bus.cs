using aquesstQuestions.Vehicles.Enum;

namespace aquesstQuestions.Vehicles
{
    public class Bus : BaseVehicle
    {
        public bool IsSchoolBus { get; set; }

        public Bus ()
        {
            Type = VehicleType.Bus;
        }
    }
}
