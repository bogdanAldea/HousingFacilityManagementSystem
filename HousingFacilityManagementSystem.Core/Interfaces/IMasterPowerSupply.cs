using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Interfaces
{
    public interface IMasterPowerSupply : IMeasurable, IPriceable
    {
        public int Id { get; set; }
        public Utility Utility { get; set; }
    }
}
