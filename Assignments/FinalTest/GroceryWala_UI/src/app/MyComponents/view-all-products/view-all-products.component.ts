import { Component, HostBinding, OnInit } from '@angular/core';
import { faIndianRupeeSign, faStar } from '@fortawesome/free-solid-svg-icons';
import { CategoryEnum } from 'src/app/Models/CategoryEnum';
import { ProductModel } from 'src/app/Models/ProductModel';
import { SizeTypeEnum } from 'src/app/Models/SizeTypeEnum';
import { AdminService } from 'src/app/services/admin/admin.service';
import { NotifyService } from 'src/app/services/notification/notify.service';

@Component({
  selector: 'app-view-all-products',
  templateUrl: './view-all-products.component.html',
  styleUrls: ['./view-all-products.component.css']
})
export class ViewAllProductsComponent implements OnInit {

  rupeeIcon = faIndianRupeeSign;
  starIcon = faStar;

 // @HostBinding("style.--img") img: string = ;

  pagination: number = 1;

  allProducts: any;

  allProductsCount: number = 0;

  constructor(private adminService: AdminService, private notifyService: NotifyService) { 
    document.documentElement.style.setProperty('--img', "url(./../../../assets/category/allproduct1.jpg)");
  }

  ngOnInit(): void {
    this.fetchProducts();
  }

  fetchProducts(){
    this.adminService.getAllProducts().subscribe(
      {
        next: (response: any) => {
          this.allProducts = response.response;
          this.allProductsCount = this.allProducts.length;
        },
        error: (error: Error) => {
          console.log(error);
          this.notifyService.showError(`Error: ${error.message}`, "Failed");
        }
      }
    );
  }

  renderPage(event: number) {
    this.pagination = event;
    this.fetchProducts();
  }

  returnCategoryType(val: number): string {
    return CategoryEnum[val];
  }

  returnSizeType(val: number): string {
    return SizeTypeEnum[val];
  }

}
