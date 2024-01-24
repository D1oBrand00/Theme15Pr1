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
                Console.Write("Ввелие фамилию школьника:");
                string surname = Console.ReadLine();
                Console.Write("Ввелие имя школьника:");
                string name = Console.ReadLine();
                Console.Write("Ввелие отчество школьника:");
                string patronymic = Console.ReadLine();
                Console.Write("Введите пол школьника:");
                string gender = Console.ReadLine();
                Console.Write("Введите год рождения школьника:");
                int birthyear = int.Parse(Console.ReadLine());
                students[i] = new Schoolboy(surname, name, patronymic, gender, birthyear);
                Console.WriteLine();

            }
            WriteLine("Мальчики: \n");
                foreach (var schoolboy in students)
                {
                    if (schoolboy.Gender == "м" || schoolboy.Gender == "М")
                    {
                        schoolboy.Print();
                    }
                }
                WriteLine("Девочки: \n");
                foreach (var schoolboy in students)
                {                    
                    if (schoolboy.Gender == "ж" || schoolboy.Gender == "Ж")
                    {
                        schoolboy.Print();
                    }
                }
            WriteLine($"Кол-во мальчиков - {Schoolboy.Countmale}\nКол-во девочек - {Countfemale}");
            

            Console.ReadKey();
        }
    }
}
