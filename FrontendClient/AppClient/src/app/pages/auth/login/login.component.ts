import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthenticationService } from 'src/app/core/services/authentication.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private authenticationService: AuthenticationService, private formBuilder: FormBuilder, private router: Router) { }

  ngOnInit(): void {
  }

  loginForm = this.formBuilder.group({
    email: ["", [Validators.required, Validators.email]],
    password: ["", [Validators.required]],
  })

  public onSubmit()
  {
    var credentials: any = this.loginForm.value;
    this.authenticationService.login(credentials).subscribe(response => console.log(response))
    this.router.navigate(["/dashboard"])
  }
}
