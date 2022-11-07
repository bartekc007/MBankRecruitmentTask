import { Component, OnInit } from '@angular/core';
import { Observable, tap } from 'rxjs';
import { BaseCollection, Circuit, EntityBase } from 'src/app/entities/entities';
import { CircuitService } from 'src/app/services/circuit.service';
import { BaseListComponent } from '../base-list/base-list.component';

@Component({
  selector: 'app-circuits',
  templateUrl: './circuits.component.html',
  styleUrls: ['./circuits.component.css']
})
export class CircuitsComponent  extends BaseListComponent<Circuit>{
  
  constructor(collection: BaseCollection<Circuit>,serviceProvider: CircuitService) {
    super(collection,serviceProvider);
    this.collection = {} as BaseCollection<Circuit>;
  }

}

