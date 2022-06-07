using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Options
{
    public class OperationResult<T>
    {
        public T Payload { get; set; }
        public bool IsError { get; set; }
        public int ErrorCode { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }
}
