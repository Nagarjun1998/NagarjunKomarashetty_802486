import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Training } from '../Models/training';
import { Mentor } from '../Models/mentor';

@Injectable({
  providedIn: 'root'
})
export class TrainingService {
  path:string='http://localhost:49924/Training';
  item1:Training;
 
  constructor(private client: HttpClient) {
   }
training(item1:Training){
  this.item1 = item1;
  
}
  public Add():Observable<any>
  {
    return this.client.post<any>(this.path+'/Add',this.item1)
  }
  public GetAll():Observable<Training[]>
  {
    return this.client.get<Training[]>(this.path+'/GetAll');
  }
  public Search(id:string):Observable<Training>
  {
    return this.client.get<Training>(this.path+'/GetById/'+id);
  }
  public Update(item:Training)
    {
        return this.client.put(this.path+'/Update',item);
    }
}
