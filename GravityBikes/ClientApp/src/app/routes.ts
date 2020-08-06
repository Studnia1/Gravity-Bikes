import {Routes} from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ParkMapComponent } from './park-map/park-map.component';
import { RegisterComponent } from './register/register.component';
import { BikeChooseComponent } from './bikes/bike-choose/bike-choose.component';
import { CartComponent } from './cart/cart.component';
import { TicketsComponent } from './tickets/tickets.component';

export const appRoutes: Routes = [
    {path: 'home', component: HomeComponent},
    {path: 'register', component: RegisterComponent},
    {path: 'park_map', component: ParkMapComponent},
    {path: 'bike_choose', component: BikeChooseComponent},
    {path: 'tickets', component: TicketsComponent},
    {path: 'cart', component: CartComponent},
    {path: '**', redirectTo: 'home', pathMatch: 'full'},

];
