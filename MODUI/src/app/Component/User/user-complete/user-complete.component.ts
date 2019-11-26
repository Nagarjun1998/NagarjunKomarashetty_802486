import { Component, OnInit } from '@angular/core';
import { TrainingService } from 'src/app/Service/training.service';
import { Training } from 'src/app/Models/training';

@Component({
  selector: 'app-user-complete',
  templateUrl: './user-complete.component.html',
  styleUrls: ['./user-complete.component.css']
})
export class UserCompleteComponent implements OnInit {
list3:Training[]=[];
  constructor(private service1:TrainingService) { }

  ngOnInit() {
    this.service1.GetAll().subscribe(k=>{
      k.forEach(element => {
        if(element.status=="Completed" && element.userId==localStorage.getItem('userid')){
          this.list3.push(element)
        }
      })
    });
  }

}
