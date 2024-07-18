using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class BasicAuthenticationService : IAuthenticationService 
    {
        public string UserName { get; set; } = "Admin";

        public string Password { get; set; } = "123";

        public bool AuthenticatteUser(User user)
        {
            bool flag ;

            int comparedUserResult = user.UserName.CompareTo(UserName);

            int comparedPasswordResult = user.Password.CompareTo(Password);

            flag = comparedUserResult == 0 && comparedPasswordResult == 0 ? true : false;

            return flag;


        }

        public bool AuthorizeUser(User user)
        {
            bool flag;
           if(user.Role == Role.Manger) 
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            return flag;
        }

      
    }
}
