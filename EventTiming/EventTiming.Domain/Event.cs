﻿using System;
using System.Collections.Generic;

namespace EventTiming.Domain
{
    public class Event : IModificationHistory, IAuthorHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime CreatedOn { get; set; }

        public List<EventItem> EventItems { get; set; } 


        public DateTime ModifiedOn { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
