import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ParallaxScrollModule } from 'ng2-parallaxscroll';
import {MatToolbarModule} from '@angular/material/toolbar';

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
import { BikeChooseComponent } from './bike-choose/bike-choose.component';
import { TicketBuyComponent } from './ticket-buy/ticket-buy.component';
import { appRoutes } from './routes';

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
    TicketBuyComponent

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
    RouterModule.forRoot(appRoutes)

  ],
  entryComponents: [DialogComponent, DialogShowComponent],
  providers: [
    AuthService,
    ErrorInterceptorProvider
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
