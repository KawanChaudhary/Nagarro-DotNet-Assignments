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
            Console.Write("\nDistance Covered: ");
            int dist = Int32.Parse(Console.ReadLine());

            this.Distance += dist;
            this.MaintenanceCost += (dist * this.weightOfEquipment);
        }

        public override void PrintDetailsOfEquipment()
        {
            Console.WriteLine("\n\n---------------- Equipment Details ----------------");
            Console.WriteLine("\nEquipmen Type: " + this.Type);
            Console.WriteLine("\nName of Equipment: " + this.Name);
            Console.WriteLine("\nDescription of Equipment: " + this.Description);
            Console.WriteLine("\nTotal Distance of Equipment: " + this.Distance);
            Console.WriteLine("\nTotal Maintenance Cost of Equipment: " + this.MaintenanceCost);
            Console.WriteLine("\nWeight of Equipemnt: " + this.weightOfEquipment);
            Console.WriteLine("\n---------------------------------------------------");
        }

    }
}
