import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ApiRoutes } from '../api-routes/api-routes';
import { BuildingPostModel } from '../interfaces/models/building/building-post-model';

@Injectable({
  providedIn: 'root'
})
export class BuildingService {

  constructor(private htttpClient: HttpClient) { }

  postBuilding(model: BuildingPostModel) {
    return this.htttpClient.post<BuildingPostModel>(ApiRoutes.BuildingRoutes.POST, model, {observe: "response"});
  }

  getBuildingByAdmin(adminId: number) {
    
  }
}
