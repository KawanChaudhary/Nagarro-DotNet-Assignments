import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ResultModel } from 'src/app/Models/ResultModel';
import { NotificationService } from 'src/app/services/notification.service';
import { ResultsService } from 'src/app/services/results.service';

@Component({
  selector: 'app-editresult',
  templateUrl: './editresult.component.html',
  styleUrls: ['./editresult.component.css']
})
export class EditresultComponent {

  editResult: ResultModel;
  
  constructor(private resultService: ResultsService, private router: Router, 
    private notifyService: NotificationService) {
    this.editResult = this.router.getCurrentNavigation()
      .extras.state['editResult'];
  }
  
  onSubmit(data: ResultModel){
    data._id = this.editResult._id;
    this.resultService.updateResult(data._id, data).subscribe((result: ResultModel) => this.editResult = result);
    this.notifyService.showSuccess("Details updated", "Success");
    this.router.navigate(['/getallresults']);
  }
}
