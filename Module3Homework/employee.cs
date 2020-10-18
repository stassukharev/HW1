using System;
namespace Module3_
{
    public class Employee
    {
        public int experience;
        public int skillLevel;
        public string firstName;
        public string lastName;

        public Employee(int experience, int skillLevel, string firstName, string lastName)
        {
            this.experience = experience;
            this.skillLevel = skillLevel;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public int getBonusPercent() {
            
            if (experience < 1) return 0;
            if ((experience < 5) && (experience > 1)) return 5;
            if ((experience => 5) && (skillLevel <3)) return 10;
            if ((experience > 5) && (skillLevel => 3) && (skillLevel <= 4)) return 15;
            if ((experience > 5) && (skillLevel == 5)) return 20;

        }
    }
}
