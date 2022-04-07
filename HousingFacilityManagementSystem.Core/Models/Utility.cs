using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class Utility
    {

        public Utility(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
