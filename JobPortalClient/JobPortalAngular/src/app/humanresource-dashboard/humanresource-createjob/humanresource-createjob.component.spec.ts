import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HumanresourceCreatejobComponent } from './humanresource-createjob.component';

describe('HumanresourceCreatejobComponent', () => {
  let component: HumanresourceCreatejobComponent;
  let fixture: ComponentFixture<HumanresourceCreatejobComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HumanresourceCreatejobComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HumanresourceCreatejobComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
