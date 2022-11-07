import { Component, OnInit } from '@angular/core';
import { BaseCollection, Circuit, EntityBase, ServiceProvider } from 'src/app/entities/entities';
import { CircuitService } from 'src/app/services/circuit.service';

@Component({
  selector: 'app-base-list',
  templateUrl: './base-list.component.html',
  styleUrls: ['./base-list.component.css']
})

export class BaseListComponent <T extends EntityBase> implements OnInit {
  dissableLoadMoreButton: boolean = false;
  constructor(public collection: BaseCollection<T>, private serviceProvider: ServiceProvider<BaseCollection<T>>) {
    
  }

  ngOnInit(): void {
    this.Init();
    this.serviceProvider.getAll(this.collection.pageNumber).subscribe(res => {
      this.collection.data = res.data;
      this.collection.elementCount = res.elementCount;
      this.collection.pagesize;
      this.IncreasePageNumber()
      this.CheckElementsCount();
    });
  }

  loadNext() {

    this.serviceProvider.getAll(this.collection.pageNumber).subscribe(res => {
      this.collection.data = [...this.collection.data,...res.data];
      this.collection.elementCount = res.elementCount;
      this.IncreasePageNumber()
    });
  }

  IncreasePageNumber() : void {
    this.collection.pageNumber ++;
    this.CheckElementsCount();
  }

  CheckElementsCount() {
    if(this.collection.data.length >= this.collection.elementCount)
    this.dissableLoadMoreButton = true;
  }

  Init() {
    this.collection = {} as BaseCollection<T>;
    this.collection.pageNumber = 0;
  }

}
