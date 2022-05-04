using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Exceptions
{
    public class EntityIdNotFoundException : Exception
    {
        public EntityIdNotFoundException() { }
        public EntityIdNotFoundException(string message) : base(message) { }
        public EntityIdNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
