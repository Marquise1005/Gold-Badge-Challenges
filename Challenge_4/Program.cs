using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    class Program
    {
        static void Main(string[] args)
        {
            BadgeRepository badgeRepo = new BadgeRepository();
            Dictionary<int, List<string>> badgeDictionary = badgeRepo.GetDictionary();

            string response = null;
            while(response != "4")
            {
                Console.Clear();
                Console.WriteLine($"Hello Security Admin. What would you like to do?" +
                    $"\n1. Add a badge" +
                    $"\n2. Edit a badge" +
                    $"\n3. List all badges" +
                    $"\n4. Exit");
                response = Console.ReadLine();

                if (response == "1")
                {
                    Console.Clear();
                    List<string> doorList = new List<string>();
                    string doorResponse = "y";

                    Console.Write("What is the number on the badge: ");
                    int badgeNum = Int32.Parse(Console.ReadLine());
                    while (doorResponse != "n")
                    {
                        if (doorResponse == "y")
                        {
                            Console.Write("List a door that it needs access to: ");
                            string newDoor = Console.ReadLine();
                            doorList.Add(newDoor);
                            Console.Write("Are there any other doors? (y/n): ");
                            doorResponse = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                            Console.Write("Are there any other doors? (y/n): ");
                            doorResponse = Console.ReadLine();
                        }
                    }

                }
            }
        }
    }
}