using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codecool_starfleet_control
{
    public abstract class SpaceCraft
    {
        public Guid RegistrationCode { get; protected set; }
        public string Name { get; protected set; }

        public int YearOfBuilt { get; protected set; }

        public CraftTypes CraftType { get; protected set; }

        public SpaceCraft(string name, int yearOfBuilt)
        {
            RegistrationCode = Guid.NewGuid();
            Name = name;
            YearOfBuilt = yearOfBuilt;

        }

        public bool IsInSpace { get; set; }

        public Type TellTypeToOthers()
        {
            return this.GetType();
        }

    }
}
