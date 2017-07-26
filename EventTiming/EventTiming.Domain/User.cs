using System;

namespace EventTiming.Domain
{
    public class User : IModificationHistory
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LasName { get; set; }
        public string EmailAddress { get; set; }
        public byte[] Password { get; set; }
        public bool IsAdmin { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
