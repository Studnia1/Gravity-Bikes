import { Component, OnInit, Input } from '@angular/core';
import { Bike, BikeTypes } from 'src/app/_models/Bike';
import {MatDatepickerModule} from '@angular/material/datepicker';

@Component({
  selector: 'app-bike-card',
  templateUrl: './bike-card.component.html',
  styleUrls: ['./bike-card.component.css']
})
export class BikeCardComponent implements OnInit {
  @Input() bike: Bike;
  BikeTypes = BikeTypes;
  constructor() { }

  ngOnInit() {
  }

}
