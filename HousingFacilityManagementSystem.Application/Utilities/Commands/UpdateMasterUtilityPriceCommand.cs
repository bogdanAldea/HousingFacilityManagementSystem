using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Utilities.Commands
{
    public class UpdateMasterUtilityPriceCommand : IRequest<MasterConsumableUtility>
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
    }
}
