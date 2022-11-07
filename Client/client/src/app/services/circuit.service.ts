import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseCollection, Circuit, ServiceProvider } from '../entities/entities';

@Injectable({
  providedIn: 'root'
})

export class CircuitService extends ServiceProvider<BaseCollection<Circuit>> {
  constructor(private http: HttpClient) {
    super();
  }

  override getAll(pageNumber: number) : Observable<BaseCollection<Circuit>> {
    return this.http.get<BaseCollection<Circuit>>(this.baseUrl + '/Circuits/GetAll?pageNumber=' + pageNumber);
  }
}
