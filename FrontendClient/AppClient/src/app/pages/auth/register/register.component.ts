import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { AuthenticationService } from 'src/app/core/services/authentication.service';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(private authenticationService: AuthenticationService, private formBuilder: FormBuilder) { }

  ngOnInit(): void {
  }

  registerForm = this.formBuilder.group({
    firstName: ["", [Validators.required, Validators.minLength(5)]],
    lastName: ["", [Validators.required, Validators.minLength(5)]],
    email: ["", [Validators.required, Validators.email]],
    password: ["", [Validators.required]],
    username: ["", [Validators.required]],
    phoneNumber: ["", [Validators.required]]
  })

  public onSubmit()
  {
  }

}
