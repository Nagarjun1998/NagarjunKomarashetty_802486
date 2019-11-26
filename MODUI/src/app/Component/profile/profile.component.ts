import { Component, OnInit, Input, Output ,EventEmitter} from '@angular/core';
import { trigger, transition, style, animate } from '@angular/animations';
import { MentorService } from 'src/app/Service/mentor.service';
import { Mentor } from 'src/app/Models/mentor';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {
 item1:Mentor;
 mentorid
  constructor(private service:MentorService) { 
  }

  ngOnInit() {
    this.mentorid=localStorage.getItem('mentorid');
    this.service.Search(this.mentorid).subscribe(k=>this.item1=k)


  }
  

}
