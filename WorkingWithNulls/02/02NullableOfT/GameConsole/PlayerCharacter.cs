using System;

namespace GameConsole
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        public Nullable<int> DaysSinceLastLogin { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }

        public PlayerCharacter()
        {
            DateOfBirth = null;
            DaysSinceLastLogin = null;
        }
    }
}
