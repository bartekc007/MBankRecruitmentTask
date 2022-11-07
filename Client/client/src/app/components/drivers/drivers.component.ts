import { Component, OnInit } from '@angular/core';
import { BaseCollection, Driver } from 'src/app/entities/entities';
import { DriverService } from 'src/app/services/driver.service';
import { BaseListComponent } from '../base-list/base-list.component';

@Component({
  selector: 'app-drivers',
  templateUrl: './drivers.component.html',
  styleUrls: ['./drivers.component.css']
})
export class DriversComponent extends BaseListComponent<Driver>{
  
  constructor(collection: BaseCollection<Driver>,serviceProvider: DriverService) {
    super(collection,serviceProvider);
    this.collection = {} as BaseCollection<Driver>;
  }

}
