using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal interface IAuthenticationService
    {
        bool AuthenticatteUser(User user);

        bool AuthorizeUser(User user);
    }
}
