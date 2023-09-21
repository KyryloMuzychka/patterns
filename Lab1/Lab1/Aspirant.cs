using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
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
}
