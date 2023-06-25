import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HumanresourceJoblistComponent } from './humanresource-joblist.component';

describe('HumanresourceJoblistComponent', () => {
  let component: HumanresourceJoblistComponent;
  let fixture: ComponentFixture<HumanresourceJoblistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HumanresourceJoblistComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HumanresourceJoblistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
