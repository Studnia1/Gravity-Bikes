import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BikeChooseComponent } from './bike-choose.component';

describe('BikeChooseComponent', () => {
  let component: BikeChooseComponent;
  let fixture: ComponentFixture<BikeChooseComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BikeChooseComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BikeChooseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
