import { Component } from '@angular/core';
import { faEnvelope, faUser, faPhone, faLockOpen, faLock } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent {
  emailIcon = faEnvelope;
  userIcon = faUser;
  phoneIcon = faPhone;
  passwordIcon = faLockOpen;
  confirmPasswordIcon = faLock
}
