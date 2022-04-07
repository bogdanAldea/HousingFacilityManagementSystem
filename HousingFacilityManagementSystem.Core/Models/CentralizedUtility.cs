using Project.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class CentralizedUtility : ICentralizedUtility
    {

        public CentralizedUtility(Utility utility)
        {
            Utility = utility;
        }

        public Utility Utility { get; set; }
        public decimal Price { get; set; }
    }
}
