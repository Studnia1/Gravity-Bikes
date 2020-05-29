import { Component, Inject} from '@angular/core';
import {MatDialog, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { AuthService } from '../_services/auth.service';



@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrls: ['./dialog.component.css']
})
export class DialogComponent {
  constructor(public dialog: MatDialog) {}

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
    console.log('no i mnie nie ma :/');
  }
}
@Component({
  selector: 'app-dialog-show-component',
  templateUrl: 'dialog-show-component.html',
})
export class DialogShowComponent {
  constructor(private authService: AuthService) {}
  model: any = {};
  login() {
    this.authService.login(this.model).subscribe(next => {
      console.log('gitara siema');
    }, error => {
      console.log('slabo:/');
    });
  }
}
