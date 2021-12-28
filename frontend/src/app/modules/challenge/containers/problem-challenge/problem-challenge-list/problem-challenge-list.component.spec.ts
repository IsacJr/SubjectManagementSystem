import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProblemChallengeListComponent } from './problem-challenge-list.component';

describe('ProblemChallengeListComponent', () => {
  let component: ProblemChallengeListComponent;
  let fixture: ComponentFixture<ProblemChallengeListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProblemChallengeListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProblemChallengeListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
