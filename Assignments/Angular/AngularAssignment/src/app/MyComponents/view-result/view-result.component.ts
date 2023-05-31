import { Component, OnInit} from '@angular/core';
import { Router } from '@angular/router';
import { ResultModel } from 'src/app/Models/ResultModel';

@Component({
  selector: 'app-view-result',
  templateUrl: './view-result.component.html',
  styleUrls: ['./view-result.component.css']
})
export class ViewResultComponent implements OnInit {

  result: ResultModel;

  constructor(private router: Router) {
    this.result = this.router.getCurrentNavigation()
      .extras.state['result'];
  }
  
  ngOnInit() {
    
  }
  
}
