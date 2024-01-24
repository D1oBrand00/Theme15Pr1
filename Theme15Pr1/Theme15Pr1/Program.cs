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
            int n = 3;
            Schoolboy[] students = new Schoolboy[n];
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("Введите фамилию: ");
                string surname = Console.ReadLine();
                Console.Write("Ввелие имя: ");
                string name = Console.ReadLine();
                Console.Write("Ввелие отчество: ");
                string patronymic = Console.ReadLine();
                Console.Write("Введите пол: ");
                string gender = Console.ReadLine();
                Console.Write("Введите год рождения: ");
                int birthyear = int.Parse(Console.ReadLine());
                students[i] = new Schoolboy(surname, name, patronymic, gender, birthyear);
                Console.WriteLine();

            }
            Console.WriteLine("Мальчики: \n");
            foreach (var schoolboy in students)
            {
                if (schoolboy.Gender == "м" || schoolboy.Gender == "М")
                {
                    schoolboy.Print();
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Девочки: \n");
            foreach (var schoolboy in students)
            {
                if (schoolboy.Gender == "ж" || schoolboy.Gender == "Ж")
                {
                    schoolboy.Print();
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Кол-во мальчиков - {Schoolboy.Countmale}\nКол-во девочек - {Schoolboy.Countfemale}");


            Console.ReadKey();
        }
    }
}
