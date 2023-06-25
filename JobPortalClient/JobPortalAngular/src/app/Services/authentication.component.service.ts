import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { FormGroup } from '@angular/forms';
import { JWTToken } from '../Interface/JwtToken';
import { Login } from '../Interface/Login';

@Injectable()
export class AuthenticationService {
  constructor(private router: Router, private http: HttpClient) {}

  apiurl = 'https://localhost:7128/api/Authentication/login';

  token?: JWTToken;
  login?: Login;

  getLoginToken(loginForm: FormGroup) {
    this.login = loginForm.value as Login;

    this.http.post(this.apiurl, this.login).subscribe({
      next: (data) => {
        this.token = data as JWTToken;
        if (this.token.token) {
          sessionStorage.setItem('token', this.token.token);
          sessionStorage.setItem('role', this.token.role);
          this.router.navigate([this.token.role]);
        }
      },
      error: (error) => {
        console.log(error);

        alert('Incorrect UserName and Password !');
      },
      complete: () => {
        console.log('Login Completed');
      },
    });
  }
}
