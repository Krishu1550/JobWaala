import { Component } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { AuthenticationService } from 'src/app/Services/authentication.component.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {



  constructor(private fb :FormBuilder, private service:AuthenticationService){

  }
  loginForm= this.fb.group(
    {
      UserEmail:[''],
      Password: ['']
    }
  )


  getLoginForm()
  {
    console.log(this.loginForm.value);

    this.service.getLoginToken(this.loginForm);
  }

}
