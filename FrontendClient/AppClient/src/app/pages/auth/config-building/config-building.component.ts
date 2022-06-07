import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { map } from 'rxjs';
import { ApiRoutes } from 'src/app/core/api-routes/api-routes';
import { AdminProfileGetModel } from 'src/app/core/interfaces/models/user-profiles/admin-profile-get-model';
import { BuildingPostModel } from 'src/app/core/interfaces/models/building/building-post-model';
import { MasterUtilityPostModel } from 'src/app/core/interfaces/models/utilities/master-utility-post-model';
import { BuildingService } from 'src/app/core/services/building.service';

@Component({
  selector: 'app-config-building',
  templateUrl: './config-building.component.html',
  styleUrls: ['./config-building.component.css']
})
export class ConfigBuildingComponent implements OnInit {

  // Form groups inside the stepper
  capacityFormGroup: FormGroup;
  masterUtilityFormGroup: FormGroup;

  // Post model that will hold the form values
  buildingPostModel:  BuildingPostModel = {
    capacity: null,
    administratorId: null,
    masterConsumableUtilities: []
  }

  // Get model that will map the Admin profile response
  adminProfileGetModel: AdminProfileGetModel = {
    id: null,
    firstName: null,
    lastName: null,
    role: null,
    indentityId: null,
    building: null
  }

  constructor(private _formBuilder: FormBuilder, private httpClient: HttpClient, private buildingService: BuildingService, private router: Router) {}

  ngOnInit() {
    this.capacityFormGroup = this._formBuilder.group({
      capacity: ['', [Validators.required, Validators.min(3)]],
    });
    
    this.masterUtilityFormGroup = this._formBuilder.group({
      name: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(25)]],
      indexMeter: ['', [Validators.required, Validators.min(0)]],
      currentMonthIndex: ['', [Validators.min(0)]],
      price: ['', [Validators.required, Validators.min(0)]]
    });

    this.httpClient.get<AdminProfileGetModel>(ApiRoutes.AdminProfileRoutes.GET_BY_ID + 17)
    .pipe(
      map((response: AdminProfileGetModel) => this.adminProfileGetModel = response)
    )
    .subscribe((response) => {
      this.adminProfileGetModel = response
      console.log(this.adminProfileGetModel)
    })   
  }

  addUtility() 
  {
    var data: any = this.masterUtilityFormGroup.value;
    
    var util: MasterUtilityPostModel = {
      name: data["name"],
      indexMeter: data["indexMeter"],
      currentMonthIndex: data["currentMonthIndex"],
      price: data["price"]
    }

    this.buildingPostModel.masterConsumableUtilities.push(util)
    console.log(this.buildingPostModel)
  }

  setCapacity()
  {
    var capacity = this.capacityFormGroup.value["capacity"];
    this.buildingPostModel.capacity = capacity;
  }

  postBuildingModel()
  {
    this.buildingPostModel.administratorId = this.adminProfileGetModel.id;
    console.log(this.buildingPostModel)
    this.buildingService.postBuilding(this.buildingPostModel)
    .subscribe(response => {
      if (response.status === 201){
        this.router.navigate(["/dashboard"])
      }
    });
  }
}
