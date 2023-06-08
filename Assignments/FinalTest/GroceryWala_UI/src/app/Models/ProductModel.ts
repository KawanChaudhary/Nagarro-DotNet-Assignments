export class ProductModel {
    Id?:number;
    Name: string;
    Price: number;
    Description: string;
    Quantity: number;
    Category: number;
    Stock: number;
    Discount: number;
    SizeType: number;
    Rating?: number;
    TotalRatings?: number;
    OtherDetails?: string;
    ReviewCount?: number;
    
    constructor(Name: string, Price: number, Description: string, Quantity: number, 
      Category: number, Stock: number, Discount: number, SizeType: number, OtherDetails?: string, 
      Id?: number, Rating?: number, TotalRatings?: number, ReviewCount?: number) {
        
      this.Id = Id;
      this.Name = Name;
      this.Price = Price;
      this.Description = Description;
      this.Quantity = Quantity;
      this.Category = Category;
      this.Stock = Stock;
      this.Discount = Discount;
      this.SizeType = SizeType;
      this.OtherDetails = OtherDetails;
      this.Rating = Rating;
      this.TotalRatings = TotalRatings;
      this.ReviewCount = ReviewCount;
    }

  }
  