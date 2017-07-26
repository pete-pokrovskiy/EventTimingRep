using System;

namespace EventTiming.Domain
{
    public class EventItem : IModificationHistory, IAuthorHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}