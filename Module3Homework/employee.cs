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
    }
}
