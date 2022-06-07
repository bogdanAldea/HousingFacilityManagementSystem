import { Component, OnInit } from '@angular/core';
import { ApartmentTable } from 'src/app/core/interfaces/tables/apartment-table';

@Component({
  selector: 'app-admin-apartments',
  templateUrl: './admin-apartments.component.html',
  styleUrls: ['./admin-apartments.component.css']
})
export class AdminApartmentsComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  
  columns: string[] = ["Number", "Tenant", "Residents", "Surface Area", "Payment", "See detail"]

  tableList: ApartmentTable[] = [
    {tenant: "User 1", numberInBuilding: 1, residents: 2, surfaceArea: 55.76, payment: 250.00},
    {tenant: "User 2", numberInBuilding: 2, residents: 1, surfaceArea: 55.76, payment: 250.00},
    {tenant: "User 3", numberInBuilding: 3, residents: 1, surfaceArea: 55.76, payment: 250.00},
    {tenant: "User 4", numberInBuilding: 4, residents: 3, surfaceArea: 55.76, payment: 250.00},
    {tenant: "", numberInBuilding: 5, residents: 0, surfaceArea: 55.76, payment: 0.00},
    {tenant: "", numberInBuilding: 6, residents: 0, surfaceArea: 55.76, payment:0.00},
    {tenant: "User 7", numberInBuilding: 7, residents: 1, surfaceArea: 55.76, payment: 250.00},
  ]

  dataSource = this.tableList;
}
