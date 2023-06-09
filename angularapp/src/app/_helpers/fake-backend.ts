//import { Injectable } from '@angular/core';
//import { HttpRequest, HttpResponse, HttpHandler, HttpEvent, HttpInterceptor, HTTP_INTERCEPTORS } from '@angular/common/http';
//import { Observable, of, throwError } from 'rxjs';
//import { delay, mergeMap, materialize, dematerialize } from 'rxjs/operators';

//import { User, Role } from '../_models';

//@Injectable()
//export class FakeBackendInterceptor implements HttpInterceptor {
//  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
//    const users: User[] = [
//      { id: 1, username: 'admin', password: 'admin', firstName: 'Admin', lastName: 'User', role: Role.Admin },
//      { id: 2, username: 'user', password: 'user', firstName: 'Normal', lastName: 'User', role: Role.User }
//    ];

//    const authHeader = request.headers.get('Authorization');
//    const isLoggedIn = authHeader && authHeader.startsWith('Bearer fake-jwt-token');
//    const roleString = isLoggedIn && authHeader.split('.')[1];
//    const role = roleString ? Role[roleString] : null;

//    // wrap in delayed observable to simulate server api call
//    console.log("Got HTTP Request");
//    return of(null).pipe(mergeMap(() => {


//      // authenticate - public
//      if (request.url.endsWith('/users/authenticate') && request.method === 'POST') {
//        console.log(request.body);
//        const user = users.find(x => x.username === request.body.username && x.password === request.body.password);
//        if (!user) return error('Username or password is incorrect');
//        return ok({
//          id: user.id,
//          username: user.username,
//          firstName: user.firstName,
//          lastName: user.lastName,
//          role: user.role,
//          token: `fake-jwt-token.${user.role}`
//        });
//      }

//      if (request.url.endsWith('/users/register') && request.method === 'POST') {
//        // const user = users.find(x => x.username === request.body.username && x.password === request.body.password);
//        // if (!user) return error('Username or password is incorrect');

//        return ok({
//          id: 1,
//          username: 'abc',
//          firstName: 'abc',
//          lastName: 'abc',
//          role: 'user',
//          token: `fake-jwt-token.${'user'}`
//        });
//      }



//      // pass through any requests not handled above
//      return next.handle(request);
//    }))
//      // call materialize and dematerialize to ensure delay even if an error is thrown (https://github.com/Reactive-Extensions/RxJS/issues/648)
//      .pipe(materialize())
//      .pipe(delay(500))
//      .pipe(dematerialize());

//    // private helper functions

//    function ok(body) {
//      return of(new HttpResponse({ status: 200, body: body }));
//    }

//    function unauthorised() {
//      return throwError({ status: 401, error: { message: 'Unauthorised' } });
//    }

//    function error(message) {
//      return throwError({ status: 400, error: { message } });
//    }
//  }
//}

//export let fakeBackendProvider = {
//  // use fake backend in place of Http service for backend-less development
//  provide: HTTP_INTERCEPTORS,
//  useClass: FakeBackendInterceptor,
//  multi: true
//};
