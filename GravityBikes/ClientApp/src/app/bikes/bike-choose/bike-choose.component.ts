import { Component, OnInit, Input } from '@angular/core';
import { Bike } from '../../_models/Bike';
import { BikeService } from '../../_services/bike.service';
import { AlertifyService } from '../../_services/alertify.service';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { environment } from 'src/environments/environment';
import {FileUploader} from 'ng2-file-upload';

@Component({
  selector: 'app-bike-choose',
  templateUrl: './bike-choose.component.html',
  styleUrls: ['./bike-choose.component.css']
})
export class BikeChooseComponent implements OnInit {
  bikes: Bike[];
  bikeForm: FormGroup;
  checkedFemale: boolean;
  checkedMale: boolean;
  uploader: FileUploader;
  hasBaseDropZoneOver = false;
  baseUrl = environment.apiUrl;
  constructor(private bikeService: BikeService, private alertify: AlertifyService, private fb: FormBuilder) { }

  ngOnInit() {
    this.createBikeForm();
    this.loadBikes();
    this.initializeUploader();
  }
  createBikeForm() {
    this.bikeForm = this.fb.group({
      bikePrice: ['', Validators.required],
      bikeModel: ['', Validators.required],
      isMale: [true, Validators.required],
      isFemale: ['', Validators.required],
      sCount: ['', Validators.required],
      mCount: ['', Validators.required],
      lCount: ['', Validators.required],
      xlCount: ['', Validators.required]
    });
  }

  fileOverBase(e: any): void {
    this.hasBaseDropZoneOver = e;
  }

  initializeUploader() {
    this.uploader = new FileUploader({
      url: this.baseUrl + 'bikes/newbike',
      isHTML5: true,
      allowedFileType: ['image'],
      removeAfterUpload: true,
      autoUpload: false
    });
  }

  loadBikes() {
    this.bikeService.getBikes().subscribe((bikes: Bike[]) => {
      this.bikes = bikes;
    }, error => {
      this.alertify.error(error);
    });
  }
}
