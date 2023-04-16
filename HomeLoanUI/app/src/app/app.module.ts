import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import{HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegisterComponent } from './component/register/register.component';
import { LoginComponent } from './component/login/login.component';
import { ReactiveFormsModule } from '@angular/forms';
import { CalculatorComponent } from './component/calculator/calculator.component';
import { AuthService } from './Services/auth.service';
import { FAQComponent } from './component/faq/faq.component';
import { HomeComponent } from './component/home/home.component';
import { HeaderComponent } from './header/header.component';
import { ApplicationformComponent } from './component/applicationform/applicationform.component';


@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    LoginComponent,
    CalculatorComponent,
    FAQComponent,
    HomeComponent,
    HeaderComponent,
    ApplicationformComponent,
   
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,  
    HttpClientModule,
    

  ],
  providers: [
    AuthService
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
  
 }
