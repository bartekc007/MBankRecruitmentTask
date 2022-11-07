import { Observable, of } from "rxjs";
import { environment } from "src/environments/environment";

export interface Circuit extends EntityBase {
    ref: string;
    location: string;
    lat: string;
    ing: string;
    alt: string;
  }
  
  export interface Constructor extends EntityBase {
    ref: string;
    name: string;
    nationality: string;
  }
  
  export interface Driver extends EntityBase {
    ref: string;
    number: string;
    code: string;
    forename: string;
    surename: string;
    dob: string;
    natonality: string;
  }
  
  export interface Race extends EntityBase {
    year: string;
    round: string;
    circuitId: string;
    name: string;
    date: string;
    time: string;
  }

  export interface EntityBase {
    id: number;
  }

  export class BaseCollection<T extends EntityBase> {
    data:T[] = [];
    pageNumber: number = 0;
    elementCount: number = 0;
    pagesize = 25;
  }

  export class ServiceProvider<BaseCollection> {
    baseUrl = environment.apiUrl;
    getAll(pageNumber: number): Observable<BaseCollection> {
      return of();
    }
  }