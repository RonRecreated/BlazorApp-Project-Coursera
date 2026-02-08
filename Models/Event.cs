namespace EventEaseApp.Models
{
    public sealed class Event
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public DateTime Date { get; init; } = DateTime.Now;
        public string Location { get; init; } = string.Empty;
    }
}
