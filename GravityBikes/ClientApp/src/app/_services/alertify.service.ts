import { Injectable } from '@angular/core';
import * as alertify from 'alertifyjs';

@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

  constructor() { }

  confirm(message: string, agreeCallback: () => any) {
    alertify.confirm(message, (e: any) => {
      if (e) {
        agreeCallback();
      } else {}
    });
  }
  success(message: string) {
    alertify.success(message);
  }
  error(message: string) {
    alertify.error(message);
  }
  warning(message: string) {
    alertify.success(message);
  }
  message(message: string) {
    alertify.message(message);
  }
}
