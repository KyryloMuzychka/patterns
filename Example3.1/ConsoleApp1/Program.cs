abstract class CarFactory {
    public abstract AbstractCar CreateCar();
    public abstract AbstractEngine CreateEngine();
}

abstract class AbstractCar {
    public abstract void MaxSpeed(AbstractEngine engine);
}

abstract class AbstractEngine {
    public int max_speed;
}

class BMWFactory : CarFactory {
    public override AbstractCar CreateCar() {
        return new BMWCar();
    }
    public override AbstractEngine CreateEngine() {
        return new BMWEngine();
    }
}

class AudiFactory : CarFactory {
    public override AbstractCar CreateCar() {
        return new AudiCar();
    }
    public override AbstractEngine CreateEngine() {
        return new AudiEngine();
    }
}

class BMWCar : AbstractCar {
    public override void MaxSpeed(AbstractEngine engine)
    {
        Console.WriteLine($"max speed {engine.max_speed.ToString()}");
    }
}

class AudiCar : AbstractCar {
    public override void MaxSpeed(AbstractEngine engine)
    {
        Console.WriteLine($"MAX SPEED {engine.max_speed.ToString()}");
    }
}

class AudiEngine : AbstractEngine {
    public AudiEngine() {
        max_speed = 180;
    }
}

class BMWEngine : AbstractEngine {
    public BMWEngine() {
        max_speed = 200;
    }
}

class Client {
    private AbstractCar abstractCar;
    private AbstractEngine abstractEngine;
    public Client(CarFactory car_factory) {
        abstractCar = car_factory.CreateCar();
        abstractEngine = car_factory.CreateEngine();
    }
    public void Run() {
        abstractCar.MaxSpeed(abstractEngine);
    }
}

class Program {
    static void Main(string[] args) {
        CarFactory bmw_car = new BMWFactory();
        Client c1 = new Client(bmw_car);
        c1.Run();

        CarFactory audi_car = new AudiFactory();
        Client c2 = new Client(audi_car);
        c2.Run();

        Console.Read();
    }
}