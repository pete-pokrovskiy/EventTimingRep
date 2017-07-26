using System;

namespace EventTiming.Domain
{
    public interface IModificationHistory
    {
        DateTime CreatedOn { get; set; }
        DateTime ModifiedOn { get; set; }
    }
}