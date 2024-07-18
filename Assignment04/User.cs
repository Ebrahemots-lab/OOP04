using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class User
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }
    }


    enum Role 
    {
        User,
        Manger
    }
}
