using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Single_Responsibility_Principle.With
{
    public class User
    {

        private readonly string _email;
        private readonly string _password;

        public User(string email, string password)
        {
            _email = email;
            _password = password;
        }


    }
}
