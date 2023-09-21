using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example2._2 
{

    //AbstractProduct
    abstract class AItems
    {
        //This is just to facilitate testing of our application.
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    // Conctrete Product
    class Car : AItems { }
    class CellPhone : AItems { }
    class Computer : AItems { }
    class LapTop : AItems { }
    class MotorBike : AItems { }
    class EntertainmentAllowance : AItems { }
    class TravelAllowance : AItems { }
    class Salary : AItems { }
    class Incentives : AItems { }

    //Abstract Creator
    abstract class AEmployee
    {
        List<AItems> benefits;

        public AEmployee()
        {
            benefits = new List<AItems>();
        }

        public void AddBenefit(AItems ben)
        {
            benefits.Add(ben);
        }

        public void PrintBenefits()
        {
            foreach(AItems benefit in benefits)
            {
                Console.WriteLine(benefit.ToString());
            }
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    //Concrete Creator
    class Manager : AEmployee
    {
        public Manager() {
            AddBenefit(new Car());
            AddBenefit(new CellPhone());
            AddBenefit(new LapTop());
            AddBenefit(new EntertainmentAllowance());
            AddBenefit(new TravelAllowance());
            AddBenefit(new Salary());
            AddBenefit(new Incentives());
        }
    }

    class Engineer : AEmployee
    {
        public Engineer()
        {
            AddBenefit(new Computer());
            AddBenefit(new MotorBike());
            AddBenefit(new TravelAllowance());
            AddBenefit(new Salary());
        }
    }

    class Program
    {
        static void Main()
        {
            AEmployee man = new Manager();
            Console.WriteLine("Имущество " + man.ToString() + ":");
            man.PrintBenefits();

            Console.ReadLine();

            man = new Engineer();
            Console.WriteLine("Имущество " + man.ToString() + ": \n");
            man.PrintBenefits();

            Console.ReadLine();
        }
    }

}