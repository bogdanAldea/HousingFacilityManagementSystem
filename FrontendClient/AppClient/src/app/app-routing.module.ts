import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BaseLayoutComponent } from './layouts/base-layout/base-layout.component';
import { DashboardLayoutComponent } from './layouts/dashboard-layout/dashboard-layout.component';
import { AdminDashboardComponent } from './pages/admin/admin-dashboard/admin-dashboard.component';
import { AdminApartmentsComponent } from './pages/admin/admin-apartments/admin-apartments.component';
import { LoginComponent } from './pages/auth/login/login.component';
import { RegisterComponent } from './pages/auth/register/register.component';
import { HomepageComponent } from './pages/home/homepage/homepage.component';
import { AdminUtilitiesComponent } from './pages/admin/admin-utilities/admin-utilities.component';
import { AdminApartmentDetailComponent } from './pages/admin/admin-apartment-detail/admin-apartment-detail.component';
import { AdminApartmentEditComponent } from './pages/admin/admin-apartment-edit/admin-apartment-edit.component';
import { ConfigBuildingComponent } from './pages/auth/config-building/config-building.component';
import { AdminMasterUtilityDetailComponent } from './pages/admin/admin-master-utility-detail/admin-master-utility-detail.component';

const routes: Routes = [
  { 
    path: "dashboard",
    component: DashboardLayoutComponent,
    children: [
      { path: "", component: AdminDashboardComponent },
      { path: "apartments", component: AdminApartmentsComponent },
      { path: "apartment-detail/:id", component: AdminApartmentDetailComponent },
      { path: "apartment-edit", component: AdminApartmentEditComponent },
      { path: "master-utilities", component: AdminUtilitiesComponent},
      
    ]
  },

  {
    path: "", // from root
    component: BaseLayoutComponent,
    children: [
      { path: "", component: HomepageComponent},
      { path: "login", component: LoginComponent },
      { path: "register", component: RegisterComponent },
      { path: "config-building", component: ConfigBuildingComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
