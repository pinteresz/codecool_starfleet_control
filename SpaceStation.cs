using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace codecool_starfleet_control
{
    public class SpaceStation : SpaceCraft
    {
        private List<SpaceCraft> dockedCrafts { get; set; }

        private int maxNumberToDock = 2;

        public SpaceStation(string name, int yearOfBuilt) : base(name, yearOfBuilt)
        {
            Name = name;
            YearOfBuilt = yearOfBuilt;
            RegistrationCode = Guid.NewGuid();
            dockedCrafts = new List<SpaceCraft>();
            CraftType = CraftTypes.SpaceStation;
            IsInSpace = false;
        }
        public void DockShip(MobileSpaceCraft spacecraft)
        {
            if (dockedCrafts.Count < maxNumberToDock)
            {
                dockedCrafts.Add(spacecraft);
                spacecraft.IsInSpace = false;
                Console.WriteLine($"Ship {spacecraft.Name} docked at Space Station {RegistrationCode}");
            }
            else
            {
                Console.WriteLine($"Sorry but the spaceship {spacecraft.Name} can not dock here, there are no available docking slots.");
            }
        }

        public void UndockShip(SpaceCraft spacecraft)
        {
            dockedCrafts.Remove(spacecraft);
            spacecraft.IsInSpace = true;
        }
    }

}
