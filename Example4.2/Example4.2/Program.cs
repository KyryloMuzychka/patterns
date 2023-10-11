
// клас target задает интерфейс для Уток
using System.Text;

public interface Ytka
{
    void qryak();
    void fly();
}

//target
public interface Petyx1
{
    public void kykarekat();
    public void fly();
}


// Конкретный подкласс реализующий интерфейс
public class Duck1 : Ytka
{
    public void qryak()
    {
        Console.WriteLine("Крякает");
    }
    public void fly()
    {
        Console.WriteLine("Утка летит");
    }
}


public class Petyx : Petyx1
{
    public void kykarekat()
    {
        Console.WriteLine("Кукарекает");
    }
    public void fly()
    {
        Console.WriteLine("Петух летить на малые дистанции");
    }
}

public class DuckAdapter : Petyx1
{
    public Duck1 duck = new Duck1();
    public void kykarekat()
    {
        duck.qryak();
    }
    public void fly()
    {
        duck.fly();
    }
}

//adapter
public class PetyxAdapter : Ytka //1
{
    Petyx petyx = new Petyx();

    public void qryak() //3
    {
        petyx.kykarekat();
    }

    public void fly()
    {
        for (int i = 0; i < 5; i++)
        {
            petyx.fly();
        }
    }
}

class Programm 
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Duck1 duck1 = new Duck1();
        Petyx petyx = new Petyx();
        Ytka petyxadapter = new PetyxAdapter();

        Console.WriteLine("Петух издает звук:");
        petyx.kykarekat();
        petyx.fly();

        Console.WriteLine("Утка издает звук:");
        duck1.qryak();
        duck1.fly();

        Console.WriteLine("Адаптер петуха издает звук:");
        petyxadapter.qryak();
        petyxadapter.fly();

        Console.WriteLine("---------------------");

        Petyx petyx2 = new Petyx();
        Duck1 duck = new Duck1();
        Petyx1 duckadapter = new DuckAdapter();

        Console.WriteLine("Петух издает звук:"); //4
        petyx2.kykarekat();
        petyx2.fly();

        Console.WriteLine("Утка издает звук:"); //5
        duck.qryak();
        duck.fly();

        Console.WriteLine("Адаптер утки издает звук:"); //6
        duckadapter.kykarekat();
        duckadapter.fly();

        Console.ReadKey();
    }
}