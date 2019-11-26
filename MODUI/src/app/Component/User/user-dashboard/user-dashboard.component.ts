import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/Service/user.service';
import { Mentor } from 'src/app/Models/mentor';
import { SkillService } from 'src/app/Service/skill.service';
import { Skill } from 'src/app/Models/skill';
import { TrainingService } from 'src/app/Service/training.service';
import { Training } from 'src/app/Models/training';
import { Router } from '@angular/router';
import { PaymentService } from 'src/app/Service/payment.service';



@Component({
  selector: 'app-user-dashboard',
  templateUrl: './user-dashboard.component.html',
  styleUrls: ['./user-dashboard.component.css']
})
export class UserDashboardComponent implements OnInit {
item:Mentor;
list:Mentor[];
list1:Skill[];
SkillId:string[]=[];
Duration:number[]=[];
Toc:string[]=[];
list2:number[]=[];
item1:Training;
list3:Training;
technology;
timestart;
msg:string;
userid;
count;
currentdate=new Date();
status;
public isCollapsed = false;

i=1;
    constructor(private userService : UserService,private payservice:PaymentService,private service:SkillService,private service1:TrainingService,private router:Router) {
      this.item1= new Training();
     
     }
  ngOnInit() {

  }
  Load(){
    this.service.GetAll().subscribe(data=>this.list1=data)
  }
  
  onSubmit(){
    this.userService.SearchMentor(this.technology,this.timestart).subscribe(k=>{
      this.list=k;
      k.forEach(element => {
        console.log(element)
            this.service.GetName(element.technologies).subscribe(j=>{
                if(j!=null){
                  this.list2.push(j.fees)
                  this.SkillId.push(j.skillId)
                  this.Duration.push(j.duration)
                  this.Toc.push(j.toc);
                  console.log(j.fees);
                }
                else{
                  console.log(null);

                  this.list2.push(null)
                }})
      });
      if(this.list2!=null){
        this.count= k.length;
      }
      else{
        this.count=0;
      }
    });
  }

 Send(id:string,timeslot:string,technology:string,fees:number,sid:string,duration:number,toc:string,item:Mentor)
 {
   if(localStorage.getItem("login")=="yes"){
     this.item1.userId=localStorage.getItem("userid");
     this.item1.mentorId=id;
     this.item1.timeslot=timeslot;
     this.item1.trainingName=technology;
     this.item1.progress="0%";
     this.item1.startDate= new Date();
     this.item1.endDate= new Date(this.currentdate.setDate(this.currentdate.getDate()+duration)); 
     if(this.item1.startDate===this.item1.endDate)
     {
      this.item1.status="Completed";
     }
     else
     {
      this.item1.status="Current";
     }
     this.item1.paymentStatus=null;
     this.item1.requested=true;
     this.item1.rejectNotify=false;
     this.item1.rating=null;
     this.item1.skillId=sid;

     this.service1.training(this.item1);
     this.payservice.paydetails(this.item1,item,fees,duration,toc);
     this.router.navigate(['/proposal'])
   }
   else{
     alert("Sorry To interrupt !!You Must Login");
    this.router.navigate(['/login'])

   }
   

 }
}
