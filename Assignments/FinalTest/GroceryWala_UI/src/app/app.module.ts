import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './MyComponents/header/header.component';
import { HomeComponent } from './MyComponents/home/home.component';
import { CarouselComponent } from './MyComponents/carousel/carousel.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { SignUpComponent } from './MyComponents/sign-up/sign-up.component';
import { SignInComponent } from './MyComponents/sign-in/sign-in.component';
import { ViewCartComponent } from './MyComponents/view-cart/view-cart.component';
import { AddNewProductComponent } from './MyComponents/add-new-product/add-new-product.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ViewAllProductsComponent } from './MyComponents/view-all-products/view-all-products.component';
import { CategoriesComponent } from './MyComponents/categories/categories.component';
import { NgxPaginationModule } from 'ngx-pagination';
import { ViewCategoryComponent } from './MyComponents/view-category/view-category.component';
import { ViewProductComponent } from './MyComponents/view-product/view-product.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    CarouselComponent,
    SignUpComponent,
    SignInComponent,
    ViewCartComponent,
    AddNewProductComponent,
    ViewAllProductsComponent,
    CategoriesComponent,
    ViewCategoryComponent,
    ViewProductComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FontAwesomeModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),    
    NgxPaginationModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
