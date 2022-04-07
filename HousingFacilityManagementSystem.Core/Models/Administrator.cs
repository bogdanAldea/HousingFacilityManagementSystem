using Project.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class Administrator : IUser
    {

        public Administrator(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Building Building { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Username { get; set; }
    }
}
