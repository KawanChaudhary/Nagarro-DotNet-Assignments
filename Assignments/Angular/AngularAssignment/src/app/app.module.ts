import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { HeaderComponent } from './MyComponents/header/header.component';
import { HomeComponent } from './MyComponents/home/home.component';
import { GetAllResultComponent } from './MyComponents/get-all-result/get-all-result.component';
import { AppRoutingModule } from './app-routing.module';
import { AddresultComponent } from './MyComponents/addresult/addresult.component';
import { FormsModule } from '@angular/forms';
import { DatePipe } from '@angular/common';
import { FindresultComponent } from './MyComponents/findresult/findresult.component';
import { ViewResultComponent } from './MyComponents/view-result/view-result.component';
import { EditresultComponent } from './MyComponents/editresult/editresult.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';



@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    GetAllResultComponent,
    AddresultComponent,
    FindresultComponent,
    ViewResultComponent,
    EditresultComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    DatePipe,
    NgbModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
