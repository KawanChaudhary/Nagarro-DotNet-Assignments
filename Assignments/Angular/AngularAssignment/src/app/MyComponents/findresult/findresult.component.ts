import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ResultModel } from 'src/app/Models/ResultModel';
import { NotificationService } from 'src/app/services/notification.service';
import { ResultsService } from 'src/app/services/results.service';

@Component({
  selector: 'app-findresult',
  templateUrl: './findresult.component.html',
  styleUrls: ['./findresult.component.css']
})

export class FindresultComponent {
  result: ResultModel;
  seeResult: boolean;

  msg: string;
  link: string;


  constructor(private resultService: ResultsService, private router: Router,
    private notifyService: NotificationService) {
    this.seeResult = undefined;
  }

  onSubmit(details: ResultModel) {

    this.resultService.getResult(details).subscribe(
      {
        next: (result: ResultModel) => {
          this.result = result;
          this.msg = "Result Found. ";
          this.link = "/viewresult/" + this.result._id;
          this.notifyService.showSuccess(this.msg, "Success");
          this.router.navigate([this.link], { state: { result: this.result } });

        },
        error: (error: Error) => {
          this.msg = "Result Not Found. Invalid details.";
          this.notifyService.showError(this.msg, "Failed");
        }
      }
    );
  }
}