import { Injectable } from '@angular/core';
import jwt_decode from "jwt-decode";

@Injectable({
  providedIn: 'root'
})
export class JwtTokenService {

  jwtToken: string;
  tokenPayload: { [key: string] : string };

  constructor() { }

  public setToken(token: string): void 
  {
    if (token) { this.jwtToken = token }
  }

  public decodeToken() : void
  {
    if (this.jwtToken) { this.tokenPayload = jwt_decode(this.jwtToken) }
  }

  public getUserProfileId() : number
  {
    this.decodeToken();
    var userProfileId: number = parseInt(this.tokenPayload["UserProfileId"]);
    return userProfileId;
  }
}