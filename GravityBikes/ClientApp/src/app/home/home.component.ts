import { Component, OnInit } from '@angular/core';
import { RouterService } from '../_services/router.service';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  constructor(public routerService: RouterService) { }

  registerToogle() {
    this.routerService.registerToggle();
  }
  ngOnInit() {
  }
}
