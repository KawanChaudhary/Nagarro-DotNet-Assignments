using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment3.Exercise6
{
    enum EquipmentType
    {
        MobileType,
        ImmobileType,
    }
    public class OOPS_Exercise6
    {
        private void createEquipment(List<Equipment> equipments)
        {
            string nameEquipment, descriptionEquipment;

            Console.Write("\n0 for Mobile Equipment" +
                "\n1 for Immobile Equipment" +
                "\n\nWhich type of equipment: ");
            int typeOfEquipment = -1;

            if (!int.TryParse(Console.ReadLine(), out typeOfEquipment) || typeOfEquipment < 0 || typeOfEquipment > 1)
            {
                Console.WriteLine("\nSelect correct menu item.\n");
                createEquipment(equipments);
            }
            else
            {
                Console.Write("\nName of Equipment: ");
                nameEquipment = Console.ReadLine();
                Console.Write("\nDescription of Equipment: ");
                descriptionEquipment = Console.ReadLine();

                if(typeOfEquipment == 0)
                {
                    Console.Write("\nEnter the no. of wheels: ");
                    int wheelsOfEquipment = Int32.Parse(Console.ReadLine());
                    equipments.Add(new Mobile(nameEquipment, descriptionEquipment, wheelsOfEquipment, EquipmentType.MobileType));
                }
                else
                {
                    Console.Write("\nEnter the weight: ");
                    int weightOfEquipment = Int32.Parse(Console.ReadLine());
                    equipments.Add(new Immobile(nameEquipment, descriptionEquipment, weightOfEquipment, EquipmentType.ImmobileType));
                }

                Console.WriteLine("\nA new equipment has been added.\n");

            }
        }
        private void deleteEquipment(List<Equipment> equipments)
        {
            if (equipments.Count > 0)
            {
                listAllEquipment(equipments);
                int selectedMobileEquipment = -1;
                Console.Write("Select the equipment: ");
                if (!int.TryParse(Console.ReadLine(), out selectedMobileEquipment) || selectedMobileEquipment < 0 || selectedMobileEquipment > equipments.Count)
                {
                    Console.WriteLine("\nSelect correct equipment.\n");
                }
                else
                {
                    equipments.RemoveAt(selectedMobileEquipment - 1);
                    Console.WriteLine("\nThe equipment has been deleted.\n");
                }


            }
            else
            {
                Console.WriteLine("\nYou have not added equipments yet.\n");
            }
        }
        private void listAllEquipment(List<Equipment> equipments)
        {
            if (equipments.Count > 0)
            {
                Console.WriteLine("\n{0,-15}{1,-25}{2,-15}", "No", "Name", "Description");
                for (int i = 0; i < equipments.Count; i++)
                {
                    Console.WriteLine("{0,-15}{1,-25}{2,-15}", (i + 1), equipments[i].Name, equipments[i].Description);
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added equipments yet.");
            }
            Console.WriteLine();
        }
        private void listAllMobileEquipment(List<Equipment> equipments)
        {
            if (equipments.Count > 0)
            {
                Console.WriteLine("\n{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}{5,-15}", "No", "Type", "Name", "Description", "Cost", "Distance moved");
                for (int i = 0; i < equipments.Count; i++)
                {
                    if(equipments[i].Type == EquipmentType.MobileType)
                    {
                        Console.WriteLine("{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}{5,-15}", (i + 1), "Mobile", equipments[i].Name, equipments[i].Description,
                            equipments[i].MaintenanceCost, equipments[i].Distance);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added equipments yet.");
            }
            Console.WriteLine();
        }
        private void listAllImmobileEquipment(List<Equipment> equipments)
        {
            if (equipments.Count > 0)
            {
                Console.WriteLine("\n{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}{5,-15}", "No", "Type", "Name", "Description", "Cost", "Distance moved");
                for (int i = 0; i < equipments.Count; i++)
                {
                    if (equipments[i].Type == EquipmentType.ImmobileType)
                    {
                        Console.WriteLine("{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}{5,-15}", (i + 1), "Immobile", equipments[i].Name, equipments[i].Description,
                            equipments[i].MaintenanceCost, equipments[i].Distance);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added equipments yet.");
            }
            Console.WriteLine();
        }
        private void listAllEquipmentNotBeenMovedTillNow(List<Equipment> equipments)
        {
            if (equipments.Count > 0)
            {
                Console.WriteLine("\n{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}{5,-15}", "No", "Type", "Name", "Description", "Cost", "Distance moved");
                for (int i = 0; i < equipments.Count; i++)
                {
                    if (equipments[i].Distance == 0)
                    {
                        Console.WriteLine("{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}{5,-15}", (i + 1), equipments[i].Type, equipments[i].Name, equipments[i].Description,
                            equipments[i].MaintenanceCost, equipments[i].Distance);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added equipments yet.");
            }
            Console.WriteLine();
        }
        private void moveEquipment(List<Equipment> equipments)
        {
            if (equipments.Count > 0)
            {
                listAllEquipment(equipments);
                int selectedMobileEquipment = -1;
                Console.Write("Select the equipment: ");
                if (!int.TryParse(Console.ReadLine(), out selectedMobileEquipment) || selectedMobileEquipment < 0 || selectedMobileEquipment > equipments.Count)
                {
                    Console.WriteLine("\nSelect correct equipment.\n");
                }
                else
                {
                    equipments[selectedMobileEquipment - 1].MoveBy();
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added equipments yet.\n");
            }
        }

        public OOPS_Exercise6()
        {

            // Arrya of equipments

            List<Equipment> equipments = new List<Equipment>();

            int choice = -1;
            while (choice != 0  )
            {
                Console.WriteLine("\n1. Create an equipment – mobile and immobile");
                Console.WriteLine("2. Delete ans equipment");
                Console.WriteLine("3. Move any equipment");
                Console.WriteLine("4. List all equipment");
                Console.WriteLine("5. Show details");
                Console.WriteLine("6. List all mobile equipment");
                Console.WriteLine("7. List all Immobile equipment");
                Console.WriteLine("8. List all equipment that have not been moved till now");
                Console.WriteLine("9. Delete all equipment");
                Console.WriteLine("10. Delete all immobile equipment");
                Console.WriteLine("11. Delete all mobile equipment");
                Console.WriteLine("0. Exit");
                Console.Write("\nYour choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("\nSelect correct menu item.\n");
                }
                else
                {
                    switch (choice)
                    {
                        case 1://Create an equipment – mobile and immobile
                            createEquipment(equipments);
                            break;
                        case 2:
                            deleteEquipment(equipments);
                            break;
                        case 3:
                            moveEquipment(equipments);
                            break;
                        case 4:
                            listAllEquipment(equipments);
                            break;
                        case 5:
                            listAllEquipment(equipments);
                            // showdetails(equipments);
                            break;
                        case 6:
                            listAllMobileEquipment(equipments);
                            break;
                        case 7:
                            listAllImmobileEquipment(equipments);
                            break;
                        case 8:
                            listAllEquipmentNotBeenMovedTillNow(equipments);
                            break;
                        case 9:
                            //Delete all equipment
                            equipments.Clear();
                            Console.WriteLine("\nAll equipments have been deleted.\n");
                            break;
                        case 10:
                            equipments.RemoveAll(e => e is Immobile);
                            Console.WriteLine("\nAll Immobile equipments have been deleted.\n");
                            break;
                        case 11:
                            equipments.RemoveAll(e => e is Mobile);
                            Console.WriteLine("\nAll Mobile equipments have been deleted.\n");
                            break;
                        case 12:
                            //exit
                            break;
                        default:
                            Console.WriteLine("\nSelect correct menu item.\n");
                            break;
                    }
                }

            }
        }
    }
}
