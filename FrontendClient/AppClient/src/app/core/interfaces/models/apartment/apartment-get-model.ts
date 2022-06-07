import { BranchedUtilityGetModel } from "../utilities/branched-utility-get-model";
import { MasterUtilityGetModel } from "../utilities/master-utility-get-model";

export interface ApartmentGetModel 
{
    id: number;
    tenant: any;
    buildingId: number;
    numberInBuilding: number;
    paymentDebt: number;
    residents: number;
    surfaceArea: number;
    branchedUtilities: BranchedUtilityGetModel[]
}
