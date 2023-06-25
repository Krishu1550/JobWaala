import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HumanresourceDashboardComponent } from './humanresource-dashboard.component';

describe('HumanresourceDashboardComponent', () => {
  let component: HumanresourceDashboardComponent;
  let fixture: ComponentFixture<HumanresourceDashboardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HumanresourceDashboardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HumanresourceDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
