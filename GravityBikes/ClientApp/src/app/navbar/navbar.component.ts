import { Component, OnInit } from '@angular/core';
import { RouterService } from '../_services/router.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  constructor(public routerService: RouterService) { }

  registerToogle() {
    this.routerService.registerToggle();
  }

  ngOnInit() {
  }

}
