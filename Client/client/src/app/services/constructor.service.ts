import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseCollection, Constructor, ServiceProvider } from '../entities/entities';

@Injectable({
  providedIn: 'root'
})
export class ConstructorService extends ServiceProvider<BaseCollection<Constructor>> {
  constructor(private http: HttpClient) {
    super();
  }

  override getAll(pageNumber: number) : Observable<BaseCollection<Constructor>> {
    return this.http.get<BaseCollection<Constructor>>(this.baseUrl + '/Constructors/GetAll?pageNumber=' + pageNumber);
  }
}
