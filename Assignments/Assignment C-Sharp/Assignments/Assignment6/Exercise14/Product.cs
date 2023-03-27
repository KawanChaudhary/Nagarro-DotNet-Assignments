using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment6.Exercise14
{
    class Product : IEquatable<Product>
    {
        public event EventHandler ChangeDefectiveness;
        public event EventHandler<PriceChangedEvent> ChangePrice;

        private int id;
        private int price;
        private bool isDefective;

        public bool Equals(Product other)
        {
            if (other == null)
            {
                return false;
            }
            if (this.id == other.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Product(int id, int price, bool isDefective)
        {
            this.id = id;
            this.price = price;
            this.isDefective = isDefective;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Price
        {
            get { return price; }
            set
            {
                PriceChangedEvent e = new PriceChangedEvent(value);
                price = value;
                ChangePrice(this, e);
            }
        }
        public bool IsDefective
        {
            get { return isDefective; }
            set
            {
                isDefective = value;
                ChangeDefectiveness(this, null);
            }
        }
    }
}
