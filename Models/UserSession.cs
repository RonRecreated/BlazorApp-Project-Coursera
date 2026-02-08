namespace EventEaseApp.Models
{
    public class UserSession
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public bool IsRegistered { get; set; }
        public int? RegisteredEventId { get; set; }
    }
}
