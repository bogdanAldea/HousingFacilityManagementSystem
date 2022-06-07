import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { map } from 'rxjs';
import { ApiRoutes } from 'src/app/core/api-routes/api-routes';
import { AdminProfileGetModel } from 'src/app/core/interfaces/models/user-profiles/admin-profile-get-model';
import { MasterUtilityGetModel } from 'src/app/core/interfaces/models/utilities/master-utility-get-model';

@Component({
  selector: 'app-admin-utilities',
  templateUrl: './admin-utilities.component.html',
  styleUrls: ['./admin-utilities.component.css']
})
export class AdminUtilitiesComponent implements OnInit {

  columns: string[] = ["Name", "Total Index Meter", "Current Month Index", "Price", "See detail"]
  adminProfileModel: AdminProfileGetModel;
  masterUtilities: MasterUtilityGetModel[];
  dataSource: MatTableDataSource<MasterUtilityGetModel> = new MatTableDataSource<MasterUtilityGetModel>([]);

  constructor(private httpClient: HttpClient) { }

  ngOnInit(): void {
    this.httpClient.get<AdminProfileGetModel>(ApiRoutes.AdminProfileRoutes.GET_BY_ID + 17)
    .pipe(
      map((response: AdminProfileGetModel) => this.masterUtilities = response.building.masterConsumableUtilities)
    )
    .subscribe(response => {
      this.dataSource.data = response
      console.log(this.dataSource)
    })
  }

}
