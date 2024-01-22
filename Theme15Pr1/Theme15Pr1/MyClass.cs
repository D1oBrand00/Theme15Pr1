using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme15Pr1
{
    /// <summary>
    /// Нестатический класс, описывающий школьников
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Поле фамилии школьника
        /// </summary>
        static string surname;
        /// <summary>
        /// Поле имени школьника
        /// </summary>
        static string name;
        /// <summary>
        /// Поле отчества школьника
        /// </summary>
        static string patronymic;
        /// <summary>
        /// Поле пола школьника
        /// </summary>
        static string gender;
        /// <summary>
        /// Поле года рождения школьника
        /// </summary>
        static int birthyear;
        /// <summary>
        /// Счётчик кол-ва мальчиков
        /// </summary>
        static int countmale;
        /// <summary>
        /// Счётчик кол-ва девочек
        /// </summary>
        static int countfemale;

        /// <summary>
        /// Свойства полей
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = (value == "м" || value == "ж") ? value : "Такого пола нет"; }
        }
        public int Birthyear
        {
            get { return birthyear; }
            set { birthyear = value; }
        }

        public static int Countmale { get => countmale; set => countmale = value; }
        public static int Countfemale { get => countfemale; set => countfemale = value; }

        /// <summary>
        /// Статический конструктор, инициализирующий два поля нулями
        /// </summary>
        static MyClass()
        {
            countmale = 0;
            countfemale = 0;
        }
        public MyClass() { }
        /// <summary>
        /// Конструктор с параметрчми
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="patronymic"></param>
        /// <param name="gender"></param>
        /// <param name="birthyear"></param>
        public MyClass(string surname, string name, string patronymic, string gender, int birthyear)
        {
            this.surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
            this.Gender = gender;
            this.Birthyear = birthyear;
            if (gender == "м")
            {
                countmale++;
            }
            else if (gender == "ж")
            {
                countfemale++;
            }

        }
        /// <summary>
        /// Статический метод вывода 
        /// </summary>
         static public void Print()
        {
            Console.WriteLine($"Фамилия - {Surname} \nПол - {Gender}\nГод рождения - {birthyear}\nКол-во мальчиков - {countmale}\nКол-во девочк - {countfemale}");
        }
       
    }
}
