import {Routes} from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ParkMapComponent } from './park-map/park-map.component';
import { TicketBuyComponent } from './ticket-buy/ticket-buy.component';
import { RegisterComponent } from './register/register.component';
import { BikeChooseComponent } from './bikes/bike-choose/bike-choose.component';

export const appRoutes: Routes = [
    {path: 'home', component: HomeComponent},
    {path: 'register', component: RegisterComponent},
    {path: 'park_map', component: ParkMapComponent},
    {path: 'bike_choose', component: BikeChooseComponent},
    {path: 'ticket_buy', component: TicketBuyComponent},
    {path: '**', redirectTo: 'home', pathMatch: 'full'},

];
