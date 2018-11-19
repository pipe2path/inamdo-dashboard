export class userModel {
  public surveyId: string;
  public userName: string;
  public userPhone: string;
  public userEmail: string;
  public optIn: string;

  constructor(surveyId, userName, entityName, userPhone, userEmail, optIn) {
    this.surveyId = surveyId;
    this.userName = userName;
    this.userPhone = userPhone;
    this.userEmail = userEmail;
    this.optIn = optIn;
  }
}
