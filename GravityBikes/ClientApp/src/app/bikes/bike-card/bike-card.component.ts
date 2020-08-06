import { Component, OnInit, Input, Output } from '@angular/core';
import { Bike, BikeTypes } from 'src/app/_models/Bike';
import {MatDialog, MAT_DIALOG_DATA} from '@angular/material/dialog';
import {NgbDate, NgbCalendar, NgbDatepickerConfig} from '@ng-bootstrap/ng-bootstrap';
import { BikeDates } from 'src/app/_models/BikeDates';
import { BikeService } from 'src/app/_services/bike.service';
import { ShoppingCartService } from 'src/app/_services/shopping-cart.service';
import { EventEmitter } from '@angular/core';


@Component({
  selector: 'app-bike-card',
  templateUrl: './bike-card.component.html',
  styleUrls: ['./bike-card.component.css']
})
export class BikeCardComponent implements OnInit {
  @Input() bike: Bike;
  bikeDates: BikeDates[];
  size: any;
  BikeTypes = BikeTypes;
  model: any = {};
  modelToCart: any = {};
  constructor(public dialog: MatDialog, public bikeService: BikeService, private cartService: ShoppingCartService) { }

  ngOnInit() {
  }
  addToCart(product) {
    this.cartService.addToCart(this.modelToCart);
    window.alert('Your product has been added to the cart');
  }
  test() {
    this.bikeService.getDates(this.model).subscribe((bikeDates: BikeDates[]) => {
      this.bikeDates = bikeDates;
    });
  }
  loadDates() {
    this.model.size = this.size;
    this.model.model = this.bike.bikeModel;
  }
   doSomething(date: any) {
    this.modelToCart.bikeModel = this.bike.bikeModel;
    this.modelToCart.size = this.size;
    this.modelToCart.date = date;
    this.modelToCart.price = this.bike.bikePrice;
    console.log(this.modelToCart);
}
}

@Component({
  selector: 'app-dialog-calendar-component',
  templateUrl: 'dialog-calendar-component.html',
  styles: [`
    .custom-day {
      text-align: center;
      padding: 0.185rem 0.25rem;
      display: inline-block;
      height: 2rem;
      width: 2rem;
    }
    .custom-day.focused {
      background-color: #e6e6e6;
    }
    .custom-day.range, .custom-day:hover {
      background-color: rgb(2, 117, 216);
      color: white;
    }
    .custom-day.faded {
      background-color: rgba(2, 117, 216, 0.5);
    }
    .markDisabled {
      color: yellow;
      font-size: 50px;
    }
  `],
  providers: [NgbDatepickerConfig]
})
export class DialogCalendarComponent {
  @Output() DatePicked: EventEmitter<any> = new EventEmitter<any>();
  @Input() bikeDate: BikeDates[];
  markDisabled;
  dejta: Date[] = [];
  today: number = Date.now();
  fromDate: NgbDate;
  toDate: NgbDate | null = null;
  myFilter = (d: Date): boolean => {
    return this.dejta.findIndex(testDate => d.toDateString() === testDate.toDateString()) < 0;
  }
  constructor(calendar: NgbCalendar) {
    this.fromDate = calendar.getToday();
    this.toDate = calendar.getNext(calendar.getToday(), 'd', 10);
  }

  public pickDate(date: any): void {
    this.DatePicked.emit(date);
}

  loaddates() {
    for (let i = 0; i < this.bikeDate.length; i++) {
      this.dejta[i] = new Date(this.bikeDate[i].bikeDate);
      console.log(this.dejta[i]);
  }
  }
}
