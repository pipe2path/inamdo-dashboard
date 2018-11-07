import { TestBed, inject } from '@angular/core/testing';

import { QuestionResponseService } from './question-response.service';

describe('QuestionResponseService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [QuestionResponseService]
    });
  });

  it('should be created', inject([QuestionResponseService], (service: QuestionResponseService) => {
    expect(service).toBeTruthy();
  }));
});
