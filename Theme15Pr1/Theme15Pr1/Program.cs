using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme15Pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.Write("Кол-во школьников - ");
            //int n = int.Parse(Console.ReadLine());
            //Schoolboy[] students = new Schoolboy[n];
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.Write("Введите фамилию: ");
            //    string surname = Console.ReadLine();
            //    Console.Write("Ввелие имя: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Ввелие отчество: ");
            //    string patronymic = Console.ReadLine();
            //    Console.Write("Введите пол(м/ж): ");
            //    string gender = Console.ReadLine();
            //    Console.Write("Введите год рождения: ");
            //    int birthyear = int.Parse(Console.ReadLine());
            //    students[i] = new Schoolboy(surname, name, patronymic, gender, birthyear);
            //    Console.WriteLine();

            //}
            //Console.WriteLine("Мальчики: \n");
            //foreach (var schoolboy in students)
            //{
            //    if (schoolboy.Gender == "м" || schoolboy.Gender == "М")
            //    {
            //        schoolboy.Print();
            //        Console.WriteLine();
            //    }
            //}
            //Console.WriteLine("Девочки: \n");
            //foreach (var schoolboy in students)
            //{
            //    if (schoolboy.Gender == "ж" || schoolboy.Gender == "Ж")
            //    {
            //        schoolboy.Print();
            //        Console.WriteLine();
            //    }
            //}
            //Console.WriteLine($"Кол-во мальчиков - {Schoolboy.Countmale}\nКол-во девочек - {Schoolboy.Countfemale}");

            //2
            Console.Write("Кол-во спорстменов - ");
            int n = int.Parse(Console.ReadLine());
            Sportsmen[] sportsmens = new Sportsmen[n];
            for (int i = 0; i < sportsmens.Length; i++)
            {
                Console.Write("Введите фамилию: ");
                string surname = Console.ReadLine();
                Console.Write("Ввелие имя: ");
                string name = Console.ReadLine();
                Console.Write("Ввелие отчество: ");
                string patronymic = Console.ReadLine();
                Console.Write("Введите рост(в см): ");
                int weight = int.Parse(Console.ReadLine());
                Console.Write("Введите вес(в кг): ");
                int height = int.Parse(Console.ReadLine());
                sportsmens[i] = new Sportsmen(surname, name, patronymic, weight, height);
                Console.WriteLine();

            }
            Console.Write("Спортсмены, чей вес превышает 70 кг: \n");
            foreach (var sportmens in sportsmens)
            {
                if (sportmens.Weight > 70) 
                { sportmens.Output(); 
                  Console.WriteLine(); 
                }
            }
            Console.WriteLine($"Кол-во спортсменов, чей вес превышает 70 кг - {Sportsmen.Count}");


            Console.ReadKey();
        }
    }
}
