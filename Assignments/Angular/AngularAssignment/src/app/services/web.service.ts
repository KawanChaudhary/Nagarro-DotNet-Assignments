import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ResultModel } from '../Models/ResultModel';

@Injectable({
  providedIn: 'root'
})
export class WebService {
  readonly ROOT_URL;
  constructor(private http: HttpClient) {
    this.ROOT_URL = "http://localhost:3000"; 
  }

  getDetails(url: string, payload: ResultModel){
    return this.http.post(`${this.ROOT_URL}/${url}`, payload);
  }

  getById(url: string){
    return this.http.get(`${this.ROOT_URL}/${url}`);
  }

  post(url: string, payload: ResultModel){
    return this.http.post(`${this.ROOT_URL}/${url}`, payload);
  }

  put(url: string, payload: ResultModel){
    return this.http.put(`${this.ROOT_URL}/${url}`, payload);
  }

  delete(url: string){
    return this.http.delete(`${this.ROOT_URL}/${url}`);
  }

  getAll(url: string){
    return this.http.get(`${this.ROOT_URL}/${url}`);
  }

}
