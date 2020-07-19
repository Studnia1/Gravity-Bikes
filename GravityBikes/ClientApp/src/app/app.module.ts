import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ParallaxScrollModule } from 'ng2-parallaxscroll';
import {MatToolbarModule} from '@angular/material/toolbar';
import {NgbPaginationModule, NgbAlertModule, NgbDatepickerModule} from '@ng-bootstrap/ng-bootstrap';

import { AppComponent } from './app.component';
import {MaterialModule} from './material/material.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './user/login/login.component';
import { NavbarComponent } from './navbar/navbar.component';
import { DialogComponent, DialogShowComponent } from './dialog/dialog.component';
import { AuthService } from './_services/auth.service';
import { RegisterComponent } from './register/register.component';
import { HomeComponent } from './home/home.component';
import { ErrorInterceptorProvider } from './_services/error.interceptor';
import { ParkMapComponent } from './park-map/park-map.component';
import { BikeChooseComponent } from './bikes/bike-choose/bike-choose.component';
import { TicketBuyComponent } from './ticket-buy/ticket-buy.component';
import { appRoutes } from './routes';
import { BikeCardComponent, DialogCalendarComponent } from './bikes/bike-card/bike-card.component';
import { BikeService } from './_services/bike.service';
import { ShoppingCartService } from './_services/shopping-cart.service';
import { CartComponent } from './cart/cart.component';
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    NavbarComponent,
    DialogComponent,
    DialogShowComponent,
    RegisterComponent,
    HomeComponent,
    ParkMapComponent,
    BikeChooseComponent,
    TicketBuyComponent,
    BikeCardComponent,
    DialogCalendarComponent,
    CartComponent

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ParallaxScrollModule,
    RouterModule.forRoot([
    ]),
    BrowserAnimationsModule,
    MaterialModule,
    MatToolbarModule,
    RouterModule.forRoot(appRoutes),
    NgbPaginationModule,
    NgbAlertModule,
    NgbDatepickerModule

  ],
  entryComponents: [DialogComponent, DialogShowComponent, DialogCalendarComponent],
  providers: [
    AuthService,
    ErrorInterceptorProvider,
    BikeService,
    ShoppingCartService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
