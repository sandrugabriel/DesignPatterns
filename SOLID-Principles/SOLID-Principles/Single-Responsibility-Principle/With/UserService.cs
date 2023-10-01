using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Single_Responsibility_Principle.With
{
    public class UserService
    {
        public void Register(string email, string password)
        {
            var emailService = new EmailService();
            if (!emailService.ValidateEmail(email))
                Console.WriteLine("Email is not an email");
            var user = new User(email, password);

            emailService.SendEmail(user);
        }

        public void Login(string email, string password)
        {
            Console.WriteLine("Login");
        }


    }
}
