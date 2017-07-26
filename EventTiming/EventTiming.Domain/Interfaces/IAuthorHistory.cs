namespace EventTiming.Domain
{
    public interface IAuthorHistory
    {
        int? UserId { get; set; }
        User User { get; set; }
    }
}