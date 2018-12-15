using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{

    class Program
    {
        private static DateTime CreateDate(string prompt)
        {
            Console.WriteLine(prompt);
            Console.Write("   Month (MM): ");
            string monthAsString = Console.ReadLine();
            int month = Int32.Parse(monthAsString);
            Console.Write("   Day (DD): ");
            string dayAsString = Console.ReadLine();
            int day = Int32.Parse(dayAsString);
            Console.Write("   Year (YYYY): ");
            string yearAsString = Console.ReadLine();
            int year = Int32.Parse(yearAsString);

            DateTime newDate = new DateTime(year, month, day);
            return newDate;
        }

        static void Main(string[] args)
        {
            ClaimRepository claimRepo = new ClaimRepository();
            Queue<Claim> claimQueue = claimRepo.GetClaims();

            string response = null;
            while (response != "4")
            {
                Console.Clear();
                Console.Write($"Which action would you like to take?" +
                    $"\n1. View all claims." +
                    $"\n2. Process next claim." +
                    $"\n3. Enter new claim." +
                    $"\n4. Exit." +
                    $"\n   ");
                response = Console.ReadLine();
                claimQueue = claimRepo.GetClaims();

                if (response == "1")
                {
                    Console.Clear();

                    Console.WriteLine($"ClaimID\t " +
                        $"Type\t" +
                        $"Description\t" +
                        $"Amount\t" +
                        $"DateOfAccident\t" +
                        $"DateOfClaim\t" +
                        $"IsValid");

                    foreach (Claim claim in claimQueue)
                    {
                        Console.WriteLine($" {claim.ClaimID}\t " +
                            $"{claim.ClaimType}\t" +
                            $"{claim.Description}\t\t" +
                            $"${claim.ClaimAmount}\t" +
                            $"{claim.DateOfIncident.ToShortDateString()}\t" +
                            $"{claim.DateOfClaim.ToShortDateString()}\t" +
                            $"{claim.IsValid}");
                    }
                }
               
                 
                
            }
        }
    }
}