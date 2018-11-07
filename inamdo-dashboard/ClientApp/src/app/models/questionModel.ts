export class questionModel {
  public surveyId: string;
  public questionId: string;
  public questionDesc: string;
  public questionType: string;
  public choices: string[];

  constructor(surveyId, questionId, questionDesc, questionType, choices) {
    this.surveyId = surveyId;
    this.questionId = questionId;
    this.questionDesc = questionDesc;
    this.questionType = questionType;
    this.choices = choices;
  }
}
