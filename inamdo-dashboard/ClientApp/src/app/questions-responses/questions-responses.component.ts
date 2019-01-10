import { Component, OnInit } from '@angular/core';
//import { QuestionModel } from '../models/questionModel';
import { QuestionResponseService } from '../services/question-response.service';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-questions-responses',
  templateUrl: './questions-responses.component.html',
  styleUrls: ['./questions-responses.component.css'],
  providers: [QuestionResponseService, UserService]
})
export class QuestionsResponsesComponent {

  public users;
  public questions;
  constructor(private userService: UserService, private questionsService: QuestionResponseService) { }

  ngOnInit() {
    this.getUsers();
  }

  getUsers(): void {
    this.userService.getUsers(1).subscribe(
      data => { this.users = data },
      err => console.error(err),
      () => console.log('done loading users')
    );
  }

  getQuestions(): void {
    this.questionsService.getQuestions(1).subscribe(
      data => { this.questions = data },
      err => console.error(err),
      () => console.log('done loading questions')
    );
  }

  //rowData = this.questions;

  private gridApi;
  private gridColumnApi;
  public userDetails;
    
  columnDefs = [
    { headerName: 'Survey ID', field: 'surveyId', checkboxSelection: true },
    { headerName: 'User', field: 'userName' },
    { headerName: 'Phone', field: 'userPhone' },
    { headerName: 'Email', field: 'userEmail' }
  ];

  detailCellRendererParams = {
    detailGridOptions: {
      columnDefs:
        [{ headerName: 'Question', field: 'questionDesc' },
        { headerName: 'Question Type', field: 'questionType' },
        { headerName: 'Response', field: 'choice' }
        ],
      onFirstDataRendered(params) {
        params.api.sizeColumnsToFit();
      }
    },
    getDetailRowData: function (params) {
      params.successCallback(params.data.callRecords);
    }
  };

  getUserDetails(): void {
    this.userService.getUserDetails(1).subscribe(
      data => { this.userDetails = data; });
  }

  onGridReady(params) {
    this.gridApi = params.api;
    this.gridColumnApi = params.columnApi;

    this.getUserDetails();
    
    setTimeout(function () {
      var rowCount = 0;
      params.api.forEachNode(function (node) {
        node.setExpanded(rowCount++ === 1);
      });
    }, 500);
  }


}
