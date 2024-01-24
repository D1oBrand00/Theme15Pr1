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
    class Schoolboy
    {
        /// <summary>
        /// Поле фамилии школьника
        /// </summary>
        string surname;
        /// <summary>
        /// Поле имени школьника
        /// </summary>
        string name;
        /// <summary>
        /// Поле отчества школьника
        /// </summary>
        string patronymic;
        /// <summary>
        /// Поле пола школьника
        /// </summary>
        string gender;
        /// <summary>
        /// Поле года рождения школьника
        /// </summary>
        int birthyear;
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
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = (value == "м" || value == "М"|| value == "ж"|| value == "Ж") ? value : "Такого пола нет"; }
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
        static Schoolboy()
        {
            countmale = 0;
            countfemale = 0;
        }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Schoolboy() { }
        /// <summary>
        /// Конструктор с параметрчми
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="patronymic"></param>
        /// <param name="gender"></param>
        /// <param name="birthyear"></param>
        public Schoolboy(string surname, string name, string patronymic, string gender, int birthyear)
        {
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
            this.Gender = gender;
            this.Birthyear = birthyear;
            if (gender == "м" || gender == "М")
            {
                countmale++;
            }
            else if (gender == "ж"|| gender == "Ж")
            {
                countfemale++;
            }

        }
        /// <summary>
        /// Статический метод вывода 
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Фамилия - {Surname}\nИмя - {Name}\nОтчество - {Patronymic}\nПол - {Gender}\nГод рождения - {birthyear}");
        }

    }




}
