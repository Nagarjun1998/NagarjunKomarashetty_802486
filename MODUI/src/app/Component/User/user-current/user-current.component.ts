import { Component, OnInit } from '@angular/core';
import { Training } from 'src/app/Models/training';
import { TrainingService } from 'src/app/Service/training.service';

@Component({
  selector: 'app-user-current',
  templateUrl: './user-current.component.html',
  styleUrls: ['./user-current.component.css']
})
export class UserCurrentComponent implements OnInit {

  list3:Training[]=[];
  list1:Training;
  msg:string;
  showDialog;
  constructor(private service1:TrainingService) {
    this.list1 = new Training();
   }

  ngOnInit() {
    this.service1.GetAll().subscribe(k=>{
      k.forEach(element => {
        if(element.status=="Current" && element.userId==localStorage.getItem('userid')){
          this.list3.push(element)
        }
      })
    });
  }
  

  GetStatById(sid:string)
 {
  this.service1.Search(sid).subscribe(k=>this.list1=k)

 }
 EditStatus()
 {
  this.service1.Update(this.list1).subscribe(k=>k=this.msg)
  alert('Successfull Update!!\n\n');
  

 }

 reload(){
   window.location.reload();
 }
}
