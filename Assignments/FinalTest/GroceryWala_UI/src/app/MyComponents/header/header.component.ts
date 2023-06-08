import { Component } from '@angular/core';
import { faSearch, faCartArrowDown } from '@fortawesome/free-solid-svg-icons';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {
  searchIcon = faSearch;
  cartIcon = faCartArrowDown;
}
