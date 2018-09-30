import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { MarsRoverComponent } from './mars-rover/mars-rover.component';

@NgModule({
  declarations: [
    AppComponent,
    MarsRoverComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
