using aquesstQuestions;
using aquesstQuestions.Parking.Enum;
using aquesstQuestions.Vehicles;
using aquesstQuestions.Vehicles.Enum;
using System.ComponentModel.DataAnnotations;

namespace aquesstQuestionsTests
{
    public class QuestionTwoTests
    {
        [Fact]
        public void FiveCarsAndAMotorcycle_FirstThreeCarsAndMotorcycleCanParkInGarage()
        {
            var questions = new QuestionTwo();

            var car = new Car();
            car.Weight = 3000;

            var carTwo = new Car();
            carTwo.Weight = 3000;

            var carThree = new Car();
            carThree.Weight = 3000;

            var carFour = new Car();
            carFour.Weight = 3000;

            var carFive = new Car();
            carFive.Weight = 3000;

            var motorcyle = new Motorcycle();
            motorcyle.Weight = 500;

            var bus = new Bus();

            var answerOne = questions.ParkVehicle(ParkingType.Garage, car);
            var answerTwo = questions.ParkVehicle(ParkingType.Garage, carTwo);
            var answerThree = questions.ParkVehicle(ParkingType.Garage, carThree);
            var answerFour = questions.ParkVehicle(ParkingType.Garage, carFour);
            var answerFive = questions.ParkVehicle(ParkingType.Garage, carFive);
            var answerSix = questions.ParkVehicle(ParkingType.Garage, motorcyle);

            Assert.True(answerOne);
            Assert.True(answerTwo);
            Assert.True(answerThree);
            Assert.False(answerFour);
            Assert.False(answerFive);
            Assert.True(answerSix);
        }

        [Fact]
        public void SevenVehiclesTryToParkInALot_TheLastIsTurnedAway()
        {
            var questions = new QuestionTwo();

            var car = new Car();
            var carTwo = new Car();
            var carThree = new Car();
            var carFour = new Car();
            var carFive = new Car();
            var motorcyle = new Motorcycle();
            var bus = new Bus();

            var answerOne = questions.ParkVehicle(ParkingType.Lot, car);
            var answerTwo = questions.ParkVehicle(ParkingType.Lot, bus);
            var answerThree = questions.ParkVehicle(ParkingType.Lot, carThree);
            var answerFour = questions.ParkVehicle(ParkingType.Lot, carFour);
            var answerFive = questions.ParkVehicle(ParkingType.Lot, carFive);
            var answerSix = questions.ParkVehicle(ParkingType.Lot, motorcyle);
            var answerSeven = questions.ParkVehicle(ParkingType.Lot, carTwo);


            Assert.True(answerOne);
            Assert.True(answerTwo);
            Assert.True(answerThree);
            Assert.True(answerFour);
            Assert.True(answerFive);
            Assert.True(answerSix);
            Assert.False(answerSeven);
        }

        [Fact]
        public void BusTriesToParkInAnEmptyGarage_BusIsTurnedAway()
        {
            var questions = new QuestionTwo();

            var bus = new Bus();

            var answerOne = questions.ParkVehicle(ParkingType.Garage, bus);

            Assert.False(answerOne);
        }
    }
}