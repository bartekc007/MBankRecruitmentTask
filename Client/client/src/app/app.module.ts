import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CircuitsComponent } from './components/circuits/circuits.component';
import { ConstructorsComponent } from './components/constructors/constructors.component';
import { DriversComponent } from './components/drivers/drivers.component';
import { RacesComponent } from './components/races/races.component';
import { NavComponent } from './nav/nav.component';
import { BaseCollection } from './entities/entities';

@NgModule({
  declarations: [
    AppComponent,
    CircuitsComponent,
    ConstructorsComponent,
    DriversComponent,
    RacesComponent,
    NavComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [{provide: BaseCollection, useClass: BaseCollection}],
  bootstrap: [AppComponent]
})
export class AppModule { }
