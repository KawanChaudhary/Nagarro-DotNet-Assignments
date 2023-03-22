using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment3.Exercise6
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
            Console.Write("\nDistance Covered: ");
            int dist = Int32.Parse(Console.ReadLine());

            this.Distance += dist;
            this.MaintenanceCost += (dist * this.wheelsOfEquipment);

        }
        public override void PrintDetailsOfEquipment()
        {
            Console.WriteLine("\n\n---------------- Equipment Details ----------------");
            Console.WriteLine("\nEquipmen Type: " + this.Type);
            Console.WriteLine("\nName of Equipment: " + this.Name);
            Console.WriteLine("\nDescription of Equipment: " + this.Description);
            Console.WriteLine("\nTotal Distance of Equipment: " + this.Distance);
            Console.WriteLine("\nTotal Maintenance Cost of Equipment: " + this.MaintenanceCost);
            Console.WriteLine("\nNo. of Wheels of Equipemnt: " + this.wheelsOfEquipment);
            Console.WriteLine("\n---------------------------------------------------");
        }
    }
}
