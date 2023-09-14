using codecool_starfleet_control;

StarfleetControl _StarfleetControl = new StarfleetControl();

// creating ships
CargoShip _cargoship1 = _StarfleetControl.CreateCargoShip("CARGO1", 2100);
CargoShip _cargoship2 = _StarfleetControl.CreateCargoShip("CARGO2", 2150);
DiscoveryShip _discoveryship1 = _StarfleetControl.CreateDiscoveryShip("DISCOVERY1", 2100);
DiscoveryShip _discoveryship2 = _StarfleetControl.CreateDiscoveryShip("DISCOVERY2", 2200);
SpaceStation _spacestation1 = _StarfleetControl.CreateSpaceStation("STATION1", 2100);
SpaceStation _spacestation2 = _StarfleetControl.CreateSpaceStation("STATION2", 2120);

// add ships to fleet's list
_StarfleetControl.StarfleetSpaceCraftList.Add(_cargoship1);
_StarfleetControl.StarfleetSpaceCraftList.Add(_cargoship2);
_StarfleetControl.StarfleetSpaceCraftList.Add(_discoveryship1);
_StarfleetControl.StarfleetSpaceCraftList.Add(_discoveryship2);
_StarfleetControl.StarfleetSpaceCraftList.Add(_spacestation1);
_StarfleetControl.StarfleetSpaceCraftList.Add(_spacestation2);

// dock at spacestation
_cargoship1.DockAtSpaceStation(_spacestation1);
_cargoship2.DockAtSpaceStation(_spacestation1);
_discoveryship1.DockAtSpaceStation(_spacestation1);


// list about ships in space 
Console.WriteLine("Ships currently in space:");
var list = _StarfleetControl.IsInSpace();
foreach (var spacecraft in list)
{
    if (spacecraft.IsInSpace)
        Console.WriteLine($"{spacecraft.Name}");
}

// name and type of a ship
Console.WriteLine($"The type of {_cargoship1.Name} is {_cargoship1.TellTypeToOthers()}.");