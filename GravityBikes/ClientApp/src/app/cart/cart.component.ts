import { Component, OnInit } from '@angular/core';
import { ShoppingCartService } from '../_services/shopping-cart.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {
  items;
  tickets;

  constructor(private cartService: ShoppingCartService) { }

  finalPrice: number;
  ngOnInit() {
    this.items = this.cartService.getItems();
    this.tickets = this.cartService.getTickets();
  }

  totalPrice() {
    let total = 0;
    for (const data of this.tickets) {
      total += data.ticketPrice * data.ticketsNumber;
    }
    for (const data of this.items) {
      total += data.price;
    }
    return (total);
  }
}
