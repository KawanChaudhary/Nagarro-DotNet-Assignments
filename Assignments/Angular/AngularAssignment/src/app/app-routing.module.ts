import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router'; // CLI imports router
import { HomeComponent } from './MyComponents/home/home.component';
import { GetAllResultComponent } from './MyComponents/get-all-result/get-all-result.component';
import { AddresultComponent } from './MyComponents/addresult/addresult.component';
import { FindresultComponent } from './MyComponents/findresult/findresult.component';
import { ViewResultComponent } from './MyComponents/view-result/view-result.component';
import { EditresultComponent } from './MyComponents/editresult/editresult.component';

const routes: Routes = [
  { path: '', component:  HomeComponent,},
  { path: 'getallresults', component:  GetAllResultComponent},
  { path: 'editresult/:id', component: EditresultComponent},
  { path: 'addresults', component: AddresultComponent},
  { path: 'findresult', component: FindresultComponent},
  { path: 'viewresult/:id', component: ViewResultComponent},
];

// configures NgModule imports and exports

  
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }