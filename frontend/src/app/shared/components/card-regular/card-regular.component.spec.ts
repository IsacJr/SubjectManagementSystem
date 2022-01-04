import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CardRegularComponent } from './card-regular.component';

describe('CardRegularComponent', () => {
  let component: CardRegularComponent;
  let fixture: ComponentFixture<CardRegularComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CardRegularComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CardRegularComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
