import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { Constants } from '../app/Constants';
import { NgxPaginationModule } from 'ngx-pagination';
//import { DataTablesModule } from 'angular-datatables';

// used to create fake backend
//import { fakeBackendProvider } from './_helpers';

import { AppComponent } from './app.component';
import { routing } from './app.routing';

import { JwtInterceptor, ErrorInterceptor } from './_helpers';
import { HomeComponent, LoginComponent, TopbarComponent, AccountComponent, CategorydetailComponent } from './components/index';
import { getBaseUrl } from '../main';
import { CategoryComponent } from './components/category/category.component';
@NgModule({
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgbModule,
    routing,
    NgxPaginationModule
  ],
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    TopbarComponent,
    AccountComponent,
    CategoryComponent,
    
    CategorydetailComponent,
  ],
  providers: [
    Constants,
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
    { provide: 'BASE_URL', useFactory: getBaseUrl }

    // provider used to create fake backend
   // fakeBackendProvider
  ],
  bootstrap: [AppComponent]
})

export class AppModule { }
