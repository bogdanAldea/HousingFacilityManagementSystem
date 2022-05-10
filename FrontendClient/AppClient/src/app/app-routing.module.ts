import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BaseLayoutComponent } from './layouts/base-layout/base-layout.component';
import { DashboardLayoutComponent } from './layouts/dashboard-layout/dashboard-layout.component';
import { AdminDashboardComponent } from './pages/admin/admin-dashboard/admin-dashboard.component';
import { AdminApartmentsComponent } from './pages/admin/admin-apartments/admin-apartments.component';
import { LoginComponent } from './pages/auth/login/login.component';
import { RegisterComponent } from './pages/auth/register/register.component';
import { HomepageComponent } from './pages/home/homepage/homepage.component';
import { AdminUtilitiesComponent } from './pages/admin/admin-utilities/admin-utilities.component';

const routes: Routes = [
  { 
    path: "dashboard",
    component: DashboardLayoutComponent,
    children: [
      { path: "", component: AdminDashboardComponent },
      { path: "apartments", component: AdminApartmentsComponent },
      { path: "master-utilities", component: AdminUtilitiesComponent}
    ] 
  },

  {
    path: "", // from root
    component: BaseLayoutComponent,
    children: [
      { path: "", component: HomepageComponent},
      { path: "login", component: LoginComponent },
      { path: "register", component: RegisterComponent },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
