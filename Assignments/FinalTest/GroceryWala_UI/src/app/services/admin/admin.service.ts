import { Injectable } from '@angular/core';
import { ApiService } from '../api.service';

@Injectable({
  providedIn: 'root'
})
export class AdminService {

  constructor(private apiService: ApiService) { }

  addNewProduct(product: any){
    return this.apiService.post('admin/addnewproduct', product);
  }

  addProductImages(images: any){
    return this.apiService.post('admin/addproductimages', images);
  }

  getAllProducts(){
    return this.apiService.getAll('admin/allproducts');
  }
  
}
