using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventTiming.Web.Infrastructure.Security
{
    public class UserAuthenticationService : IUserAuthenticationService
    {
        public void SignIn(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public void SignOut()
        {
            throw new NotImplementedException();
        }

        public bool IsAuthenticated()
        {
            throw new NotImplementedException();
        }
    }
}