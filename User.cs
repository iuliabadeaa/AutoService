using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceCuNET;

namespace AutoService
{
    internal class User
    {
        string name, surname, email, password;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public User(string Name, string Surname,string Email,string Password)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Password = Password;
        }
        public User(string Email,string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }
        public User(string Email)
        {
            this.Email=Email;
        }
    }
}
