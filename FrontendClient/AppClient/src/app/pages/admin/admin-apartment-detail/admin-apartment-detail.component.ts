import { HttpClient, HttpParams } from '@angular/common/http';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, ActivatedRouteSnapshot, Router } from '@angular/router';
import { map } from 'rxjs';
import { ApiRoutes } from 'src/app/core/api-routes/api-routes';
import { ApartmentGetModel } from 'src/app/core/interfaces/models/apartment/apartment-get-model';
import { BranchedUtilityGetModel } from 'src/app/core/interfaces/models/utilities/branched-utility-get-model';

@Component({
  selector: 'app-admin-apartment-detail',
  templateUrl: './admin-apartment-detail.component.html',
  styleUrls: ['./admin-apartment-detail.component.css']
})
export class AdminApartmentDetailComponent implements OnInit {
  currentApartmentId: number;
  brachedUtilityDataSource: MatTableDataSource<BranchedUtilityGetModel> = new MatTableDataSource<BranchedUtilityGetModel>([])
  columns: string[] = ["Name", "Branched Status", "Index Meter", "Current Month Index", "Payment", "See Detail"]
  apartmentModel: ApartmentGetModel = {
    id: 0,
    tenant: undefined,
    buildingId: 0,
    numberInBuilding: 0,
    paymentDebt: 0,
    residents: 0,
    surfaceArea: 0,
    branchedUtilities: []
  }
  apartmentPutForm = this.formBuilder.group({
    residents: ["", [Validators.required, Validators.min(0)]],
    surfaceArea: [this.apartmentModel.surfaceArea, [Validators.required, Validators.min(0)]],
  })

  disabledIcon: string = "cancel"
  activeIcon: string = "check_circle"

  
  constructor(private route: ActivatedRoute, private httpClient: HttpClient, private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.currentApartmentId = parseInt(this.route.snapshot.paramMap.get("id"));
    this.httpClient.get<ApartmentGetModel>(ApiRoutes.ApartmentRoutes.GET_BY_ID + this.currentApartmentId)
    .pipe(
      map((response: ApartmentGetModel) => this.apartmentModel = response)
    )
    .subscribe((response: ApartmentGetModel) => {
      this.apartmentModel = response
      this.apartmentPutForm.patchValue({"residents": response.residents, "surfaceArea": response.surfaceArea})
      this.brachedUtilityDataSource.data = this.apartmentModel.branchedUtilities
      console.log(this.brachedUtilityDataSource.data)
    })

  }

  updateApartment()
  {
    var data: any = {
      residents: this.apartmentPutForm.value["residents"],
      surfaceArea: this.apartmentPutForm.value["surfaceArea"],
      tenantId: null
    }

    var params = new HttpParams();
    params.set("id", this.currentApartmentId)

    this.httpClient.put<any>(ApiRoutes.ApartmentRoutes.GET_BY_ID + this.currentApartmentId + "/residents", data)
    .subscribe(() => this.ngOnInit())
    this.httpClient.put<any>(ApiRoutes.ApartmentRoutes.GET_BY_ID + this.currentApartmentId + "/surface-area", data)
    .subscribe(() =>this.ngOnInit())
    

    
  }

}
