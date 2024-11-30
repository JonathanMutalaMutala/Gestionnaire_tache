import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'; 
import { lastValueFrom } from 'rxjs';
import { ColumnDto } from './column-dto-model';

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
  async getAllColumn(): Promise<ColumnDto[]> {
   console.log('calling API ...')
   let url = "https://localhost:7263/api/Column/GetAll"

    try {
      const result = await lastValueFrom(this.http.get<ColumnDto[]>(url))
      return result;
    }
    catch (error) {
     console.log('error from API', error)
     throw error; 
   }

 }
}
