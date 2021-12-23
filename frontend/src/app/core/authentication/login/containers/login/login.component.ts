import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/core/services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  loginForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private authService: AuthService, private router: Router) {
    this.loginForm = this.formBuilder.group({
      email: '',
      password: ''
    });
  }

  ngOnInit(): void {
  }

  onSubmit() {
    this.login();
  }

  login() {
    this.authService.login(
      {
        email: this.loginForm.get('email')?.value,
        password: this.loginForm.get('password')?.value
      }
    )
    .subscribe(success => {
      if (success) {
        this.router.navigate(['/challenge']);
      }
    });
  }

}
