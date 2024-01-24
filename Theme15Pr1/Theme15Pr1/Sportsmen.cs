using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme15Pr1
{
    /// <summary>
    /// Нестатический класс, описывающий спортсменов
    /// </summary>
    class Sportsmen
    {
        /// <summary>
        /// Поле фамилии
        /// </summary>
        string surname;
        /// <summary>
        /// Поле имени
        /// </summary>
        string name;
        /// <summary>
        /// Поле отчества
        /// </summary>
        string patronymic;
        /// <summary>
        /// Поле роста
        /// </summary>
        int height;
        /// <summary>
        /// Поле веса
        /// </summary>
        int weight;
        /// <summary>
        /// Поле счётчика
        /// </summary>
        static int count;
        /// <summary>
        /// Свойства полей
        /// </summary>
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public int Height { get => height; set => height = value; }
        public int Weight { get => weight; set => weight = value; }
        public static int Count { get => count; set => count = value; }
        /// <summary>
        /// Статический конструктор, инициализирующий поле нулём
        /// </summary>
        static Sportsmen()
        {
            count = 0;
        }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Sportsmen() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="patronymic"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        public Sportsmen(string surname,string name, string patronymic, int height, int weight)
        {
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
            this.Height = height;
            this.Weight = weight;
            if (weight > 70) { count++; }
        }
        /// <summary>
        /// Метод вывода информации о спортсмене
        /// </summary>
        public void Output()
        {
            Console.WriteLine($"Фамилия - {Surname}\nИмя - {Name}\nОтчество - {patronymic}\nРост - {height}\nВес - {weight}");
        }
    }
}

