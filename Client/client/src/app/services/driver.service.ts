import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseCollection, Driver, ServiceProvider } from '../entities/entities';

@Injectable({
  providedIn: 'root'
})
export class DriverService extends ServiceProvider<BaseCollection<Driver>> {
  constructor(private http: HttpClient) {
    super();
  }

  override getAll(pageNumber: number) : Observable<BaseCollection<Driver>> {
    return this.http.get<BaseCollection<Driver>>(this.baseUrl + '/Drivers/GetAll?pageNumber=' + pageNumber);
  }
}
