import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TicketBuyComponent } from './ticket-buy.component';

describe('TicketBuyComponent', () => {
  let component: TicketBuyComponent;
  let fixture: ComponentFixture<TicketBuyComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TicketBuyComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TicketBuyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
