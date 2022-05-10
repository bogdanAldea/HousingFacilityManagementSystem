import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

// Angular material imports
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatIconModule} from '@angular/material/icon';
import {MatListModule} from '@angular/material/list';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatButtonModule} from '@angular/material/button';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatCardModule} from '@angular/material/card';
import {MatInputModule} from '@angular/material/input';

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

  ],
  imports: [
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
    MatInputModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
