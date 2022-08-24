namespace CSNullBasics
{
    public class Message
    {
        public string? From { get; set; }
        public string Text { get; set; } = string.Empty;
        public string? ToUpperFrom() => From?.ToUpperInvariant();
    }
}
