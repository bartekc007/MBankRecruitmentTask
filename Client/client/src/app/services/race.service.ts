import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseCollection, Race, ServiceProvider } from '../entities/entities';

@Injectable({
  providedIn: 'root'
})
export class RaceService extends ServiceProvider<BaseCollection<Race>> {
  constructor(private http: HttpClient) {
    super();
    
  }

  override getAll(pageNumber: number) : Observable<BaseCollection<Race>> {
    return this.http.get<BaseCollection<Race>>(this.baseUrl + '/Races/GetAll?pageNumber=' + pageNumber);
  }
}
