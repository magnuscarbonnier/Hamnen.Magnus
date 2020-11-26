using static Hamnen.Helpers;

namespace Hamnen
{
    internal class Boat
    {
        public string Id { get; set; }
        public int Weight { get; set; }
        public int TopSpeed { get; set; }
        public int NumberOfSlotsInDock { get; set; }
        public int StaysForDays { get; set; }
        public BoatType Type { get; set; }
    }
    internal class CargoShip : Boat
    {
        public int ContainersOnShip { get; set; }
    }
    internal class SpeedBoat : Boat
    {
        public int HorsePower { get; set; }
    }
    internal class SailBoat : Boat
    {
        public int LengthInFeet { get; set; }
    }
}

