using System;
using System.Collections.Generic;

namespace HeistPartII
{
    class Program
    {
        static void Main(string[] args)
        {



            Bank TargetBank = new Bank()
            {
                CashOnHand = new Random().Next(50000, 1000000),
                AlarmScore = new Random().Next(100),
                VaultScore = new Random().Next(100),
                SecurityGaurdScore = new Random().Next(100),
            };
            if (TargetBank.AlarmScore > TargetBank.VaultScore && TargetBank.AlarmScore > TargetBank.SecurityGaurdScore)
            {
                Console.WriteLine("Most Secure: Alarm");
            }
            if (TargetBank.VaultScore > TargetBank.AlarmScore && TargetBank.VaultScore > TargetBank.SecurityGaurdScore)
            {
                Console.WriteLine("Most Secure: Vault");
            }
            else
            {
                Console.WriteLine("Most Secure: Security Guards");
            }

            if (TargetBank.AlarmScore < TargetBank.VaultScore && TargetBank.AlarmScore < TargetBank.SecurityGaurdScore)
            {
                Console.WriteLine("Least Secure: Alarm");
            }
            if (TargetBank.VaultScore < TargetBank.AlarmScore && TargetBank.VaultScore < TargetBank.SecurityGaurdScore)
            {
                Console.WriteLine("Least Secure: Vault");
            }
            else
            {
                Console.WriteLine("Least Secure: Security Guards");
            }



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

            while (true)
            {
                Console.WriteLine($"Enter the name of your new crew member.");



                string crewName = Console.ReadLine();

                if (crewName == "")
                {
                    break;
                }

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
                while (crewCutPercentage < 1 || crewCutPercentage > 100)
                {
                    Console.WriteLine($"What is the percentage of {crewName}'s cut?");

                    crewCutPercentage = int.Parse(Console.ReadLine());
                }
                IRobber larry;

                if (specialtyChoice == "1")
                {
                    larry = new Muscle();

                }
                else if (specialtyChoice == "2")
                {
                    larry = new Hacker();

                }
                else
                {
                    larry = new LockSpecialist();
                }
                larry.Name = crewName;
                larry.SkillLevel = crewSkillLevel;
                larry.PercentageCut = crewCutPercentage;
                rolodex.Add(larry);

                Console.WriteLine($"You have {rolodex.Count} operatives.");
            }



            List<IRobber> crew = new List<IRobber>();

            while (true)
            {
                Console.WriteLine("Rolodex: ");

                for (int i = 0; i < rolodex.Count; i++)
                {
                    Console.WriteLine(i + ". " + rolodex[i].Name + " " + rolodex[i].GetType().Name + " Skill Level: " + rolodex[i].SkillLevel + " Percent Cut: " + rolodex[i].PercentageCut);
                }


                Console.WriteLine("Enter index of operative you would like to add to the heist: ");
                int crewSelection = int.Parse(Console.ReadLine());

                //the report should not include operatives that have already been added to the crew, or operatives that require a percentage cut that can't be offered.

                int totalPercentageCut = 0;
                foreach (IRobber theif in crew)
                {
                    totalPercentageCut += theif.PercentageCut;
                }
                try
                {

                    if ((totalPercentageCut + rolodex[crewSelection].PercentageCut) <= 100)
                    {
                        crew.Add(rolodex[crewSelection]);
                        rolodex.Remove(rolodex[crewSelection]);
                    }
                    else
                    {
                        Console.WriteLine($"{rolodex[crewSelection].Name} percentage cut is to high");
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Must be one of the listed opptions");
                }

            }


        }








    }
}
