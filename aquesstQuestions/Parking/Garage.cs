using aquesstQuestions.Vehicles;

namespace aquesstQuestions.Parking
{
    public class Garage : BaseParking
    {
        public int NumberOfCompactSpaces { get; }

        public List<BaseVehicle> NonCompactVehicles { get; }

        public List<BaseVehicle> CompactVehicles { get; }

        public int NumberOfVaccantCompactSpaces()
        {
            return NumberOfCompactSpaces - CompactVehicles.Count;
        }

        public int NumberOfVaccantNonCompactSpaces()
        {
            return NumberOfSpaces - NumberOfCompactSpaces - NonCompactVehicles.Count;
        }

        public Garage(int numSpaces, int numCompactSpaces)
        {
            NumberOfCompactSpaces = numCompactSpaces;
            NumberOfSpaces = numSpaces;
            NonCompactVehicles = new List<BaseVehicle>();
            CompactVehicles = new List<BaseVehicle>();
        }
    }
}
