import { Component, OnInit } from '@angular/core';
//import { QuestionModel } from '../models/questionModel';
import { QuestionResponseService } from '../services/question-response.service';

@Component({
  selector: 'app-questions-responses',
  templateUrl: './questions-responses.component.html',
  styleUrls: ['./questions-responses.component.css'],
  providers: [QuestionResponseService]
})
export class QuestionsResponsesComponent {

  public questions;
  constructor(private questionsService: QuestionResponseService) { }

  ngOnInit() {
    this.getQuestions();
  }

  getQuestions(): void {
    this.questionsService.getQuestions(1).subscribe(
      data => { this.questions = data },
      err => console.error(err),
      () => console.log('done loading questions')
    );
  }

}
