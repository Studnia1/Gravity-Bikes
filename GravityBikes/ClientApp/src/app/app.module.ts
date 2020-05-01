import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ParallaxScrollModule } from 'ng2-parallaxscroll';

import { AppComponent } from './app.component';
@NgModule({
  declarations: [
    AppComponent,

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ParallaxScrollModule,
    RouterModule.forRoot([
    ]),

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
