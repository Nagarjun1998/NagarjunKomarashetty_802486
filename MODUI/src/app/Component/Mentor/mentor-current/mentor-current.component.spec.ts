import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MentorCurrentComponent } from './mentor-current.component';

describe('MentorCurrentComponent', () => {
  let component: MentorCurrentComponent;
  let fixture: ComponentFixture<MentorCurrentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MentorCurrentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MentorCurrentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
