using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment3.Exercise6
 {
    abstract class Equipment
    {

        private string nameEquipment = "";
        private string descriptionEquipment = "";
        private int distanceMoved = 0;
        private int maintenanceCost = 0;
        private EquipmentType equipmentType;

        public abstract void PrintDetailsOfEquipment();
        public abstract void MoveBy();

        public Equipment(string nameEquipment, string descriptionEquipment,  EquipmentType equipmentType)
        {
            this.nameEquipment = nameEquipment;
            this.descriptionEquipment = descriptionEquipment;
            this.equipmentType = equipmentType;
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
