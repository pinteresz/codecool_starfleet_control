using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codecool_starfleet_control
{
    public class StarfleetContol
    {
        public List<SpaceCraft> StarfleetSpaceCraftList { get; private set; }

        public StarfleetContol()
        {
            StarfleetSpaceCraftList = new List<SpaceCraft>();
        }

        public void AddToStarfleetSpaceCraftList(SpaceCraft spaceCraft)
        {
            Console.WriteLine($"Spacecraft {spaceCraft.Name}, {spaceCraft.CraftType} has been added to the StarfleetSpaceCraftList.");
            StarfleetSpaceCraftList.Add(spaceCraft);
        }

        public SpaceStation CreateSpaceStation(string name, int yearOfBuilt)
        {
            SpaceStation spaceStation = new SpaceStation(name, yearOfBuilt);
            Console.WriteLine($"SpaceStation {spaceStation.Name} has been created.");
            return spaceStation;
        }

        public DiscoveryShip CreateDiscoveryShip(string name, int yearOfBuilt)
        {
            DiscoveryShip discoveryShip = new DiscoveryShip(name, yearOfBuilt);
            Console.WriteLine($"DiscoveryShip {discoveryShip.Name} has been created.");
            return discoveryShip;
        }

        public CargoShip CreateCargoShip(string name, int yearOfBuilt)
        {
            CargoShip cargoShip = new CargoShip(name, yearOfBuilt);
            Console.WriteLine($"CargoShip {cargoShip.Name} has been created.");
            return cargoShip;
        }


        public List<SpaceCraft> IsInSpace()
        {
            return StarfleetSpaceCraftList.Where(x => x.IsInSpace).ToList();
        }

    }
}
