import { BuildingGetModel } from "../building/building-get-model";

export interface AdminProfileGetModel 
{
    id: number;
    firstName: string;
    lastName: string;
    role: number;
    indentityId: string;
    building: BuildingGetModel;
}
