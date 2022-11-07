import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CircuitsComponent } from './components/circuits/circuits.component';
import { ConstructorsComponent } from './components/constructors/constructors.component';
import { DriversComponent } from './components/drivers/drivers.component';
import { RacesComponent } from './components/races/races.component';

const routes: Routes = [
  {path:'', component: CircuitsComponent},
  {
    path: '',
    children: [
    {
      path: 'circuits',
      component: CircuitsComponent
    },
    {
      path: 'constructors',
      component: ConstructorsComponent
    },
    {
      path: 'drivers',
      component: DriversComponent
    },
    {
      path: 'races',
      component: RacesComponent
    },
  ]
  }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
