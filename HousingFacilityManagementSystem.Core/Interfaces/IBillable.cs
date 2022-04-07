using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Interfaces
{
    public interface IBillable
    {
        public bool AmountToPay { get; set; }
    }
}
