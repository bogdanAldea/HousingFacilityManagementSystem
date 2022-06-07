import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-admin-apartment-edit',
  templateUrl: './admin-apartment-edit.component.html',
  styleUrls: ['./admin-apartment-edit.component.css']
})
export class AdminApartmentEditComponent implements OnInit {

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit(): void {
  }

  editApartmentForm = this.formBuilder.group({
    residents: ["", [Validators.min(0)]],
    surfaceArea: ["", [Validators.min(0)]],
    payment: [{value: "", disabled: true}],
    debt: [{value: "", disabled: true}, Validators.min(0)]
  })

  onSubmit(){}

}
