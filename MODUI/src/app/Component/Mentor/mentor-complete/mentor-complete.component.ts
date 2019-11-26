import { Component, OnInit } from '@angular/core';
import { TrainingService } from 'src/app/Service/training.service';
import { Training } from 'src/app/Models/training';

@Component({
  selector: 'app-mentor-complete',
  templateUrl: './mentor-complete.component.html',
  styleUrls: ['./mentor-complete.component.css']
})
export class MentorCompleteComponent implements OnInit {
list3:Training[]=[];
  constructor(private service1:TrainingService) { }

  ngOnInit() {
    this.service1.GetAll().subscribe(k=>{
      k.forEach(element => {
        if(element.status=="Completed" && element.mentorId==localStorage.getItem('mentorid')){
          this.list3.push(element)
        }
      })
    });
  }
  

}
