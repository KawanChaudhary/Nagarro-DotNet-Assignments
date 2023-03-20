using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment3.Exercise6
{
    class Immobile : Equipment
    {
        public int weightOfEquipment = 0;
        public Immobile(string nameEquipment, string descriptionEquipment, int weightOfEquipment, EquipmentType equipmentType) :
            base(nameEquipment, descriptionEquipment, equipmentType)
        {

            this.weightOfEquipment = weightOfEquipment;
        }
        public override void MoveBy()
        {
            base.MoveBy(this.weightOfEquipment);
        }

        public override void PrintDetailsOfEquipment()
        {
            base.PrintDetailsOfEquipment();
            Console.WriteLine("\nWeight of Equipemnt: " + this.weightOfEquipment);
            Console.WriteLine("\n---------------------------------------------------");
        }

    }
}
