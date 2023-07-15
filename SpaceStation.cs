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
    }

}
