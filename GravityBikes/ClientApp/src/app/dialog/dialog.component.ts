import { Component, Inject} from '@angular/core';
import {MatDialog, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';



@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrls: ['./dialog.component.css']
})
export class DialogComponent {
  constructor(public dialog: MatDialog, private alertify: AlertifyService) {}

  openDialog() {
    this.dialog.open(DialogShowComponent);
  }
  loggedIn() {
    const token = localStorage.getItem('token');
    if (!!token) {
      this.dialog.closeAll();
    }
    return !!token;
  }
  logout() {
    localStorage.removeItem('token');
    this.alertify.message('logged out');
  }
}
@Component({
  selector: 'app-dialog-show-component',
  templateUrl: 'dialog-show-component.html',
})
export class DialogShowComponent {
  constructor(private authService: AuthService, private alertify: AlertifyService) {}
  model: any = {};
  login() {
    this.authService.login(this.model).subscribe(next => {
      this.alertify.success('logged in successful');
    }, error => {
      this.alertify.error(error);
    });
  }
}
