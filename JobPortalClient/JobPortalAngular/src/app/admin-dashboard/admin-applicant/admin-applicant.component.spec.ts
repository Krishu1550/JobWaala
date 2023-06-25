import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminApplicantComponent } from './admin-applicant.component';

describe('AdminApplicantComponent', () => {
  let component: AdminApplicantComponent;
  let fixture: ComponentFixture<AdminApplicantComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminApplicantComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdminApplicantComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
