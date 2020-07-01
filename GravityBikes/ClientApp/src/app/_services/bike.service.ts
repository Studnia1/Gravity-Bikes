import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Bike } from '../_models/Bike';

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
}
