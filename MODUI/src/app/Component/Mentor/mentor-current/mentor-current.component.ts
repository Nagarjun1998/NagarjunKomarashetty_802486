import { Component, OnInit } from '@angular/core';
import { Training } from 'src/app/Models/training';
import { TrainingService } from 'src/app/Service/training.service';

@Component({
  selector: 'app-mentor-current',
  templateUrl: './mentor-current.component.html',
  styleUrls: ['./mentor-current.component.css']
})
export class MentorCurrentComponent implements OnInit {

list3:Training[]=[];
  constructor(private service1: TrainingService) { }

  ngOnInit() {
    this.service1.GetAll().subscribe(k=>{
      k.forEach(element => {
        if(element.status=="Current" && element.mentorId==localStorage.getItem('mentorid')){
          this.list3.push(element)
        }
      })
    });
  }
  

}
