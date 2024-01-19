using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme15Pr1
{
    /// <summary>
    /// Нестатический класс описывающий класс
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Поле Ф.И.О школьника
        /// </summary>
        string name;
        /// <summary>
        /// Поле пола школьника
        /// </summary>
        string gender;
        /// <summary>
        /// Поле года рождения школьника
        /// </summary>
        int birthyear;

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
        public MyClass(string name, string gender, int birthyear)
        {
            this.name = name;
            this.gender = gender;
            this.birthyear = birthyear;
        }
        public void Count(MyClass[]pupil)
        {
            int countmale = 0;
            int countfemale = 0;
            foreach (var p in pupil)
            {
                if(p.Gender == "м")
                {
                    countmale++;
                }    
                else if (p.Gender == "ж")
                {
                    countfemale++;
                }
            }
            
        }
    }
}
