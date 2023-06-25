import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApplicantJobstatusComponent } from './applicant-jobstatus.component';

describe('ApplicantJobstatusComponent', () => {
  let component: ApplicantJobstatusComponent;
  let fixture: ComponentFixture<ApplicantJobstatusComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ApplicantJobstatusComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ApplicantJobstatusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
