import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SolutionViewComponent } from './solution-view.component';

describe('SolutionViewComponent', () => {
  let component: SolutionViewComponent;
  let fixture: ComponentFixture<SolutionViewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SolutionViewComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SolutionViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
