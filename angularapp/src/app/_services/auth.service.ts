import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';
import { Constants } from '../Constants';
import { AuthenticationService } from '../_services';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  isLogin = false;

  roleAs: string;

  constructor(private authenticationService: AuthenticationService) { }

  isLoggedIn() {
    const currentUser = this.authenticationService.currentUserValue;
    if (currentUser)
      this.isLogin = true;
    else
      this.isLogin = false;
    return this.isLogin;
  }

  getRole() {
    const currentUser = this.authenticationService.currentUserValue;
    this.roleAs = currentUser.role;
    return this.roleAs;
  }

}
