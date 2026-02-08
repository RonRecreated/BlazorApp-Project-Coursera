using EventEaseApp.Models;
using System.Collections.Concurrent;

namespace EventEaseApp.Services
{
    public sealed class AttendanceService
    {
        private readonly ConcurrentBag<EventAttendance> _attendance = new();

        public void RecordAttendance(int eventId, string name, string email)
        {
            _attendance.Add(new EventAttendance
            {
                EventId = eventId,
                Name = name,
                Email = email,
                Timestamp = DateTime.Now
            });
        }

        public IEnumerable<EventAttendance> GetAttendanceForEvent(int eventId) => 
            _attendance.Where(a => a.EventId == eventId);

        public int GetAttendanceCount(int eventId) => 
            _attendance.Count(a => a.EventId == eventId);
    }
}