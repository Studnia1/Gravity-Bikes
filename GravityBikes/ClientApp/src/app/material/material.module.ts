import { NgModule } from '@angular/core';
import {MatMenuModule, MatToolbarModule, MatButtonModule, MatSidenavModule, MatIconModule, MatListModule, MatInputModule } from '@angular/material';
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatDialogModule} from '@angular/material/dialog';

const material = [
  MatToolbarModule,
  MatButtonModule,
  MatSidenavModule,
  MatIconModule,
  MatListModule,
  MatDialogModule,
  MatInputModule,
  MatDialogModule,
  MatMenuModule,
  MatCheckboxModule
];



@NgModule({

  imports: [material
  ],
  exports: [material
  ]
})
export class MaterialModule { }
