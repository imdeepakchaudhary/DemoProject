import { Routes, RouterModule } from '@angular/router';

import { HomeComponent, AccountComponent, LoginComponent, CategoryComponent } from './components/index';
import { AuthGuard } from './_guards';
import { Role } from './_models';

const appRoutes: Routes = [
  {
    path: '',
    component: HomeComponent,
  },
  {
    path: 'home',
    component: HomeComponent,
  },
  {
    path: 'account',
    component: AccountComponent,
    canActivate: [AuthGuard]
    , data: {
      role: 'USER'
    }
  },
  {
    path: 'category',
    component: CategoryComponent,
    canActivate: [AuthGuard]
    , data: {
      role: 'admin'
    }
  },
  {
    path: 'login',
    component: LoginComponent
  },

  // otherwise redirect to home
  //{ path: '**', component: NotFoundComponent }
];

export const routing = RouterModule.forRoot(appRoutes);
