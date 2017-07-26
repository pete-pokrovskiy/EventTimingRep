using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventTiming.Domain;

namespace EventTiming.DataAccess
{
    public class EventManager
    {
        private EventTimingContext _dbContext;

        public EventManager(EventTimingContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateEvent(Event @event)
        {
            _dbContext.Events.Add(@event);
            _dbContext.SaveChanges();
        }

        public void UpdateEvent(Event @event)
        {
            _dbContext.Events.Attach(@event);

            //либо
            //_dbContext.Entry(@event).State = EntityState.Modified;

            _dbContext.SaveChanges();
        }

        public void DeleteEventById(int eventId)
        {
            var eventToDelete = _dbContext.Events.Find(eventId);
            _dbContext.Events.Remove(eventToDelete);
            _dbContext.SaveChanges();
        }

        public void DeleteEvent(Event @event)
        {
            _dbContext.Events.Attach(@event);

            //либо
            //_dbContext.Entry(@event).State = EntityState.Deleted;

            _dbContext.Events.Remove(@event);
            _dbContext.SaveChanges();

        }


    }
}
