class Program
{
    /// <summary>
    /// - A record instance is immutable while class instance' properties can be modified
    /// - Immutability: Objects that should'nt change should'nt be changeable
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        var ubuntuEvent = new Event("Ubuntu", "Zelezna Studenka");
        var summerEvent = new EventRecord("Kenyan BBQ", "Lanfranconi");
        var similarSummerEvent = summerEvent with { location = "Hubanovo Namestie"};
    }

    public class Event
    {
        public string? Name { get; set; }
        public string? Location { get; set; }

        public Event(string name, string location)
        {
            Name = name;
            Location = location;
        }
    }

    public record EventRecord(string? name, string? location);
}
