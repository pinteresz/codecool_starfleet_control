using codecool_starfleet_control;

namespace codecool_starfleet_control_test
{
    public class CargoShipTests
    {
        private CargoShip cargoShip;

        [SetUp]
        public void SetUp()
        {
            cargoShip = new CargoShip("TestCargoShip", 2023);
        }

        [Test]
        public void CargoShip_Initialization()
        {

            Assert.AreEqual("TestCargoShip", cargoShip.Name);
            Assert.AreEqual(2023, cargoShip.YearOfBuilt);
            Assert.AreEqual(CraftTypes.CargoShip, cargoShip.CraftType);
            Assert.IsTrue(cargoShip.IsInSpace);

            Dictionary<CargoTypes, int> shipment = cargoShip.Shipment;
            Assert.AreEqual(3, shipment.Count);
            Assert.IsTrue(shipment.ContainsKey(CargoTypes.Food));
            Assert.IsTrue(shipment.ContainsKey(CargoTypes.Medicine));
            Assert.IsTrue(shipment.ContainsKey(CargoTypes.Weapons));

            foreach (var cargoType in shipment.Keys)
            {
                int cargoQuantity = shipment[cargoType];
                Assert.GreaterOrEqual(cargoQuantity, 0);
                Assert.LessOrEqual(cargoQuantity, 5);
            }
        }
    }
}