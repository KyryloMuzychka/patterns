class FarenheitSensor 
{
    public double getFarenheitTemp() 
    {
        Console.WriteLine("Enter the temperature: ");
        string s; double t;
        s = Console.ReadLine();
        t = Convert.ToDouble(s);
        return t;
    }
}

abstract class Sensor
{
    abstract public double getTemperature();
}

class Adapter : Sensor
{
    FarenheitSensor p_sensor = new FarenheitSensor();
    public override double getTemperature()
    {
        return (p_sensor.getFarenheitTemp() * 5 / 9);
    }
}

class Programm
{
    static void Main()
    {
        Sensor p = new Adapter();
        Console.WriteLine("celsiy= {0}", p.getTemperature());
        Console.ReadKey();
    }
}