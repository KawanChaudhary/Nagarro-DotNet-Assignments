import { Component, HostBinding, OnChanges, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, NavigationEnd } from '@angular/router';
import { faIndianRupeeSign, faStar } from '@fortawesome/free-solid-svg-icons';
import { Subscription, filter } from 'rxjs';
import { CategoryEnum } from 'src/app/Models/CategoryEnum';
import { ProductModel } from 'src/app/Models/ProductModel';
import { SizeTypeEnum } from 'src/app/Models/SizeTypeEnum';
import { AdminService } from 'src/app/services/admin/admin.service';
import { NotifyService } from 'src/app/services/notification/notify.service';
import { ProductsService } from 'src/app/services/product/products.service';

@Component({
  selector: 'app-view-category',
  templateUrl: './view-category.component.html',
  styleUrls: ['./view-category.component.css']
})
export class ViewCategoryComponent implements OnInit, OnDestroy {

  rupeeIcon = faIndianRupeeSign;
  starIcon = faStar;

  // @HostBinding("style.--img") img: string = ;

  category: any = 0;

  pagination: number = 1;

  allProducts: any;

  allProductsCount: number = 0;

  private routeSub: Subscription;

  constructor(private productService: ProductsService, private notifyService: NotifyService, 
    private route: ActivatedRoute) {

      this.route.paramMap.subscribe(() => {
        this.ngOnInit();
    });

  }

  ngOnInit(): void {
    this.routeSub = this.route.params.subscribe(params => {
      this.category = params['category'];
    });
    this.returnCategoryImage(this.category);
    this.fetchProducts();


  }

  ngOnDestroy() {
    this.routeSub.unsubscribe();
  }

  fetchProducts() {
    this.productService.getProductByCategory(this.category).subscribe(
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

  returnPrice(price: number, discount: number): string {
    var res = price - price * discount / 100;
    if (res % 1 != 0) {
      return res.toFixed(2);
    }
    else return res.toString();
  }

  returnCategoryImage(val: number): void {
    if (val == 0) {
      document.documentElement.style.setProperty('--img', "url(./../../../assets/category/fruits&vegetables.jpg)");
    }
    else if (val == 1) {
      document.documentElement.style.setProperty('--img', "url(./../../../assets/category/dairy&bakery.png)");
    }
    else if (val == 2) {
      document.documentElement.style.setProperty('--img', "url(./../../../assets/category/snacks.png)");
    }
    else if (val == 4) {
      document.documentElement.style.setProperty('--img', "url(./../../../assets/category/frozenfood.jpg)");
    }
    else if (val == 3) {
      document.documentElement.style.setProperty('--img', "url(./../../../assets/category/beverages.jpg)");
    }
    else if (val == 5) {
      document.documentElement.style.setProperty('--img', "url(./../../../assets/category/condiments.jpg)");
    }
    else if (val == 6) {
      document.documentElement.style.setProperty('--img', "url(./../../../assets/category/cleaningsupplies.jpg)");
    }
    else if (val == 7) {
      document.documentElement.style.setProperty('--img', "url(./../../../assets/category/personalcare.jpg)");
    }
    else {
      document.documentElement.style.setProperty('--img', "url(./../../../assets/category/allproducts2.jpg)");
    }
  }

}
