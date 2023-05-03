import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Constants } from '../Constants';
import { User, category } from '../_models';

@Injectable({ providedIn: 'root' })
export class UserService {
  constructor(private http: HttpClient, private baseUrl: Constants) { }

  getAll() {
    return this.http.get<User[]>(`/users`);
  }

  getById(id: number) {
    return this.http.get<User>(`/users/${id}`);
  }
  getAllCategories(page:number) {
    return this.http.get<category[]>(this.baseUrl.API_ENDPOINT +`api/category/Search?pageindex=${page}&pagesize=2`);
  }

  AddCategory(data:any) {
    return this.http.post<category[]>(this.baseUrl.API_ENDPOINT + `api/category/index`, data);
  }

  getCategory(id: number) {
    return this.http.get<category>(this.baseUrl.API_ENDPOINT + `api/category/get/${id}`);
  }
}
