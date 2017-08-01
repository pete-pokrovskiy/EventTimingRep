namespace EventTiming.Web.Infrastructure.Security
{
    public interface IUserAuthenticationService
    {
        void SignIn(string userName, string password);
        void SignOut();
        bool IsAuthenticated();
    }
}