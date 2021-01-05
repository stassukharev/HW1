using Module3_;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Employee
{
    public class TestClass
    {
        [Test]
        public void CheckExperienceLessThan1()
        {

            Employee emma = new Employee("Emma", "Watson", 3, 3);
            Assert.IsFalse(emma.getBonusPercent() == 0);

            Employee alan = new Employee("Alan", "Rickman", 10, 5);
            Assert.IsFalse(alan.getBonusPercent() == 0);

            Employee fiona = new Employee("Fiona", "Shaw", 7, 3);
            Assert.IsFalse(fiona.getBonusPercent() == 0);

            Employee daniel  = new Employee("Daniel", "Redcliff", 1, 1);
            Assert.IsTrue(daniel.getBonusPercent() == 0);

            Employee rupert = new Employee("Rupert", "Grint", 2, 4);
            Assert.IsFalse(rupert.getBonusPercent() == 0);
        }
    
        [Test]
        public void CheckExperienceLessThan5()
        {

            Employee emma = new Employee("Emma", "Watson", 3, 3);
            Assert.IsTrue(emma.getBonusPercent() == 5);

            Employee alan = new Employee("Alan", "Rickman", 10, 5);
            Assert.IsFalse(alan.getBonusPercent() == 5);

            Employee fiona = new Employee("Fiona", "Shaw", 7, 3);
            Assert.IsFalse(fiona.getBonusPercent() == 5);

            Employee daniel = new Employee("Daniel", "Redcliff", 1, 1);
            Assert.IsFalse(daniel.getBonusPercent() == 5);

            Employee rupert = new Employee("Rupert", "Grint", 2, 4);
            Assert.IsTrue(rupert.getBonusPercent() == 5);

        }

        [Test]
        public void CheckExperienceMoreOrEqual5()
        {

            Employee emma = new Employee("Emma", "Watson", 3, 3);
            Assert.IsFalse(emma.getBonusPercent() == 10);

            Employee alan = new Employee("Alan", "Rickman", 10, 5);
            Assert.IsFalse(alan.getBonusPercent() == 10);

            Employee fiona = new Employee("Fiona", "Shaw", 7, 3);
            Assert.IsFalse(fiona.getBonusPercent() == 10);

            Employee daniel = new Employee("Daniel", "Redcliff", 1, 1);
            Assert.IsFalse(daniel.getBonusPercent() == 10);

            Employee rupert = new Employee("Rupert", "Grint", 2, 4);
            Assert.IsFalse(rupert.getBonusPercent() == 10);

        }

        [Test]
        public void CheckExperienceMoreThan5SkillEqual3()
        {

            Employee emma = new Employee("Emma", "Watson", 3, 3);
            Assert.IsFalse(emma.getBonusPercent() == 15);

            Employee alan = new Employee("Alan", "Rickman", 10, 5);
            Assert.IsFalse(alan.getBonusPercent() == 15);

            Employee fiona = new Employee("Fiona", "Shaw", 7, 3);
            Assert.IsTrue(fiona.getBonusPercent() == 15);

            Employee daniel = new Employee("Daniel", "Redcliff", 1, 1);
            Assert.IsFalse(daniel.getBonusPercent() == 15);

            Employee rupert = new Employee("Rupert", "Grint", 2, 4);
            Assert.IsFalse(rupert.getBonusPercent() == 15);

        }

        [Test]
        public void CheckExperienceMoreOrEqual5SkillEqual5()
        {

            Employee emma = new Employee("Emma", "Watson", 3, 3);
            Assert.IsFalse(emma.getBonusPercent() == 20);

            Employee alan = new Employee("Alan", "Rickman", 10, 5);
            Assert.IsTrue(alan.getBonusPercent() == 20);

            Employee fiona = new Employee("Fiona", "Shaw", 7, 3);
            Assert.IsFalse(fiona.getBonusPercent() == 20);

            Employee daniel = new Employee("Daniel", "Redcliff", 1, 1);
            Assert.IsFalse(daniel.getBonusPercent() == 20);

            Employee rupert = new Employee("Rupert", "Grint", 2, 4);
            Assert.IsFalse(rupert.getBonusPercent() == 20);

        }

        [Test]
        public void TestFailed()
        {

            Employee emma = new Employee("Emma", "Watson", 3, 3);
            Assert.IsTrue(emma.getBonusPercent() == 20);

            Employee alan = new Employee("Alan", "Rickman", 10, 5);
            Assert.IsTrue(alan.getBonusPercent() == 20);

            Employee fiona = new Employee("Fiona", "Shaw", 7, 3);
            Assert.IsFalse(fiona.getBonusPercent() == 20);

            Employee daniel = new Employee("Daniel", "Redcliff", 1, 1);
            Assert.IsFalse(daniel.getBonusPercent() == 20);

            Employee rupert = new Employee("Rupert", "Grint", 2, 4);
            Assert.IsFalse(rupert.getBonusPercent() == 20);

        }

    }

}