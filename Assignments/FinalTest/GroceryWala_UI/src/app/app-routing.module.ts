import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './MyComponents/home/home.component';
import { SignUpComponent } from './MyComponents/sign-up/sign-up.component';
import { SignInComponent } from './MyComponents/sign-in/sign-in.component';
import { ViewCartComponent } from './MyComponents/view-cart/view-cart.component';
import { AddNewProductComponent } from './MyComponents/add-new-product/add-new-product.component';
import { ViewAllProductsComponent } from './MyComponents/view-all-products/view-all-products.component';
import { ViewCategoryComponent } from './MyComponents/view-category/view-category.component';
import { ViewProductComponent } from './MyComponents/view-product/view-product.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'signup', component: SignUpComponent },
  { path: 'signin', component: SignInComponent },
  { path: 'viewcart', component: ViewCartComponent },
  { path: 'addnewproduct', component: AddNewProductComponent },
  { path: 'allproducts', component: ViewAllProductsComponent },
  { path: 'viewcategory/:category', component: ViewCategoryComponent },
  { path: 'viewproduct/:productid', component: ViewProductComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes,{
    onSameUrlNavigation: 'reload',
    scrollPositionRestoration: 'enabled'
  })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
