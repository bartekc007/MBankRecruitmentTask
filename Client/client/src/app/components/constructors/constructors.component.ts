import { Component, OnInit } from '@angular/core';
import { BaseCollection, Constructor } from 'src/app/entities/entities';
import { ConstructorService } from 'src/app/services/constructor.service';
import { BaseListComponent } from '../base-list/base-list.component';

@Component({
  selector: 'app-constructors',
  templateUrl: './constructors.component.html',
  styleUrls: ['./constructors.component.css']
})
export class ConstructorsComponent extends BaseListComponent<Constructor>{
  
  constructor(collection: BaseCollection<Constructor>,serviceProvider: ConstructorService) {
    super(collection,serviceProvider);
    this.collection = {} as BaseCollection<Constructor>;
  }

}
