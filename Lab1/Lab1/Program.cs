using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Xml.Linq;

namespace Lab1
{
    // абстрактный кдасс
    public abstract class Person
    {
        public string name;

        // перегрузка конструкторов
        public Person()
        {
            this.name = "имя";
        }

        public Person(string name)
        {
            this.name = name;
        }

        // свойства get/set
        public string getName()
        { 
            return this.name; 
        }

        public void setName(string name)
        { 
            this.name = name; 
        }

        // абстрактный метод
        public abstract void Print();

        // виртуальный метод
        public virtual void PrintFullName()
        { 
            Console.WriteLine("Name: " + this.name); 
        }
        
    }

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

    public class Aspirant : Student
    {
        // скрытие полей
        new protected int passbookNumber;

        // перегрузка конструкторов
        public Aspirant() : base()
        {
            this.passbookNumber = 0;
        }

        public Aspirant(string name, string surname, int passbookNumber, int educationalСourse)
            : base(name, surname, passbookNumber.ToString(), educationalСourse)
        {
            this.passbookNumber = passbookNumber;
        }

        // скрытие родительского метода
        new public int getPassbookNumber()
        {
            return this.passbookNumber;
        }

        // перегрузка метода
        public void setPassbookNumber(int passbookNumber)
        {
            this.passbookNumber = passbookNumber;
        }

        // переопределение родительского метода
        public override void Print()
        {
            string s = "Aspirant: name = {0}, surname = {1}, passbookNumber = {2}, educationalСourse = {3}";
            Console.WriteLine(String.Format(s, this.getName(), this.getSurname(), this.getPassbookNumber(), this.getEducationalCourse()));
        }

    }

    class Programm
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Student student = new Student("Андрей", "Ярмоленко", "er34", 3);   
            student.Print();

            Student st = new Student();
            st.Print();

            Aspirant aspirant = new Aspirant("Катя", "Малиновская", 4328, 2);
            aspirant.Print();

            Aspirant asp = new Aspirant();
            asp.Print();

            Person person = new Student();
            Person p = new Aspirant("Женя", "Коноплянка", 2312, 2);

            person.Print();
            p.Print();
          
            person.PrintFullName();
            student.PrintFullName();
            aspirant.PrintFullName();

            Console.ReadKey();
        }
    }
}