using System;

namespace HeistPartII
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank b)
        {

            b.SecurityGaurdScore -= SkillLevel;

            Console.WriteLine($"{Name} is kicking the guard's butt! Decreased security by {SkillLevel} points!");

            if (b.SecurityGaurdScore <= 0)
            {
                Console.WriteLine($"{Name} has kicked the guard's butt!");
            }
        }
    }
}