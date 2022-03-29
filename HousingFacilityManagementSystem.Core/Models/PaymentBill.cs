using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core
{
    public class PaymentBill
    {
        List<ActivatablePowerSupply> PowerSupplies { get; set; }
        List<CentralizedGeneralUtility> GeneralUtilities { get; set; }


    }
}
