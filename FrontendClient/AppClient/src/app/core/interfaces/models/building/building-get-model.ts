import { ApartmentGetModel } from "../apartment/apartment-get-model";
import { MasterUtilityGetModel } from "../utilities/master-utility-get-model";

export interface BuildingGetModel 
{
    id: number;
    capacity: number;
    administratorId: number;
    apartments: ApartmentGetModel[];
    masterConsumableUtilities: MasterUtilityGetModel[];
}
