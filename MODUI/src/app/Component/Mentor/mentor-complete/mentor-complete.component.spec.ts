import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MentorCompleteComponent } from './mentor-complete.component';

describe('MentorCompleteComponent', () => {
  let component: MentorCompleteComponent;
  let fixture: ComponentFixture<MentorCompleteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MentorCompleteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MentorCompleteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
