import { Component, OnInit, Input } from '@angular/core';
import { TicketsService } from '../_services/tickets.service';
import { AlertifyService } from '../_services/alertify.service';
import { Tickets } from '../_models/Ticket';
import {MatDialog, MatDialogRef} from '@angular/material/dialog';
import {NgbDate, NgbCalendar, NgbDatepickerConfig} from '@ng-bootstrap/ng-bootstrap';
import { ShoppingCartService } from '../_services/shopping-cart.service';
import {FormControl, Validators} from '@angular/forms';
import { formatDate } from '@angular/common';


@Component({
  selector: 'app-tickets',
  templateUrl: './tickets.component.html',
  styleUrls: ['./tickets.component.css']
})
export class TicketsComponent implements OnInit {
  tickets: Tickets[] = [];
  constructor(private ticketsService: TicketsService, private alertify: AlertifyService, public dialog: MatDialog) { }
  columns: number[] = [];
  isLoaded = false;
  newDateStart: Date;
  IsDayLimitedTicket = false;
  newDateStop: Date;
  ticketFormControl = new FormControl('', [
    Validators.required
  ]);
  newTicket: any = {};

ngOnInit() {
    this.loadTickets();

  }
  loadNewDateStart(event) {
    const format = 'yyyy/MM/dd';
    const locale = 'en-US';
    const formattedDate = formatDate(event, format, locale);
    this.newTicket.LimitStart = formattedDate;
  }
  loadNewDateStop(event) {
    const format = 'yyyy/MM/dd';
    const locale = 'en-US';
    const formattedDate = formatDate(event, format, locale);
    this.newTicket.LimitStop = formattedDate;
  }
  openDialog(id, reduced) {
    const dialogRef = this.dialog.open(TicketDialogComponent);
    const instance = dialogRef.componentInstance;
    instance.ticketId = this.tickets[id].liftTicketID;
    instance.ticketName = this.tickets[id].liftTicketType;
    instance.ticketPrice = this.tickets[id].liftTicketPrice;
    if (reduced) {
    instance.ticketPrice = this.tickets[id].liftTicketPriceReduced;
    }

  }
  postTicket() {
    this.ticketsService.postTicket(this.newTicket).subscribe(() => {
      this.alertify.success('registration successful');
    }, error => {
      this.alertify.error(error);
    });
    console.log(this.newTicket);
  }
loadTickets() {
  this.ticketsService.getTickets().subscribe((tickets: Tickets[]) => {
    this.tickets = tickets;
    for (let i = 0; i < this.tickets.length; i++) {
      this.columns.push( i );
    }
  }, error => {
    this.alertify.error(error);
  });
  }
}

@Component({
  selector: 'app-ticket-dialog-component',
  templateUrl: 'ticket-dialog.component.html',
  styles: [`
  .numinput {
    max-width: 100px;
  }
  `]
})
export class TicketDialogComponent {
  ticketId: number;
  ticketName: string;
  ticketsNumber: number;
  ticketPrice: number;
  picked: Date;
  ticketToCart: any = {};
  constructor(calendar: NgbCalendar, private cartService: ShoppingCartService) {}
    addToCart() {
      this.ticketToCart.ticketsNumber = this.ticketsNumber;
      this.cartService.ticketsToCart(this.ticketToCart);
      window.alert('Your product has been added to the cart');
    }
    setDate(event) {
      this.ticketToCart.date = event;
      this.ticketToCart.ticketId = this.ticketId;
      this.ticketToCart.ticketName = this.ticketName;
      this.ticketToCart.ticketPrice = this.ticketPrice;
      console.log(this.ticketToCart);
    }
}
