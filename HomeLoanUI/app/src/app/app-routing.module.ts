import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ApplicationformComponent } from './component/applicationform/applicationform.component';
import { CalculatorComponent } from './component/calculator/calculator.component';
import { FAQComponent } from './component/faq/faq.component';
import { HomeComponent } from './component/home/home.component';
import { LoginComponent } from './component/login/login.component';

import { RegisterComponent } from './component/register/register.component';
import { HeaderComponent } from './header/header.component';

const routes: Routes = [
  {path:'login',component:LoginComponent},
  {path:'register', component:RegisterComponent},
  {path:'applicationform',component:ApplicationformComponent},
  {path:'calculator', component:CalculatorComponent},
  {path:'faq',component:FAQComponent},
  {path:'home',component:HomeComponent},
  {path:'header', component:HeaderComponent}

  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
