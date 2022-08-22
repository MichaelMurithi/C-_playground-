using System;

namespace GameConsole
{
    class NullDefence : ISpecialDefence
    {
        public int CalculateDamageReduction()
        {
            return 0; // "no op" or "do nothing" behavior
        }
    }
}
