using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment2.Exercise4
{
    enum EquipmentType
    {
        MobileType,
        ImmobileType,
    }
    public class OOPS_Exercise4
    {
        private void getBasicDetails(out string nameEquipment, out string descriptionEquipment)
        {
            Console.Write("\nName of Equipment: ");
            nameEquipment = Console.ReadLine();
            Console.Write("\nDescription of Equipment: ");
            descriptionEquipment = Console.ReadLine();            
        }
        public OOPS_Exercise4()
        {
            Console.Write("\n0 for Mobile Equipment" +
                "\n1 for Immobile Equipment" +
                "\n\nWhich type of equipment: ");
            int typeOfEquipment = Int32.Parse(Console.ReadLine());

            string nameEquipment = "", descriptionEquipment = "";

            if(typeOfEquipment == 0)
            {
                // Mobile Equipment
                getBasicDetails(out nameEquipment, out descriptionEquipment);
                Console.Write("\nEnter the no. of wheels: ");
                int wheelsOfEquipment = Int32.Parse(Console.ReadLine());
                Mobile newMobileEquipment = new Mobile(nameEquipment, descriptionEquipment, wheelsOfEquipment, EquipmentType.MobileType);
                newMobileEquipment.MoveBy();
                newMobileEquipment.PrintDetailsOfEquipment();
            }
            else if(typeOfEquipment == 1)
            {
                // Immobile Equipment
                getBasicDetails(out nameEquipment, out descriptionEquipment);
                Console.Write("\nEnter the weight: ");
                int weightOfEquipment = Int32.Parse(Console.ReadLine());
                Immobile newImmobileEquipment = new Immobile(nameEquipment, descriptionEquipment, weightOfEquipment, EquipmentType.ImmobileType);
                newImmobileEquipment.MoveBy();
                newImmobileEquipment.PrintDetailsOfEquipment();
            }
            else
            {
                Console.WriteLine("Invalid Equipment Type.");
            }
        }
    }
}
