using System;
using System.Diagnostics.CodeAnalysis;

namespace GameConsole
{
    class PlayerCharacter
    {
        private string _name = GenerateName();

        [AllowNull]
        public string Name 
        {
            get => _name;
            set => _name = value ?? GenerateName();
        }

        private string? _bio;

        [DisallowNull]
        public string? Bio
        {
            get => _bio;
            set => _bio = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }

        private static string GenerateName()
        {
            var names = new string[] { "Amrit", "Gentry", "Sarah" };

            var random = new Random();

            return names[random.Next(0, 3)];
        }
    }
}
