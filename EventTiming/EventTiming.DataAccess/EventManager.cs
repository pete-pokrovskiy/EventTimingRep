using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTiming.DataAccess
{
    public class EventManager
    {
        private EventTimingContext _dbContext;

        public EventManager(EventTimingContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
