import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HumanresourceApplicantlistComponent } from './humanresource-applicantlist.component';

describe('HumanresourceApplicantlistComponent', () => {
  let component: HumanresourceApplicantlistComponent;
  let fixture: ComponentFixture<HumanresourceApplicantlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HumanresourceApplicantlistComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HumanresourceApplicantlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
