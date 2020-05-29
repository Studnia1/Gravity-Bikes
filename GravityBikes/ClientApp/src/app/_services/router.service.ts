import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class RouterService {
  registerMode = false;
  constructor() { }
  registerToggle() {
    this.registerMode = !this.registerMode;
  }
}
