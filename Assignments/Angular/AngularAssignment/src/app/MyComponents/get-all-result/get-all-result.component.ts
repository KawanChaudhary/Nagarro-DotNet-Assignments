import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ResultModel } from 'src/app/Models/ResultModel';
import { NotificationService } from 'src/app/services/notification.service';
import { ResultsService } from 'src/app/services/results.service';

@Component({
  selector: 'app-get-all-result',
  templateUrl: './get-all-result.component.html',
  styleUrls: ['./get-all-result.component.css']
})
export class GetAllResultComponent implements OnInit {

  results: ResultModel[] = [];
  size = 0;
  constructor(private resultService: ResultsService, private router: Router, 
    private notifyService: NotificationService){ }

  ngOnInit() {
    this.resultService.getAllResults().subscribe((results: ResultModel[] ) => {
      this.size = results.length;
      this.results = results
    });    
  }

  editResult(result: ResultModel){
    let link = "/editresult/" + result._id;
    this.router.navigate([link] , {state: {editResult: result}});
  }
  
  deleteResult(result: ResultModel){
    this.resultService.deleteResult(result._id).
    subscribe((results: ResultModel[]) => this.results = this.results.filter(t => t._id != result._id));

    this.notifyService.showSuccess(`Roll number ${result.rollNumber}'s entry has been erased.`, "Success");
  }

}
