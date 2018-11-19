import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams, HttpResponse, HttpErrorResponse } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { userModel } from '../models/userModel';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable()
export class UserService {

  constructor(private http: HttpClient) { }

  getUserServiceUrl = environment.apiUrl + "/users/";

  getUsers(entityId: number) {
    var fullUrl = this.getUserServiceUrl;
    var users = this.http.get(fullUrl);
    return users;
  }

}
