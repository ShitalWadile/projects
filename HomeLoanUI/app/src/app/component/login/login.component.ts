import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from 'src/app/Services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private loginAuth: AuthService){ }

  ngOnInit(): void {}

  loginForm =new FormGroup(
    {
      email:new FormControl("",[Validators.required,Validators.email]),
      pwd: new FormControl("",[
        Validators.required,
        Validators.minLength(6),
        Validators.maxLength(15)
      ]),
    } );
  

get Email():FormControl{
  return this.loginForm.get('email') as FormControl;
}

get PWD(): FormControl{
  return this.loginForm.get('pwd') as FormControl;
}

loginSubmited(){
  this.loginAuth.loginUser([this.loginForm.value.email as string ,this.loginForm.value.pwd as string ]).subscribe((res:any)=>{
    console.log(res)
     })
  console.log(this.loginForm)
}


}
