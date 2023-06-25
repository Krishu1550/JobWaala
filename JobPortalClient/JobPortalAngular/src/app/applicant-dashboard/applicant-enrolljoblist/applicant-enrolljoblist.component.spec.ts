import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApplicantEnrolljoblistComponent } from './applicant-enrolljoblist.component';

describe('ApplicantEnrolljoblistComponent', () => {
  let component: ApplicantEnrolljoblistComponent;
  let fixture: ComponentFixture<ApplicantEnrolljoblistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ApplicantEnrolljoblistComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ApplicantEnrolljoblistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
