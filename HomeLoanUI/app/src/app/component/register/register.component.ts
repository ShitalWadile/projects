import { Component, OnInit  } from '@angular/core';
import{FormControl,FormGroup, Validators} from '@angular/forms';
// import { Observable} from 'rxjs';
import { AuthService } from 'src/app/Services/auth.service';
import { Observable } from 'rxjs';
import { ActivatedRoute,Data} from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit{
  repeatPass: string='none';

  displayMsg : string="";
  isAccountCreated: boolean=false;

  
  constructor(private registerAuth:AuthService){}

 
  registerObservable!: Observable<RegisterComponent[]>;
  ngOnInit():void{
    
  } 
  

  registerForm=new FormGroup({
    firstname:new FormControl("",[
      Validators.required,
      Validators.minLength(2),
      Validators.pattern('[a-zA-Z].*'),

    ]),
    lastname:new FormControl("",[
      Validators.required,
      Validators.minLength(2),
      Validators.pattern('[a-zA-Z].*')
    ]),
    email: new FormControl("",[
      Validators.required,
      Validators.email,
    ]),
    mobile:new FormControl("",[

      Validators.required,
      Validators.pattern("[0-9]*"),
      Validators.minLength(10),
      Validators.maxLength(10),
    ]),
    gender: new FormControl(""),
    pwd: new FormControl("",[
      Validators.required,
      Validators.minLength(8),
      Validators.maxLength(15),
    ]),
    rpwd: new FormControl(""),

  });

get FirstName():FormControl{
  return this.registerForm.get('firstname') as FormControl;
}

get LastName():FormControl{
  return this.registerForm.get('lastname')as FormControl;
}

get Email():FormControl{
  return this.registerForm.get('email')as FormControl;
}

get Mobile():FormControl{
  return this.registerForm.get('mobile') as FormControl;
}

get Gender():FormControl{
  return this.registerForm.get('gender')as FormControl;
}

get PWD():FormControl{
  return this.registerForm.get('pwd') as FormControl;
}

get RPWD():FormControl{
  return this.registerForm.get('rpwd') as FormControl;
}


registerSubmited(){
 if(this.PWD.value==this.RPWD.value){
  console.log(this.registerForm.valid);
  this.repeatPass ='none';

  // this.registerAuth
  // .registerUser([
  //   this.registerForm.value.firstname as string ,
  //   this.registerForm.value.lastname as string ,
  //   this.registerForm.value.email as string ,
  //   this.registerForm.value.mobile as string,
  //   this.registerForm.value.gender as string,
  //   this.registerForm.value.pwd as string ,
  //   this.registerForm.value.rpwd as string
  // ])
  // .subscribe((res: any)=>{
  //   if(res=='Success'){
  //     this.displayMsg = 'Account Created Successfully';
  //     this.isAccountCreated = true;
  //   }
  //   else if(res== 'Alreadyexists'){
  //     this.displayMsg='Account Already Exist,try Another Email';
  //   }
  //  console.log(res);
  // })
  //  }
  //  else{
  //    this.repeatPass='inline';
  //  }
  //  console.log(this.registerForm);
}

}
}                   