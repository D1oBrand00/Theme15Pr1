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
            MyClass[] pupil = new MyClass[n];
            for (int i = 0; i < pupil.Length; i++)
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
                pupil[i] = new MyClass(surname,name, patronymic, gender, birthyear);

            }
           
            Console.ReadKey();
        }
    }
}
