import { Component, OnInit, Input } from '@angular/core';
import { AuthenticationService } from '../../../app/_services';
import { User } from '../../../app/_models/index';
import { Router } from '@angular/router';

@Component({
  selector: 'app-topbar',
  templateUrl: './topbar.component.html',
  styleUrls: ['./topbar.component.css']
})
export class TopbarComponent implements OnInit {

  currentUser: User|undefined;
  isNavbarCollapsed:boolean= true;
  constructor(private router: Router, private authenticationService: AuthenticationService) {
    this.authenticationService.currentUser.subscribe(x => this.currentUser = x);
  }
  loggedIn: boolean = false;
  ngOnInit() {
    // this.loginService.loginStatusObs$.subscribe(
    //   status => {
    //     this.loggedIn = status;
    //     console.log("Subscribe::"+status);
    // });
  }

  logout() {
    this.authenticationService.logout();
    this.router.navigate(['/books']);
  }
  showLoginModal() {
  }
}
