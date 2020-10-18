using Module3_;
using System;

namespace Module3Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emma = new Employee ("Emma", "Watson", 3, 3);
            Console.WriteLine (("Имя: {O}, Фамилия: {1}, Стаж работы: {2}, Опыт работы: {3}, Процент бонусов: {4} ", 
                                 emma.firstName, emma.lastName, emma.experience, emma.skillLevel, emma.getBonusPercent());

            Employee alan = new Employee ("Alan", "Rickman", 10, 5);
            Console.WriteLine (("Имя: {O}, Фамилия: {1}, Стаж работы: {2}, Опыт работы: {3}, Процент бонусов: {4} ", 
                                 alan.firstName, alan.lastName, alan.experience, alan.skillLevel, alan.getBonusPercent());

            Employee fiona = new Employee ("Fiona", "Shaw", 7, 3);
            Console.WriteLine (("Имя: {O}, Фамилия: {1}, Стаж работы: {2}, Опыт работы: {3}, Процент бонусов: {4} ",
                                 fiona.firstName, fiona.lastName, fiona.experience, fiona.skillLevel, fiona.getBonusPercent());

            Employee daniel = new Employee ("Daniel", "Redcliff", 1, 1);
            Console.WriteLine (("Имя: {O}, Фамилия: {1}, Стаж работы: {2}, Опыт работы: {3}, Процент бонусов: {4} ",
                                 daniel.firstName, daniel.lastName, daniel.experience, daniel.skillLevel, daniel.getBonusPercent());

            Employee rupert = new Employee ("Rupert", "Grint", 2, 4);
            Console.WriteLine (("Имя: {O}, Фамилия: {1}, Стаж работы: {2}, Опыт работы: {3}, Процент бонусов: {4} ",
                                 rupert.firstName, rupert.lastName, rupert.experience, rupert.skillLevel, rupert.getBonusPercent());

        }
       
    }
}
