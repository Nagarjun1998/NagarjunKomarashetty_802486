import { Injectable } from '@angular/core';
import { Training } from '../Models/training';
import { Mentor } from '../Models/mentor';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Payment } from '../Models/payment';

@Injectable({
  providedIn: 'root'
})
export class PaymentService {
item2:Training;
item:Mentor;
fees:number;
duration:number;
toc:string;
item3:Payment;
path:string='http://localhost:51358/api/Payment';

  constructor(private client: HttpClient) { }
  paydetails(item2:Training,item:Mentor,fees,duration,toc){
   this.item2=item2;
   this.item=item;
   this.fees=fees;
   this.duration=duration;
   this.toc=toc;
  }

  public Add(item3:Payment):Observable<any>
  {
    return this.client.post<any>(this.path+'/Add',item3)
  }
}
