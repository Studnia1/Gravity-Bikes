import { Component, Inject} from '@angular/core';
import {MatDialog, MAT_DIALOG_DATA} from '@angular/material/dialog';


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
}
@Component({
  selector: 'app-dialog-show-component',
  templateUrl: 'dialog-show-component.html',
})
export class DialogShowComponent {
  model: any = {};
  login() {
    console.log(this.model);
  }
}
