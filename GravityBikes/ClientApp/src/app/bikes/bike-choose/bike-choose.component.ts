import { Component, OnInit, Input } from '@angular/core';
import { Bike } from '../../_models/Bike';
import { BikeService } from '../../_services/bike.service';
import { AlertifyService } from '../../_services/alertify.service';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { environment } from 'src/environments/environment';
import {FileUploader} from 'ng2-file-upload';
import { HttpClient } from '@angular/common/http';

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
  afuConfig: any;
  selectedFile: File = null;
  hasBaseDropZoneOver = false;
  baseUrl = environment.apiUrl;

  constructor(private bikeService: BikeService, private alertify: AlertifyService, private fb: FormBuilder, private http: HttpClient) { }

  ngOnInit() {
    this.createBikeForm();
    this.loadBikes();
    this.initializeUploader();
  }
  initializeUploader() {
    this.afuConfig = {
      uploadAPI: {
        url: this.baseUrl + 'bikes/newbike',
        method: 'POST',
        fileNameIndex: false
      }
  };
  console.log(this.afuConfig);
  }

  onFileSelected(event) {
    this.selectedFile = <File>event.target.files[0];

  }
  onUpload() {
      const KeyArray = Object.keys(this.bikeForm.controls);
      const KeyArray2 = Object.values(this.bikeForm.value);
      const fd = new FormData();
        console.log(KeyArray, KeyArray2);
      for (let i = 0; i < KeyArray2.length; i++) {
        const helper = KeyArray2[i].toString();
        console.log(helper, i);
        fd.append(KeyArray[i], helper);
      }
    fd.append('file', this.selectedFile);
    this.http.post(this.baseUrl + 'bikes/newbike', fd)
    .subscribe(res => {
      console.log(res);
    });
  }
  createBikeForm() {
    this.bikeForm = this.fb.group({
      bikePrice: ['', Validators.required],
      bikeModel: ['', Validators.required],
      isMale: [true, Validators.required],
      isFemale: [true, Validators.required],
      sCount: ['', Validators.required],
      mCount: ['', Validators.required],
      lCount: ['', Validators.required],
      xlCount: ['', Validators.required],
      description: ['', Validators.required]
    });
  }

  fileOverBase(e: any): void {
    this.hasBaseDropZoneOver = e;
  }


  loadBikes() {
    this.bikeService.getBikes().subscribe((bikes: Bike[]) => {
      this.bikes = bikes;
    }, error => {
      this.alertify.error(error);
    });
  }
}
