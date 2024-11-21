using aquesstQuestions.Parking;
using aquesstQuestions.Parking.Enum;
using aquesstQuestions.Vehicles;
using aquesstQuestions.Vehicles.Enum;

namespace aquesstQuestions
{
    public class QuestionTwo
    {
        Garage _garage = new Garage(4, 1);
        Lot _lot = new Lot(6);

        //Returns false if unable to park, true if able to park and parks car
        public bool ParkVehicle (ParkingType parkingType, BaseVehicle vehicle)
        {
            bool isParkingAvailable = false;
            if (parkingType == ParkingType.Garage)
            {
                bool isCompactAvailable = _garage.NumberOfVaccantCompactSpaces() > 0;
                bool isNonCompactAvailable = _garage.NumberOfVaccantNonCompactSpaces() > 0;
                
                if (vehicle.Type == VehicleType.Car || vehicle.Type == VehicleType.Motorcycle)
                {
                    int maxVehicleWeight = 1500;
                    if (vehicle.Weight < maxVehicleWeight && isCompactAvailable)
                    {
                        isParkingAvailable = true;
                        _garage.CompactVehicles.Add(vehicle);
                    } 
                    else if (isNonCompactAvailable)
                    {
                        isParkingAvailable = true;
                        _garage.NonCompactVehicles.Add(vehicle);
                    }
                }
            }
            else
            {
                bool isSpaceAvailable = _lot.NumberOfVaccantSpaces() > 0;

                if (isSpaceAvailable)
                {
                    isParkingAvailable = true;
                    _lot.Vehicles.Add(vehicle);
                }
            }

            return isParkingAvailable;
        }
    }
}
