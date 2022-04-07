using Project.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class Apartment
    {

        public Apartment(int numberInBuilding)
        {
            NumberInBuilding = numberInBuilding;
        }

        public int Id { get; set; }
        public int NumberInBuilding { get; set; }
        public int Residents { get; set; }
        public double SurfaceArea { get; set; }
        public List<IActivatablePowerSupply> PowerSupplies { get; set; } = new List<IActivatablePowerSupply>();
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();
        public double PaymentDebt { get; set; }
    }
}
