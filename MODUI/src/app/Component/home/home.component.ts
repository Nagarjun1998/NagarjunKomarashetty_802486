import { Component, OnInit } from '@angular/core';
import { SkillService } from 'src/app/Service/skill.service';
import { Skill } from 'src/app/Models/skill';
import { UserService } from 'src/app/Service/user.service';
import { Mentor } from 'src/app/Models/mentor';
import { Training } from 'src/app/Models/training';
import { TrainingService } from 'src/app/Service/training.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
item1:Skill;
list1:Skill[];
showDialog;

item:Mentor;
list:Mentor[];
SkillId:string[]=[];
Duration:number[]=[];

list2:number[]=[];
item3:Training;
list3:Training[];
msg:string;
userid;
count;
currentdate=new Date();
technology;
timestart;
  constructor(private service:SkillService,private userService:UserService,private service1:TrainingService,private router:Router ) {
    this.item3= new Training();

   }

  ngOnInit() {
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
  Send(id:string,timeslot:string,technology:string,sid:string,duration:number)
 {
   if(localStorage.getItem("login")=="yes"){
     this.item3.userId=localStorage.getItem("userid");
     this.item3.mentorId=id;
     this.item3.timeslot=timeslot;
     this.item3.trainingName=technology;
     this.item3.progress="0%";
     this.item3.startDate= new Date();
     this.item3.endDate= new Date(this.currentdate.setDate(this.currentdate.getDate()+duration)); 
     if(this.item3.startDate===this.item3.endDate)
     {
      this.item3.status="Completed";
     }
     else
     {
      this.item3.status="Current";
     }
     this.item3.paymentStatus=null;
     this.item3.requested=true;
     this.item3.rejectNotify=false;
     this.item3.rating=null;
     this.item3.skillId=sid;

     this.service1.training(this.item3);
    // this.router.navigate(['/proposal'])
   }
   else{
    alert('Sorry To Interrupt! You Must Login First!!\n\n');
    this.router.navigate(['/login'])

   }
   

 }
}
