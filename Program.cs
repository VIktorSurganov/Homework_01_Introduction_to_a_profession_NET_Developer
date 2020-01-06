using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ДОМАШНЕЕ ЗАДАНИЕ 1
            // Создание базы данных из 20 сотрудников
            Repository repository = new Repository(20);
            repository.Print("В этом отделе 20 сотрудников");

            //  ДОМАШНЕЕ ЗАДАНИЕ 2
            // Создание базы данных из 40 сотрудников
            Repository repository1 = new Repository(40);
            //Вывод сотрудников до увольнения
            repository1.Print("Вывод списка сотрудников до увольнения");
            //Создаю рандом переменную
            Random rand = new Random();
            //Цикл будет повторяться до тех пор, пока
            //количество сотрудников превышает 30
            while (repository1.Workers.Count > 30)
            {
                
               int i = rand.Next(10000, 80000);
                //увольняем сотрудников по самому гуманному критерию                
                repository1.DeleteWorkerBySalary(i);
                Console.WriteLine($"Увольняем всех, у кого зарплата больше {i}");
                repository1.Print("Итог увольнений");
            }
            //  ДОМАШНЕЕ ЗАДАНИЕ 3
            Repository repository2 = new Repository(50);
            repository2.DeleteWorkerBySalary(30000);
            repository2.Print("Здесь не осталось никого с зарплатой выше 30000");

            Console.ReadLine();
        }
    }
}
