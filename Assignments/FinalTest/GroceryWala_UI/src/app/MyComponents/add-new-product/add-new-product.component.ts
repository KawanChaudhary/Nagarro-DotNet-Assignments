import { Component, ElementRef, ViewChild } from '@angular/core';
import { faIndianRupeeSign, faPercentage, faPlus, faCubesStacked, faCirclePlus } from '@fortawesome/free-solid-svg-icons';
import { ProductModel } from 'src/app/Models/ProductModel';
import { AdminService } from 'src/app/services/admin/admin.service';
import { NotifyService } from 'src/app/services/notification/notify.service';


@Component({
  selector: 'app-add-new-product',
  templateUrl: './add-new-product.component.html',
  styleUrls: ['./add-new-product.component.css']
})
export class AddNewProductComponent {
  rupeeIcon = faIndianRupeeSign;
  percentageIcon = faPercentage;
  stockIcon = faCubesStacked;
  quantityIcon = faPlus;
  addIcon = faCirclePlus;

  productForm = {
    Name: '',
    Description: '',
    Price: null,
    Quantity: null,
    Category: null,
    Stock: null,
    Discount: null,
    SizeType: null,
    OtherDetails:'',
  }

  @ViewChild('inputFile') myInputVariable: ElementRef;

  selectedFile: any[];

  product: ProductModel;

  productId: any;

  // Other Specifications variables
  newKey: string;
  newValue: string;

  constructor(private adminService: AdminService, private notifyService: NotifyService) { }

  onFileSelected(event: any) {
    this.selectedFile = event.target.files;
  }

  onSubmit() {
    /// create new product

    this.product = this.productForm;

    //console.log(this.product);

    this.adminService.addNewProduct(this.product).subscribe(
      {
        next: (response: any) => {
          this.productId = response.id;
          // sending images to the database
          let imageData = new FormData();

          imageData.append("productID", this.productId);

          for (let file of this.selectedFile) {
            imageData.append('images', file, file.name);
          }

          this.adminService.addProductImages(imageData).subscribe(
            {
              next: (response: any) => {
              },
              error: (error: Error) => {
                console.log(error);
              }
            }
          );

          this.notifyService.showSuccess("Successfully added", this.product.Name)

          this.productForm = {
            Name: '',
            Description: '',
            Price: null,
            Quantity: null,
            Category: null,
            Stock: null,
            Discount: null,
            SizeType: null,
            OtherDetails:'',
          };
          this.myInputVariable.nativeElement.value = '';

        },
        error: (error: Error) => {
          console.log(error);
          this.notifyService.showError(`Error: ${error.message}`, "Failed");
        }
      }
    );
  }
}
