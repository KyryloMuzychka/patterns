using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// class Student, который содержит информацию о студенте
    /// (фамилия, курс обучения, номер зачетной книги).
    /// </summary>
    public class Student : Person
    {

        protected string surname, passbookNumber;
        protected int educationalСourse;

        // перегрузка конструкторов
        public Student() : base()
        {
            this.name = "имя";
            this.surname = "фамилия";
            this.passbookNumber = "номер зачетной книги";
            this.educationalСourse = 0;
        }

        public Student(string name, string surname, string passbookNumber, int educationalCourse)
        : base(name)
        {
            this.name = name;
            this.surname = surname;
            this.passbookNumber = passbookNumber;
            this.educationalСourse = educationalCourse;
        }

        // свойства get/set
        public string getSurname()
        {
            return this.surname;
        }

        public string getPassbookNumber()
        {
            return this.passbookNumber;
        }

        public int getEducationalCourse()
        {
            return this.educationalСourse;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void setPassbookNumber(string passbookNumber)
        {
            this.passbookNumber = passbookNumber;
        }

        public void setEducationalCourse(int educationalCourse)
        {
            this.educationalСourse = educationalCourse;
        }

        /// <summary>
        /// выводит информацию о содержимом полей класса
        /// </summary>
        public override void Print()
        {
            string s = "Student: name = {0}, surname = {1}, passbookNumber = {2}, educationalСourse = {3}";
            Console.WriteLine(String.Format(s, this.getName(), this.getSurname(), this.getPassbookNumber(), this.getEducationalCourse()));
        }

        // переопределение родительского метода
        public override void PrintFullName()
        {
            base.PrintFullName();
            Console.WriteLine("Surname: " + this.surname);
        }
    }
}
