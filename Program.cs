using System;
using System.Collections.Generic;

namespace HeistPartII
{
    class Program
    {
        static void Main(string[] args)
        {


            List<IRobber> rolodex = new List<IRobber>()
           {
                new Hacker() {
                    Name = "Ben",
                    SkillLevel = 77,
                    PercentageCut = 22

                },

                new Muscle() {
                    Name = "JuJu",
                    SkillLevel = 30,
                    PercentageCut = 10
                },

                new LockSpecialist() {
                    Name = "Karen",
                    SkillLevel = 15,
                    PercentageCut = 4
                },

                new Muscle() {
                    Name = "Chad",
                    SkillLevel = 83,
                    PercentageCut = 35
                },

                new LockSpecialist() {
                    Name = "Stimpy",
                    SkillLevel = 70,
                    PercentageCut = 37
           }
        };

            Console.WriteLine($"You have {rolodex.Count} operatives.");
            Console.WriteLine($"Enter the name of your new crew member.");

            string crewName = Console.ReadLine();

            string specialtyChoice = "";
            while (specialtyChoice != "1" && specialtyChoice != "2" && specialtyChoice != "3")
            {

                Console.WriteLine(@"Choose a specialty: 

            1. Muscle
            2. Hacker
            3. Lock Specialist");

                specialtyChoice = Console.ReadLine();
            }


            int crewSkillLevel = 0;

            while (crewSkillLevel < 1 || crewSkillLevel > 100)
            {
                Console.WriteLine($"Please enter {crewName}'s skill level (1-100):");

                crewSkillLevel = int.Parse(Console.ReadLine());

            }

            int crewCutPercentage = 0;
            while (crewCutPercentage < 1 || crewCutPercentage > 100) ;
            {
                Console.WriteLine($"What is the percentage of {crewName}'s cut?");

                crewCutPercentage = int.Parse(Console.ReadLine());
            }


        }








    }
}
