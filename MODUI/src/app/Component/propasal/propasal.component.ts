import { Component, OnInit, Input, Output ,EventEmitter} from '@angular/core';
import { trigger, transition, style, animate } from '@angular/animations';
import { Training } from 'src/app/Models/training';
import { TrainingService } from 'src/app/Service/training.service';
import { Router } from '@angular/router';
import { PaymentService } from 'src/app/Service/payment.service';
import { Mentor } from 'src/app/Models/mentor';
import { Payment } from 'src/app/Models/payment';

@Component({
  selector: 'app-propasal',
  templateUrl: './propasal.component.html',
  styleUrls: ['./propasal.component.css'],
  
})
export class PropasalComponent implements OnInit {
msg:string;
item2:Training;
item:Mentor;
fees:number;
duration:number;
toc:string;
username:string;
userid:string;
item3:Payment;
  constructor(private service: TrainingService,private router:Router,private payservice:PaymentService) { 
    this.item3=new Payment();
  }
 
  ngOnInit() {
    this.item2=this.payservice.item2;
    this.item=this.payservice.item;
    this.fees=this.payservice.fees;
    this.duration=this.payservice.duration;
    this.toc=this.payservice.toc;
    this.username=localStorage.getItem('msg');
    this.userid=localStorage.getItem('userid');

  }
 
  Pay(){
     this.service.Add().subscribe(k=>this.msg=k);
     this.item3.amount=this.fees;
     this.item3.mentorId=this.item.mentorId;
     this.item3.userId=this.userid;
     this.item3.trainingId=this.item2.trainingId;
     this.item3.amountToMentor=this.fees/2;
     this.payservice.Add(this.item3).subscribe(k=>this.msg=k);
     alert("Successfully Registered and paid!!!!");
     this.router.navigate(['/udashboard']);

  }
  Back(){
    this.router.navigate(['/udashboard']);

  }
}
