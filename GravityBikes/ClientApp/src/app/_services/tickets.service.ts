import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Tickets } from '../_models/Ticket';
import { retry } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class TicketsService {
baseUrl = environment.apiUrl;
  constructor(private http: HttpClient) { }
  getTickets(): Observable<Tickets[]> {
    return this.http.get<Tickets[]>(this.baseUrl + 'tickets');
  }
  postTicket(model: any) {
    return this.http.post(this.baseUrl + 'tickets/newticket', model);
  }
}
