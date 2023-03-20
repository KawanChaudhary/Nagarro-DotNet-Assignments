using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_Sharp.Assignments.Assignment3.Exercise7
{
    enum DuckType
    {
        RubberDuck,
        MallhardDuck,
        RedheadDuck
    }

    class OOPS_Exercise7
    {
        private void AddDuck(List<Duck> ducks)
        {
            Console.Write("\n0 for Rubber Duck" +
                "\n1 for Mallhard Duck" +
                "\n2 for Redhead Duck" +
                "\n\nWhich type of duck: ");

            int typeOfDuck = -1;

            if (!int.TryParse(Console.ReadLine(), out typeOfDuck) || typeOfDuck < 0 || typeOfDuck > 2)
            {
                Console.WriteLine("\nSelect correct menu item.\n");
                AddDuck(ducks);
            }
            else
            {
                double weightOfDuck;
                int wingsOfDuck;

                Console.Write("\nWeight of duck: ");
                if (!Double.TryParse(Console.ReadLine(), out weightOfDuck)){
                    Console.WriteLine("Use only numbers.");
                    AddDuck(ducks);
                }
                Console.Write("\nNo. of wings of duck: ");
                if (!Int32.TryParse(Console.ReadLine(), out wingsOfDuck)){
                    Console.WriteLine("Use only numbers.");
                    AddDuck(ducks);
                }

                if (typeOfDuck == 0)
                {
                    ducks.Add(new RubberDuck(weightOfDuck, wingsOfDuck, DuckType.RubberDuck));
                }
                else if (typeOfDuck == 1)
                {
                    ducks.Add(new MallhardDuck(weightOfDuck, wingsOfDuck, DuckType.MallhardDuck));
                }
                else
                {
                    ducks.Add(new RedheadDuck(weightOfDuck, wingsOfDuck, DuckType.RedheadDuck));
                }

                Console.WriteLine("\nA new duck details has been added.\n");
            }
        }
        private void DeleteDuck(List<Duck> ducks)
        {
            if (ducks.Count > 0)
            {
                ShowAllDucks(ducks);
                int selectedDuck = -1;
                Console.Write("Select the equipment: ");
                if (!int.TryParse(Console.ReadLine(), out selectedDuck) || selectedDuck < 0 || selectedDuck > ducks.Count)
                {
                    Console.WriteLine("\nSelect correct equipment.\n");
                }
                else
                {
                    ducks.RemoveAt(selectedDuck - 1);
                    Console.WriteLine("\nThe duck detials has been deleted.\n");
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added ducks yet.\n");
            }
        }
        private void ShowAllDucks(List<Duck> ducks)
        {
            if (ducks.Count > 0)
            {
                Console.WriteLine("\n{0,-15}{1,-25}{2,-15}{3,-15}", "No", "Type of Duck", "Weight", "Wings");
                for (int i = 0; i < ducks.Count; i++)
                {
                    Console.WriteLine("\n{0,-15}{1,-25}{2,-15}{3,-15}", (i + 1), ducks[i].Type, ducks[i].Weight, ducks[i].Wings);
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added ducks yet.");
            }
            Console.WriteLine();
        }

        private void DucksInIncreasingWeight(List<Duck> ducks)
        {
            if(ducks.Count > 0)
            {
                List<Duck> copyOfDuck = new List<Duck>();
                copyOfDuck.AddRange(ducks);

                copyOfDuck.Sort((x, y) => x.Weight.CompareTo(y.Weight));
                ShowAllDucks(copyOfDuck);

            }
            else
            {
                Console.WriteLine("\nYou have not added ducks yet.");
            }
            Console.WriteLine();
        }

        private void DucksInIncreasingNoOfWings(List<Duck> ducks)
        {
            if (ducks.Count > 0)
            {
                List<Duck> copyOfDuck = new List<Duck>();
                copyOfDuck.AddRange(ducks);

                copyOfDuck.Sort((x, y) => x.Wings.CompareTo(y.Wings));
                ShowAllDucks(copyOfDuck);

            }
            else
            {
                Console.WriteLine("\nYou have not added ducks yet.");
            }
            Console.WriteLine();
        }

        private void AnyDuckDetails(List<Duck> ducks)
        {
            if (ducks.Count > 0)
            {
                ShowAllDucks(ducks);
                int selectedDuck = -1;
                Console.Write("Select the duck: ");
                if (!int.TryParse(Console.ReadLine(), out selectedDuck) || selectedDuck < 0 || selectedDuck > ducks.Count)
                {
                    Console.WriteLine("\nSelect correct duck.\n");
                }
                else
                {
                    selectedDuck--;
                    ducks[selectedDuck].ShowDuckDetails();
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added ducks yet.\n");
            }
        }

        public OOPS_Exercise7()
        {
            List<Duck> ducks = new List<Duck>();
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("\n1. Add a duck");
                Console.WriteLine("2. Delete a duck");
                Console.WriteLine("3. Remove all ducks");
                Console.WriteLine("4. Show all ducks");
                Console.WriteLine("5. Ducks in increasing weight");
                Console.WriteLine("6. Ducks in increasing no. of wings");
                Console.WriteLine("7. Any duck details");
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
                        case 0:
                            //exit
                            break;
                        case 1:
                            AddDuck(ducks);
                            break;
                        case 2:
                            DeleteDuck(ducks);
                            break;
                        case 3:
                            ducks.Clear();
                            break;
                        case 4:
                            ShowAllDucks(ducks);
                            break;
                        case 5:
                            DucksInIncreasingWeight(ducks);
                            break;
                        case 6:
                            DucksInIncreasingNoOfWings(ducks);
                            break;
                        case 7:
                            AnyDuckDetails(ducks);
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
