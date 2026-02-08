using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public sealed class UserSessionService
    {
        private readonly UserSession _session = new();

        public UserSession GetSession() => _session;

        public void SetUser(string name, string email)
        {
            _session.Name = name;
            _session.Email = email;
        }

        public void MarkRegistered(int eventId)
        {
            _session.IsRegistered = true;
            _session.RegisteredEventId = eventId;
        }

        public void Clear()
        {
            _session.Name = null;
            _session.Email = null;
            _session.IsRegistered = false;
            _session.RegisteredEventId = null;
        }
    }
}
