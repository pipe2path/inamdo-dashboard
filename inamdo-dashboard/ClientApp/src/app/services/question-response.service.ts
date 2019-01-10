import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams, HttpResponse, HttpErrorResponse } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { questionModel } from '../models/questionModel';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable()
export class QuestionResponseService {

  constructor(private http: HttpClient) { }

  getQuestionsServiceUrl = environment.apiUrl + "/questions/";

  getQuestions(entityId: number) {
    var fullUrl = this.getQuestionsServiceUrl ;
    var questions = this.http.get(fullUrl);
    return questions;
  }
}
