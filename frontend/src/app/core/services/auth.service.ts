import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, firstValueFrom, mapTo, Observable, of, tap } from 'rxjs';
import { Tokens } from '../models/tokens';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  
  readonly baseUrl = 'http://localhost:5000/api/Auth';

  private readonly JWT_TOKEN = 'JWT_TOKEN';
  private readonly REFRESH_TOKEN = 'REFRESH_TOKEN';
  private readonly USER_INFO = 'USER_INFO';
  private readonly USER_PROFILE = 'USER_PROFILE';
  private loggedUser: string | undefined | null;

  constructor(private http: HttpClient) {}

  async login(user: { email: string, password: string }) {
    const tokens = await firstValueFrom(this.http.post<any>(`${this.baseUrl}/Auth`, user));

    await this.doLoginUser(user.email, tokens);

    return;
  }

  logout() {
    this.doLogoutUser();
  }

  isLoggedIn() {
    return !!this.getJwtToken();
  }

  getJwtToken() {
    return localStorage.getItem(this.JWT_TOKEN);
  }

  private async doLoginUser(email: string, tokens: Tokens) {
    const profileType = await this.doUserProfile(email);
    
    this.loggedUser = email;
    this.storeTokens(tokens);
    this.storeUserInfo(email, profileType);
  }

  private doLogoutUser() {
    this.loggedUser = null;
    this.removeTokens();
    this.removeUserInfo();
  }

  private getRefreshToken() {
    return localStorage.getItem(this.REFRESH_TOKEN);
  }

  private storeJwtToken(jwt: string) {
    localStorage.setItem(this.JWT_TOKEN, jwt);
  }

  private storeTokens(tokens: Tokens) {
    localStorage.setItem(this.JWT_TOKEN, tokens.jwt);
    // localStorage.setItem(this.REFRESH_TOKEN, tokens.refreshToken);
  }

  private removeTokens() {
    localStorage.removeItem(this.JWT_TOKEN);
    // localStorage.removeItem(this.REFRESH_TOKEN);
  }

  private storeUserInfo(email: string, profileType: number) {
    localStorage.setItem(this.USER_INFO, JSON.stringify({ email, type: profileType }));
  }

  getUserInfo() {
    return JSON.parse(localStorage.getItem(this.USER_INFO)!);
  }

  private removeUserInfo() {
    localStorage.removeItem(this.USER_INFO);
  }

  private async doUserProfile(email: string) {
    const { type } = await firstValueFrom(this.http.post<any>(`http://localhost:5000/User/GetbyEmail`, { email }));
    return type;
  }

}
