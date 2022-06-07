import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { catchError, map, throwError } from 'rxjs';
import { ApiRoutes } from 'src/app/core/api-routes/api-routes';
import { InfoCard } from 'src/app/core/interfaces/cards/info-card';
import { ApartmentGetModel } from 'src/app/core/interfaces/models/apartment/apartment-get-model';
import { AdminProfileGetModel } from 'src/app/core/interfaces/models/user-profiles/admin-profile-get-model';

@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.css']
})
export class AdminDashboardComponent implements OnInit {

  adminProfileModel: AdminProfileGetModel;
  columns: string[] = ["Number", "Tenant", "Residents", "Surface Area", "Debt", "See detail"]
  dataSource: MatTableDataSource<ApartmentGetModel> = new MatTableDataSource<ApartmentGetModel>([])
  adminInfoCard: InfoCard = {
    cardTitle: '',
    cardSubtitle: "Administrator",
    cardIcon: "manage_accounts"
  }

  buildingInfoCard: InfoCard = {
    cardTitle: '',
    cardSubtitle: "Apartment Capacity",
    cardIcon: "home_filled"
  }

  occupacyCardInfo: InfoCard = {
    cardTitle: "",
    cardSubtitle: "Occupied Apartments",
    cardIcon: "reduce_capacity",
  }

  residentsInfoCard: InfoCard = {
    cardTitle: "",
    cardSubtitle: "Total Residents",
    cardIcon: "groups",
  }

  constructor(private httpClient: HttpClient) { }

  ngOnInit(): void {
    this.httpClient.get<AdminProfileGetModel>(ApiRoutes.AdminProfileRoutes.GET_BY_ID + 17)
    .pipe(
      map((response: AdminProfileGetModel) => this.adminProfileModel = response)
    )
    .subscribe((response: AdminProfileGetModel) => {
      console.log(response)
      this.dataSource.data = response.building.apartments
      this.adminInfoCard.cardTitle = `${response.firstName} ${response.lastName}`
      this.buildingInfoCard.cardTitle = response.building.capacity;
      this.occupacyCardInfo.cardTitle = response.building.apartments
        .filter(apartment => apartment.residents > 0).length
      this.residentsInfoCard.cardTitle = response.building.apartments
        .filter(apartment => apartment.residents)
        .reduce((accumulated, apartment) => accumulated + apartment.residents, 0)
    })
   }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

}
