import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HumanresourceProfileComponent } from './humanresource-profile.component';

describe('HumanresourceProfileComponent', () => {
  let component: HumanresourceProfileComponent;
  let fixture: ComponentFixture<HumanresourceProfileComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HumanresourceProfileComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HumanresourceProfileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
