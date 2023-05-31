import { Component, ViewChild } from '@angular/core';
import { ResultModel } from 'src/app/Models/ResultModel';
import { NotificationService } from 'src/app/services/notification.service';
import { ResultsService } from 'src/app/services/results.service';
@Component({
  selector: 'app-addresult',
  templateUrl: './addresult.component.html',
  styleUrls: ['./addresult.component.css']
})
export class AddresultComponent {

  result: ResultModel;

  @ViewChild('name') name: any;
  @ViewChild('rollNumber') rollNumber: any;
  @ViewChild('dateOfbirth') dateOfbirth: any;
  @ViewChild('score') score: any;

  constructor(private resultService: ResultsService, private notifyService: NotificationService) {
  }

  onSubmit(data: ResultModel) {

    
    this.resultService.addResult(data).subscribe(
      {
        next: (result: ResultModel) => {
          this.result = result
          this.notifyService.showSuccess(`New record has been added for roll number ${data.rollNumber}.`, "Success");
          this.name.nativeElement.value = '';
          this.dateOfbirth.nativeElement.value = '';
          this.rollNumber.nativeElement.value = '';
          this.score.nativeElement.value = '';
        },
        error: (error: Error) => {
          this.notifyService.showError("Roll Number already exist.", "Failed");
        }
      }
    );
  }

}
