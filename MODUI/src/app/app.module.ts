import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule, FormControl } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule, NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { HomeComponent } from './Component/home/home.component';
import { UserSignupComponent } from './Component/User/user-signup/user-signup.component';
import { SignupModule } from './Component/signup/signup.module';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { MentorSignUpComponent } from './Component/Mentor/mentor-sign-up/mentor-sign-up.component';
import { LoginComponent } from './Component/login/login.component';
import { UserDashboardComponent } from './Component/User/user-dashboard/user-dashboard.component';
import { MentorDashboardComponent } from './Component/Mentor/mentor-dashboard/mentor-dashboard.component';
import { AdminComponent } from './Component/admin/admin.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DialogComponent } from './Component/dialog/dialog.component';
import { UpdateDialogComponent } from './Component/update-dialog/update-dialog.component';
import { PropasalComponent } from './Component/propasal/propasal.component';
import { UserCompleteComponent } from './Component/User/user-complete/user-complete.component';
import { UserCurrentComponent } from './Component/User/user-current/user-current.component';
import { MentorCurrentComponent } from './Component/Mentor/mentor-current/mentor-current.component';
import { MentorCompleteComponent } from './Component/Mentor/mentor-complete/mentor-complete.component';
import { CurrentComponent } from './Component/current/current.component';
import { CompleteComponent } from './Component/complete/complete.component';
import { StatusDialogComponent } from './Component/status-dialog/status-dialog.component';
import { ProfileComponent } from './Component/profile/profile.component';
import { ContactComponent } from './Component/contact/contact.component';




@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    UserSignupComponent,
    MentorSignUpComponent,
    LoginComponent,
    UserDashboardComponent,
    MentorDashboardComponent,
    AdminComponent,
    DialogComponent,
    UpdateDialogComponent,
    PropasalComponent,
    UserCompleteComponent,
    UserCurrentComponent,
    MentorCurrentComponent,
    MentorCompleteComponent,
    CurrentComponent,
    CompleteComponent,
    StatusDialogComponent,
    ProfileComponent,
    ContactComponent,
 
  ],
  imports: [
    BrowserModule,
    SignupModule,
    FormsModule,
    BrowserAnimationsModule,
    NgbModule,
    HttpClientModule,
    ReactiveFormsModule,
    AppRoutingModule
  ],
  providers: [LoginComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
