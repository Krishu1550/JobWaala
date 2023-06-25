import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApplicantNewjobslistComponent } from './applicant-newjobslist.component';

describe('ApplicantNewjobslistComponent', () => {
  let component: ApplicantNewjobslistComponent;
  let fixture: ComponentFixture<ApplicantNewjobslistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ApplicantNewjobslistComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ApplicantNewjobslistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
