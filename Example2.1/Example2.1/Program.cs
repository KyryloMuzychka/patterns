using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example2._1 
{
    interface Employee
    {
        void Status();
        void Salary();
    }

//    abstract class Employee
//    {
//            public abstract void Status();
//            public abstract void Salary();
//    }

    class ManagerEmployee : Employee
    {
        public void Status()
        {
            Console.WriteLine("Manager");
        }

        public void Salary() 
        {
            Console.WriteLine("1500");
        }
    }

    class ProgrammerEmployee : Employee 
    {
        public void Status() 
        {
            Console.WriteLine("Programmer");
        }

        public void Salary()
        {
            Console.WriteLine("2000");
        }
    }

    abstract class Creator
    {
        public abstract Employee FactoryMethod();
    }

    class ManagerCreator : Creator
    {
        public override Employee FactoryMethod() 
        {
            return new ManagerEmployee();
        }
    }

    class ProgrammerCreator : Creator
    {
        public override Employee FactoryMethod()
        {
            return new ProgrammerEmployee();
        }
    }

    class Program
    {
        static void Main()
        {
            //Массив из объектов типа Creator
            Creator[] creators = new Creator[2];
            creators[0] = new ManagerCreator();
            creators[1] = new ProgrammerCreator();

            // Создаем продукты поочередно и вызываем
            // соответствующие методы
            foreach (Creator creator in creators)
            {
                Employee employee = creator.FactoryMethod();
                employee.Status();
                employee.Salary();
                Console.WriteLine("Created {0}", employee.GetType().Name);
            }

            // Ждем действий со стороны пользователя
            Console.Read();
        }
    }

}