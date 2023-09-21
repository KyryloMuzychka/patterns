using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Xml.Linq;

namespace Lab1
{         
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