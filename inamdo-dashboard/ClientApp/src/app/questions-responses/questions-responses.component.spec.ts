import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { QuestionsResponsesComponent } from './questions-responses.component';

describe('QuestionsResponsesComponent', () => {
  let component: QuestionsResponsesComponent;
  let fixture: ComponentFixture<QuestionsResponsesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ QuestionsResponsesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(QuestionsResponsesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
