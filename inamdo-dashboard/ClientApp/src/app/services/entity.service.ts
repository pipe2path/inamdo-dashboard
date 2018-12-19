import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams, HttpResponse, HttpErrorResponse } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs/Observable';
import { catchError } from 'rxjs/operators';
import { entityModel } from '../models/entityModel';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable()
export class EntityService {

  constructor(private http: HttpClient) { }

  getEntityServiceUrl = environment.apiUrl + "/entities/";
  
  getEntity(entityId: string) {
    var fullUrl = this.getEntityServiceUrl + entityId;
    var entity = this.http.get<entityModel>(fullUrl);
    return entity;
  }
}

