import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule, FormBuilder } from '@angular/forms';

// Angular material imports
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatIconModule} from '@angular/material/icon';
import {MatListModule} from '@angular/material/list';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatButtonModule} from '@angular/material/button';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatCardModule} from '@angular/material/card';
import {MatInputModule} from '@angular/material/input';
import {MatTableModule} from '@angular/material/table';
import {MatStepperModule} from '@angular/material/stepper';
import {MatSlideToggleModule} from '@angular/material/slide-toggle';

// UI Components
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardLayoutComponent } from './layouts/dashboard-layout/dashboard-layout.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { AdminDashboardComponent } from './pages/admin/admin-dashboard/admin-dashboard.component';
import { LoginComponent } from './pages/auth/login/login.component';
import { BaseLayoutComponent } from './layouts/base-layout/base-layout.component';
import { RegisterComponent } from './pages/auth/register/register.component';
import { AdminApartmentsComponent } from './pages/admin/admin-apartments/admin-apartments.component';
import { AdminUtilitiesComponent } from './pages/admin/admin-utilities/admin-utilities.component';
import { ToolbarHeaderComponent } from './shared/toolbar-header/toolbar-header.component';
import { HttpClientModule } from '@angular/common/http';
import { InfoCardComponent } from './shared/info-card/info-card.component';
import { AdminApartmentDetailComponent } from './pages/admin/admin-apartment-detail/admin-apartment-detail.component';
import { AdminApartmentEditComponent } from './pages/admin/admin-apartment-edit/admin-apartment-edit.component';
import { ApartmentDetailCardComponent } from './shared/apartment-detail-card/apartment-detail-card.component';
import { ConfigBuildingComponent } from './pages/auth/config-building/config-building.component';
import { AdminMasterUtilityDetailComponent } from './pages/admin/admin-master-utility-detail/admin-master-utility-detail.component';
import { MasterUtilCardComponent } from './shared/master-util-card/master-util-card.component';

@NgModule({
  declarations: [
    AppComponent,
    DashboardLayoutComponent,
    NavbarComponent,
    AdminDashboardComponent,
    LoginComponent,
    BaseLayoutComponent,
    RegisterComponent,
    AdminApartmentsComponent,
    AdminUtilitiesComponent,
    ToolbarHeaderComponent,
    InfoCardComponent,
    AdminApartmentDetailComponent,
    AdminApartmentEditComponent,
    ApartmentDetailCardComponent,
    ConfigBuildingComponent,
    AdminMasterUtilityDetailComponent,
    MasterUtilCardComponent,

  ],
  imports: [
    ReactiveFormsModule,
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    MatToolbarModule,
    MatButtonModule,
    MatFormFieldModule,
    MatCardModule,
    MatInputModule,
    MatTableModule,
    MatStepperModule,
    MatSlideToggleModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
