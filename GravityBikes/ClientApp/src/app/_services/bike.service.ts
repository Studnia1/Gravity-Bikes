import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Bike } from '../_models/Bike';
import { BikeDates } from '../_models/BikeDates';

@Injectable({
  providedIn: 'root'
})
export class BikeService {
  baseUrl = environment.apiUrl;
  constructor(private http: HttpClient) { }

  getBikes(): Observable<Bike[]> {
    return this.http.get<Bike[]>(this.baseUrl + 'bikes');
  }
  getBike(id): Observable<Bike> {
    return this.http.get<Bike>(this.baseUrl + 'bikes/' + id);
  }
  getDates(model): Observable<BikeDates[]> {
    return this.http.post<BikeDates[]>(this.baseUrl + 'bikes/availablebikes', model);
  }
}
