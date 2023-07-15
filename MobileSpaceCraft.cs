using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codecool_starfleet_control
{
    public abstract class MobileSpaceCraft : SpaceCraft
    {
        public int MaxSpeed { get; protected set; }
        public MobileSpaceCraft(string name, int builtOfYear) : base(name, builtOfYear)
        {
            RegistrationCode = Guid.NewGuid();
            Name = name;
            YearOfBuilt = builtOfYear;
            IsInSpace = true;

            if (YearOfBuilt < 2150)
            {
                MaxSpeed = 150 - 30;
            }
            if (YearOfBuilt > 2200)
            {
                MaxSpeed = 150 + 15;
            }
            else
            {
                MaxSpeed = 150;
            }
        }

        public abstract void DockAtSpaceStation(SpaceStation spaceStation);
    }
}
