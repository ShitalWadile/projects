import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { RegisterComponent } from '../component/register/register.component';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  [x: string]: any;
  // [x: string]: any;

  constructor(private http: HttpClient) { }
 private baseUrl:string="//https://localhost:7026/api/";
  registerUser(user:Array<String>){
  this.http.post(this.baseUrl+"User/CreateUser",{
   FirstName:user[0],
   LastName:user[1],
   Email:user[2],
   Mobile:user[3],
   Gender:user[4],
   Pwd:user[5],

  },
  {
    responseType:'text',
  });
  }
loginUser(loginInfo: Array<string>){
 return this.http.post(this.baseUrl+'Login',{
  Email:loginInfo[0],
  Pwd:loginInfo[1],
 },
 {
 responseType:'text',

  } );
}

}
