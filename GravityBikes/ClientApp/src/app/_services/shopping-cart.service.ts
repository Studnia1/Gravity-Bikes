import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ShoppingCartService {

  items = [];
  tickets = [];

  addToCart(product) {
    this.items.push(product);
  }

  getItems() {
    return this.items;
  }

  ticketsToCart(product) {
    this.tickets.push(product);
  }

  getTickets() {
    return this.tickets;
  }

  clearCart() {
    this.items = [];
    this.tickets = [];
    return this.items;
  }
  constructor() { }
}
