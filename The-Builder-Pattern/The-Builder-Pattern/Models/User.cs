using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Builder_Pattern.Models
{
    public class User : IUserBuilder
    {
        private int _id;
        private string _name;
        private string _email;
        private string _password;


        public User(int id, string name, string email, string password)
        {
            _id = id;
            _name = name;
            _email = email;
            _password = password;
        }


        public int getId()
        {
            return _id;
        }

        public void setId(int id)
        {
            _id = id;
        }

        public string getNume()
        {
            return _name;
        }

        public void setNume(string nume)
        {
            _name = nume;
        }

        public string getEmail()
        {
            return _email;
        }

        public void setEmail(string email)
        {
            _email = email;
        }

        public string getPassword()
        {
            return _password;
        }

        public void setPassword(string password)
        {
            _password = password;
        }

        public User()
        {
        }

        public User getUser()
        {
            return this;
        }

        public User Id(int id)
        {
            this._id = id;
            return this;
        }

        public User Nume(string name)
        {
            this._name = name;
            return this;
        }

        public User Parola(string parola)
        {
            this._password = parola;
            return this;
        }

        public User Email(string email)
        {
            this._email = email;
            return this;
        }


    }
}
