using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    // абстрактный класс
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
}
