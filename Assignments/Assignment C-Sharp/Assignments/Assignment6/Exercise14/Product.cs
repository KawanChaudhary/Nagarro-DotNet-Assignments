using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment6.Exercise14
{
    class Product : IEquatable<Product>
    {
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

        //Overridding - System.Object.Equals 
        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Product productObj))
            {
                return false;
            }
            else
            {
                return this.Equals(productObj);
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
            set { price = value; }
        }
        public bool IsDefective
        {
            get { return isDefective; }
            set { isDefective = value; }
        }
    }
}
