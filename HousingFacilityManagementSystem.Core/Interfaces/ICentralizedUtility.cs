using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Interfaces
{
    public interface ICentralizedUtility : IPriceable
    {
        public Utility Utility { get; set; }
        public decimal Price { get; set; }
    }
}
