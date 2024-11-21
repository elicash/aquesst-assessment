using aquesstQuestions.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aquesstQuestions.Parking
{
    public class Lot : BaseParking
    {
        public List<BaseVehicle> Vehicles { get; }
        public int NumberOfVaccantSpaces()
        {
            return NumberOfSpaces - Vehicles.Count;
        }

        public Lot(int numSpaces)
        {
            NumberOfSpaces = numSpaces;
            Vehicles = new List<BaseVehicle>();
        }
    }
}
