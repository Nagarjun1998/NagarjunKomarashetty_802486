import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Mentor } from '../Models/mentor';

@Injectable({
  providedIn: 'root'
})
export class MentorService {

  item:Mentor;
  path:string='http://localhost:49924/Mentor';
  constructor(private client:HttpClient) { }

  Send(item:Mentor){
    this.item=item;
  }
  public GetAll():Observable<Mentor[]>
  {
    return this.client.get<Mentor[]>(this.path+'/GetAll');
  }
  public Add(item:Mentor):Observable<any>
  {
    return this.client.post<any>(this.path+'/Add',item)
  }
  public Delete(id:string)
    {
        return this.client.delete(this.path+'/Delete/'+id);
    }
    public Search(id:string):Observable<Mentor>
    {
      return this.client.get<Mentor>(this.path+'/GetById/'+id);
    }
    public Block(id:string)
    {
      return this.client.put(this.path +'/Mentor_Block/'+id,id);
    }
}
