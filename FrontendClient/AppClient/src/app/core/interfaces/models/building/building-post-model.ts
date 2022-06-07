import { MasterUtilityPostModel } from "../utilities/master-utility-post-model";

export interface BuildingPostModel 
{
    capacity: number;
    administratorId: number;
    masterConsumableUtilities: MasterUtilityPostModel[];
}
