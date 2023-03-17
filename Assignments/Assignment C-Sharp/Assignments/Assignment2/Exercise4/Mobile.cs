using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment2.Exercise4
{
    class Mobile : Equipment
    {
        private int wheelsOfEquipment = 0;
        public Mobile(string nameEquipment, string descriptionEquipment, int wheelsOfEquipment, EquipmentType equipmentType) :
            base(nameEquipment, descriptionEquipment, equipmentType)
        {

            this.wheelsOfEquipment = wheelsOfEquipment;
        }
        public override void MoveBy()
        {
            base.MoveBy(this.wheelsOfEquipment);
        }
        public override void PrintDetailsOfEquipment()
        {
            base.PrintDetailsOfEquipment();
            Console.WriteLine("\nNo. of Wheels of Equipemnt: " + this.wheelsOfEquipment);
            Console.WriteLine("\n---------------------------------------------------");
        }
    }
}
