using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Builder_Pattern.Models
{
    public interface IUserBuilder
    {

        User Id(int id);

        User Nume(string nume);

        User Parola(string parola);

        User Email(string email);

        static User build()
        {
            return new User();
        }

    }



}
