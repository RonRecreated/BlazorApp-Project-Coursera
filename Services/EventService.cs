using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public sealed class EventService
    {
        private readonly IReadOnlyList<Event> _events = new List<Event> 
        { 
            new() { Id = 1, Name = "Tech Conference", Date = new(2025, 5, 12), Location = "Orlando" }, 
            new() { Id = 2, Name = "Music Festival", Date = new(2025, 6, 20), Location = "Miami" }, 
            new() { Id = 3, Name = "Art Expo", Date = new(2025, 7, 5), Location = "Tampa" } 
        };

        public Task<IReadOnlyList<Event>> GetEventsAsync() => 
            Task.FromResult(_events); 

        public Task<Event?> GetEventByIdAsync(int id) => 
            Task.FromResult(_events.FirstOrDefault(e => e.Id == id));
    }
}
