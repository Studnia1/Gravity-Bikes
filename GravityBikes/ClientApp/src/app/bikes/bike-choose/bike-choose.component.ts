import { Component, OnInit } from '@angular/core';
import { Bike } from '../../_models/Bike';
import { BikeService } from '../../_services/bike.service';
import { AlertifyService } from '../../_services/alertify.service';

@Component({
  selector: 'app-bike-choose',
  templateUrl: './bike-choose.component.html',
  styleUrls: ['./bike-choose.component.css']
})
export class BikeChooseComponent implements OnInit {
  bikes: Bike[];
  constructor(private bikeService: BikeService, private alertify: AlertifyService) { }

  ngOnInit() {
    this.loadBikes();
  }
  loadBikes() {
    this.bikeService.getBikes().subscribe((bikes: Bike[]) => {
      this.bikes = bikes;
    }, error => {
      this.alertify.error(error);
    });
  }
}
