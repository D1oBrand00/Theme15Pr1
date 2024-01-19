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
                Console.Write("Ввелие ФИО школьника:");
                string name = Console.ReadLine();
                Console.Write("Введите пол школьника:");
                string gender = Console.ReadLine();
                Console.Write("Введите год рождения школьника:");
                int birthyear = int.Parse(Console.ReadLine());
                pupil[i] = new MyClass(name, gender, birthyear);
            }
            Console.ReadKey();

        }
    }
}
