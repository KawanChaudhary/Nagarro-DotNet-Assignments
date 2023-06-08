import { Injectable } from '@angular/core';
import { ApiService } from '../api.service';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {
  constructor(private apiService: ApiService) { }

  // addNewProduct(product: any){
  //   return this.apiService.post('home/addnewproduct', product);
  // }

  // addProductImages(images: any){
  //   return this.apiService.post('home/addproductimages', images);
  // }

  getProductByCategory(category: any){
    return this.apiService.getAll(`home/category/${category}`);
  }

  getProductById(productId: any){
    return this.apiService.getById(`home/product/${productId}`);
  }
}
