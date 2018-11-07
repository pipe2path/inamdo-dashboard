"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var questionModel = /** @class */ (function () {
    function questionModel(surveyId, questionId, questionDesc, questionType, choices) {
        this.surveyId = surveyId;
        this.questionId = questionId;
        this.questionDesc = questionDesc;
        this.questionType = questionType;
        this.choices = choices;
    }
    return questionModel;
}());
exports.questionModel = questionModel;
//# sourceMappingURL=questionModel.js.map