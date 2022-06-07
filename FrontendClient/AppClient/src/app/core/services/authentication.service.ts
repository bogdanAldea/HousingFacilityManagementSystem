import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiRoutes } from '../api-routes/api-routes';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private httpClient: HttpClient) { }

  public login(credentials: any)
  {
    return this.httpClient.post(ApiRoutes.AdminIdentityRoutes.LOGIN, credentials, {responseType: "text"})
  }

  public register(credentials: any)
  {
    return this.httpClient.post(ApiRoutes.AdminIdentityRoutes.REGISTER, credentials, {responseType: "text"});
  }
}
