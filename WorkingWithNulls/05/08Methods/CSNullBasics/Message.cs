namespace CSNullBasics
{
    class Message
    {
        public string? From { get; set; }
        public string Text { get; set; } = "";
        public string ToUpperFrom() => From.ToUpperInvariant();
    }
}
