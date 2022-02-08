import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SolutionStageUpdateCardComponent } from './solution-stage-update-card.component';

describe('SolutionStageUpdateCardComponent', () => {
  let component: SolutionStageUpdateCardComponent;
  let fixture: ComponentFixture<SolutionStageUpdateCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SolutionStageUpdateCardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SolutionStageUpdateCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
