import { Component } from '@angular/core';
import { ParallaxScrollModule } from 'ng2-parallaxscroll';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  imports: [
    ParallaxScrollModule,
  ];
  title = 'Gravity Bikes';
}
