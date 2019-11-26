import { Component, OnInit } from '@angular/core';
import { Training } from 'src/app/Models/training';
import { TrainingService } from 'src/app/Service/training.service';

@Component({
  selector: 'app-current',
  templateUrl: './current.component.html',
  styleUrls: ['./current.component.css']
})
export class CurrentComponent implements OnInit {

  list3:Training[]=[];
  constructor(private service1: TrainingService) { }

  ngOnInit() {
    this.service1.GetAll().subscribe(k=>{
      k.forEach(element => {
        if(element.status=="Current"){
          this.list3.push(element)
        }
      })
    });
  }
  
  

}
