using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codecool_starfleet_control
{
    public class CargoShip : MobileSpaceCraft
    {
        public Dictionary<CargoTypes, int> Shipment { get; set; }

        public CargoShip(string name, int yearOfBuilt) : base(name, yearOfBuilt)
        {
            Name = name;
            YearOfBuilt = yearOfBuilt;
            RegistrationCode = Guid.NewGuid();
            CraftType = CraftTypes.CargoShip;
            Shipment = InitializeCargo();
            IsInSpace = true;
        }

        public Dictionary<CargoTypes, int> InitializeCargo()
        {
            Shipment = new Dictionary<CargoTypes, int>();
            Random random = new Random();
            Shipment.Add(CargoTypes.Food, random.Next(0, 6));
            Shipment.Add(CargoTypes.Medicine, random.Next(0, 6));
            Shipment.Add(CargoTypes.Weapons, random.Next(0, 6));

            return Shipment;
        }

        public override void DockAtSpaceStation(SpaceStation spaceStation)
        {
            spaceStation.DockShip(this);
            Console.WriteLine($"Cargo Ship {RegistrationCode} is docking.");
            Console.WriteLine($"Cargo Ship {RegistrationCode} is carrying the following cargos: ");
            foreach (var cargo in Shipment)
            {
                Console.WriteLine($"Cargo type: {cargo.Key} and quantity: {cargo.Value}.");
            }
            Shipment.Clear();
            InitializeCargo();
        }

    }
}
