class Program
{
    /// <summary>
    /// - A record instance is immutable while class instance' properties can be modified
    /// - Immutability: Objects that should'nt change should'nt be changeable
    /// - Records can have bodies containing everything a class can have in its body
    /// - Constructor and deconstructor is only generated for positional properties
    /// - A mix of positional and non-positional properties in the body is possible
    /// - Records can only derive / inherit other records
    /// - Derived positional records have to repeat all property declarations
    /// - A record can be sealed, and its not possible to inherit from sealed records
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        var summerEvent = new EventRecord("Ukenya Barbeque", "Zezna studenka");
        var similarSummerEvent = summerEvent with { location = "Hubanovo Namestie"};

        var summerPerformance = new PerformanceRecord()
        {
            Event = summerEvent,
            Artist = "Wakanda Wision",
            Album = "Epic lyrics",
            Duration = 90
        };
        var similarPerfomance = summerPerformance with { Duration = 120, Event = similarSummerEvent };

        Console.WriteLine(summerPerformance.GetPerformanceInfo());
        Console.WriteLine(similarPerfomance.GetPerformanceInfo());
    }

    public record EventRecord(string? name, string? location)
    {
        public string Title()
        {
            return $"{name} - {location}";
        }
    };

    public record PerformanceRecord()
    {
        public string Artist { get; init; } = string.Empty;
        public string Album { get; init; } = string.Empty;
        public int Duration { get; init;}
        public EventRecord? Event { get; init;}

        public PerformanceRecord(string artist, string album, int duration, EventRecord @event): this()
        {
            Artist = artist;
            Album = album; 
            Duration = duration;
            Event = @event;
        }

        public string GetPerformanceInfo()
        {
            return $"{Artist} will perform album {Album} for {Duration} minutes during {Event?.name} at {Event?.location}";
        }
    }
}
