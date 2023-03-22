using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment3.Exercise6
 {
    abstract class AbstractEquipment
    {
        public abstract void PrintDetailsOfEquipment();
        public abstract void MoveBy();
        public abstract void MoveBy(int value);
    }

    class Equipment : AbstractEquipment
    {

        private string nameEquipment = "";
        private string descriptionEquipment = "";
        private int distanceMoved = 0;
        private int maintenanceCost = 0;
        private EquipmentType equipmentType;

        public Equipment(string nameEquipment, string descriptionEquipment,  EquipmentType equipmentType)
        {
            this.nameEquipment = nameEquipment;
            this.descriptionEquipment = descriptionEquipment;
            this.equipmentType = equipmentType;
        }        

        public override void MoveBy(int value)
        {
            Console.Write("\nDistance Covered: ");
            int dist = Int32.Parse(Console.ReadLine());

            this.distanceMoved += dist;
            this.maintenanceCost += (dist * value);
        }

        public override void MoveBy()
        {
            throw new NotImplementedException();
        }

        public override void PrintDetailsOfEquipment()
        {
            Console.WriteLine("\n\n---------------- Equipment Details ----------------");
            Console.WriteLine("\nEquipmen Type: " + this.equipmentType);
            Console.WriteLine("\nName of Equipment: " + this.nameEquipment);
            Console.WriteLine("\nDescription of Equipment: " + this.descriptionEquipment);
            Console.WriteLine("\nTotal Distance of Equipment: " + this.distanceMoved);
            Console.WriteLine("\nTotal Maintenance Cost of Equipment: " + this.maintenanceCost);
        }

        public string Name
        {
            get { return nameEquipment; }
            set { nameEquipment = value; }
        }
        public string Description
        {
            get { return descriptionEquipment; }
            set { descriptionEquipment = value; }
        }

        public int Distance
        {
            get { return distanceMoved;  }
            set { distanceMoved = value;  }
        }

        public int MaintenanceCost
        {
            get { return maintenanceCost; }
            set { maintenanceCost = value; }
        }

        public EquipmentType Type
        {
            get { return equipmentType;  }
            set { equipmentType = value; }
        }

    }
}
