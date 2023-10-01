using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Single_Responsibility_Principle.WithOut
{
    public class UserService
    {
        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                Console.WriteLine("Email is not an email");
            var user = new User(email, password);

            SendEmail(user);
        }

        public void Login(string email, string password)
        {
            Console.WriteLine("Login");
        }

        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendEmail(User message) => Console.WriteLine("send message");


    }
}
