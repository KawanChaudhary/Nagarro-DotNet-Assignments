import { Component, ElementRef, HostBinding, HostListener, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { faIndianRupeeSign, faStar, faPlus, faMinus, faShoppingBasket } from '@fortawesome/free-solid-svg-icons';
import { Subscription } from 'rxjs';
import { CategoryEnum } from 'src/app/Models/CategoryEnum';
import { SizeTypeEnum } from 'src/app/Models/SizeTypeEnum';
import { NotifyService } from 'src/app/services/notification/notify.service';
import { ProductsService } from 'src/app/services/product/products.service';
@Component({
  selector: 'app-view-product',
  templateUrl: './view-product.component.html',
  styleUrls: ['./view-product.component.css']
})
export class ViewProductComponent implements OnInit, OnDestroy {

  //Icon
  rupeeIcon = faIndianRupeeSign;
  staricon = faStar;
  plusIcon = faPlus;
  minusIcon = faMinus;
  shoppingBasketIcon = faShoppingBasket;

  // activated routes
  routeSub: Subscription;

  //products variables
  productId: any = 0;
  product = {
    id: 6,
    name: "Apples",
    price: 100,
    description: "Apples",
    quantity: 1,
    category: 0,
    stock: 10,
    discount: 0,
    sizeType: SizeTypeEnum.kg,
    rating: 0,
    totalRatings: 0,
    otherDetails: "",
    reviewCount: 0,
  }
  images: any[] = [{ 
    id: 1, 
    productId: '1', 
    imageAddress: 'http://127.0.0.1:8080/images/8\\266577-2_4-kissan-mixed-fruit-jam.jpg' }
  ];

  // no. of items to buy
  totalItems = 1;

  currentImageIndex:number = 0;

  constructor(private productService: ProductsService, private notifyService: NotifyService, 
    private route: ActivatedRoute) {

  }

  ngOnInit(): void {
    this.routeSub = this.route.params.subscribe(params => {
      this.productId = params['productid'];
    });
    this.fetchProducts();
  }

  ngOnDestroy() {
    this.routeSub.unsubscribe();
  }

  fetchProducts() {
    this.productService.getProductById(this.productId).subscribe(
      {
        next: (response: any) => {
          this.product = response.product;
          this.images = response.images;
        },
        error: (error: Error) => {
          console.log(error);
          this.notifyService.showError(`Error: ${error.message}`, "Failed");
        }
      }
    );
  }

  returnCategoryType(val: number): string {
    return CategoryEnum[val];
  }

  returnSizeType(val: number): string {
    return SizeTypeEnum[val];
  }

  returnPrice(price: number, discount: number): any {
    var res = price - price * discount / 100;
    if (res % 1 != 0) {
      return res.toFixed(2);
    }
    else return res;
  }

  changeImage(index: number): void {
    this.currentImageIndex = index;
  }

  increaseQuantity(): void {
    if(this.totalItems == this.product.stock) {
      if(this.product.stock == 1){

        this.notifyService.showError(`Only ${this.product.stock} item is in stock.`, "Failed");
      }
      else{
        this.notifyService.showError(`Only ${this.product.stock} items are in stock.`, "Failed");
      }
    }
    else if(this.totalItems == 6){
      this.notifyService.showError(`You cannot add more than 6 quantities of this product.`, "Failed");
    }
    else{
      this.totalItems++;
    }
  }

  decreaseQuantity(): void {
    if(this.totalItems > 1) this.totalItems--;
  }

}
