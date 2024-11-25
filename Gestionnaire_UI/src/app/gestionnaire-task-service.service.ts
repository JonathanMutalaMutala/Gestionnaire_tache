import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'; 

@Injectable({
  providedIn: 'root'
})
export class GestionnaireTaskServiceService {

  constructor(private http:HttpClient) { }

  httpOptions= {
    headers:new HttpHeaders({
      'content-Type': 'application/json'
    })
  }; 
  getColumnById(column: any){
    console.log('calling')
    let url = "https://localhost:7263/api/Column?id=1"
    return this.http.get(url,column);
  }
}
