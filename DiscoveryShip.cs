using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codecool_starfleet_control
{
    public class DiscoveryShip : MobileSpaceCraft
    {
        private List<Tuple<DateTime, string>> DockingLogs { get; set; }
        public DiscoveryShip(string name, int yearOfBuilt) : base(name, yearOfBuilt)
        {
            Name = name;
            YearOfBuilt = yearOfBuilt;
            RegistrationCode = Guid.NewGuid();
            CraftType = CraftTypes.DiscoveryShip;
            IsInSpace = true;
            DockingLogs = new List<Tuple<DateTime, string>>();

        }

        public override void DockAtSpaceStation(SpaceStation spaceStation)
        {
            spaceStation.DockShip(this);
            Console.WriteLine($"Discovery Ship {RegistrationCode} is docking.");
            SaveDockingLog(spaceStation);
        }

        public void SaveDockingLog(SpaceStation spaceStation)
        {
            DockingLogs.Add(Tuple.Create(DateTime.Now, spaceStation.RegistrationCode.ToString()));
        }

    }
}
