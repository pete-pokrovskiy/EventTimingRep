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

        //важно делать свойство nullable, чтобы не было cascade delete - если удаляем пользователя, то не удаляем событие
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}