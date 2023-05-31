import { Injectable } from '@angular/core';
import { WebService } from './web.service';
import { ResultModel } from '../Models/ResultModel';

@Injectable({
  providedIn: 'root'
})
export class ResultsService {

  constructor(private webService: WebService) { }

  getAllResults() {
    return this.webService.getAll('result');
  }
  getResult(payload: ResultModel) {
    return this.webService.getDetails(`result/details`, payload);
  }

  getById(id: string) {
    return this.webService.getById(`result/${id}`);
  }

  addResult(payload: ResultModel) {
    return this.webService.post('result', payload);
  }

  updateResult(id: string, payload: ResultModel) {
    return this.webService.put(`result/${id}`, payload);
  }
  
  deleteResult(id: string) {
    return this.webService.delete(`result/${id}`);
  }
}
