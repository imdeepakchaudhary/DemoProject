import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

import { AuthenticationService } from '../../../app/_services';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({ templateUrl: 'login.component.html' })
export class LoginComponent implements OnInit {
  name: string = '';
  pass: string="";
  returnUrl: string='';
  loginForm: FormGroup|any;
  loading = false;
  submitted = false;
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private authenticationService: AuthenticationService, private formBuilder: FormBuilder
  ) { }

  ngOnInit() {
    this.loginForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });

    this.authenticationService.logout();
    // get return url from route parameters or default to '/'
    this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';
  }
  get f() { return this.loginForm.controls; }

  onSubmit() {
    this.submitted = true;

    // stop here if form is invalid
    if (this.loginForm.invalid) {
      return;
    }

    this.loading = true;
    this.authenticationService.login(this.f.username.value, this.f.password.value)
      //.pipe(first())
      .subscribe({
        next: (data: any) => {
          this.router.navigate([this.returnUrl]);
        },
        error: (err: any) => {
          console.log(err.error);
          // this.alertService.error(error);
          this.loading = false;
        }
      });
  }

  check() {
    this.authenticationService.login(this.name, this.pass)
      .subscribe({
        next:(data:any) => {
          console.log("Going to " + this.returnUrl);
          this.router.navigate([this.returnUrl]);
        },
        error: (err: any) => {
          console.log("Error " + this.returnUrl);
        }
        });
  }
}
