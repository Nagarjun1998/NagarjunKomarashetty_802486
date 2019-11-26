import { Component, OnInit,  } from '@angular/core';
import { LoginService } from './Service/login.service';
import { FormGroup, FormBuilder } from '@angular/forms';
import { LoginComponent } from './Component/login/login.component';
import { Router } from '@angular/router';
import { SkillService } from './Service/skill.service';
import { Skill } from './Models/skill';
import { UserService } from './Service/user.service';
import { MentorService } from './Service/mentor.service';
import { Mentor } from './Models/mentor';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  
})
export class AppComponent implements OnInit {
  title = 'MentorOnDemandUI';

  technology;
  timestart;
  searchForm: FormGroup;
  submitted = false;
 m;
item:Mentor;
list:Mentor[];

  item1:Skill;
  list1:Skill[];

  mentorid;
  constructor(public myservice:LoginComponent,private formBuilder:FormBuilder,private router:Router,private service:SkillService,private service1:UserService,private service2:MentorService){
   
  }
  public isCollapsed = false;


  ngOnInit(){
    this.mentorid=localStorage.getItem('mentorid');
  }
  
  GetById(sid:string)
  {console.log(sid);
   this.service2.Search(sid).subscribe(k=>{this.service2.Send(this.item);})
   
  }

  
  isLogin(){
    if(localStorage.getItem('login')==="yes" )
    {
      this.m=localStorage.getItem("msg");
      return true;
     
    }
    else
        return false;

  }
  logoutUser(){
    localStorage.removeItem('login')
    localStorage.removeItem('role')
    localStorage.removeItem('msg')
    localStorage.removeItem('token')
    localStorage.removeItem('active')
    localStorage.removeItem('userid')
    localStorage.removeItem('mentorid')

    this.m="null";
    this.router.navigate(['/login'])
  }

 
}
