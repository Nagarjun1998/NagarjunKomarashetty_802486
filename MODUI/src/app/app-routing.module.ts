import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './Component/home/home.component';
import { LoginComponent } from './Component/login/login.component';
import { UserDashboardComponent } from './Component/User/user-dashboard/user-dashboard.component';
import { MentorDashboardComponent } from './Component/Mentor/mentor-dashboard/mentor-dashboard.component';
import { AdminComponent } from './Component/admin/admin.component';
import { UpdateDialogComponent } from './Component/update-dialog/update-dialog.component';
import { PropasalComponent } from './Component/propasal/propasal.component';
import { UserCurrentComponent } from './Component/User/user-current/user-current.component';
import { UserCompleteComponent } from './Component/User/user-complete/user-complete.component';
import { MentorCompleteComponent } from './Component/Mentor/mentor-complete/mentor-complete.component';
import { MentorCurrentComponent } from './Component/Mentor/mentor-current/mentor-current.component';
import { CurrentComponent } from './Component/current/current.component';
import { CompleteComponent } from './Component/complete/complete.component';
import { ProfileComponent } from './Component/profile/profile.component';
import { ContactComponent } from './Component/contact/contact.component';


const routes: Routes = [
 {path: '',component:HomeComponent},
 {path: 'home',component:HomeComponent},
 {path: 'login',component:LoginComponent},
 {path: 'udashboard',component:UserDashboardComponent},
 {path: 'profile',component:ProfileComponent},
 {path: 'contact',component:ContactComponent},

 {path: 'udashboard/ucomplete',component:UserCompleteComponent},
 {path: 'udashboard/ucurrent',component:UserCurrentComponent},
 {path: 'mdashboard/mcomplete',component:MentorCompleteComponent},
 {path: 'mdashboard/mcurrent',component:MentorCurrentComponent},
  {path: 'admin',component:AdminComponent},
  {path: 'admin/complete',component:CompleteComponent},
 {path: 'admin/current',component:CurrentComponent},
  {path:'update-dialog',component:UpdateDialogComponent},
  {path:'proposal',component:PropasalComponent},

// {path: 'about',component:AboutComponent},
// {path: 'contact',component:ContactComponent},
{path: 'mdashboard',component:MentorDashboardComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
