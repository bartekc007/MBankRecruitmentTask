import { Component, OnInit } from '@angular/core';
import { BaseCollection, Race } from 'src/app/entities/entities';
import { RaceService } from 'src/app/services/race.service';
import { BaseListComponent } from '../base-list/base-list.component';

@Component({
  selector: 'app-races',
  templateUrl: './races.component.html',
  styleUrls: ['./races.component.css']
})
export class RacesComponent extends BaseListComponent<Race>{
  
  constructor(collection: BaseCollection<Race>,serviceProvider: RaceService) {
    super(collection,serviceProvider);
    this.collection = {} as BaseCollection<Race>;
    this.collection.pageNumber = 0;
  }

}
