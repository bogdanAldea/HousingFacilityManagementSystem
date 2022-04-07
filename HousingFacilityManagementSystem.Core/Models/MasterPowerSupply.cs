using Project.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class MasterPowerSupply : IMasterPowerSupply
    {

        public MasterPowerSupply(Utility utility)
        {
            Utility = utility;
        }

        public int Id { get; set; }
        public int IndexMeter { get; set; }
        public int CurrentMonthIndex { get; set; }
        public decimal Price { get; set; }
        public Utility Utility { get; set; }
    }
}
