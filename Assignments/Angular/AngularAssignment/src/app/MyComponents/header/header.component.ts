import { Component } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { filter } from 'rxjs';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {
  title = 'Result Management System';
  currentRoute: string;

  constructor(private router: Router) {
    this.router.events.pipe(filter(event => event instanceof NavigationEnd)
    ).subscribe(event => {
      //set breadcrumbs;
      this.currentRoute = router.url;
    });
  }

  isHomeComponent():boolean { 
    if(this.currentRoute === '/findresult') return false;
    else if(this.currentRoute === '/') return false;
    else if(this.currentRoute === '/viewresult/:id') return false;
    else return true;
   }

}
