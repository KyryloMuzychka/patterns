abstract class ContinentFactory {
    public abstract Hishnik CreateHishnik();
    public abstract Travoyad CreateTravoyad();
}

class AfricaFactory : ContinentFactory {
    public override Hishnik CreateHishnik()
    {
        return new Lion();
    }
    public override Travoyad CreateTravoyad()
    {
        return new Zebra();
    }
}

class AmericaFactory : ContinentFactory {
    public override Hishnik CreateHishnik()
    {
        return new Wolf();
    }
    public override Travoyad CreateTravoyad()
    {
        return new Bizon();
    }
}


class AnimalWorld {
    private Hishnik _hishnik;
    private Travoyad _travoyad;
    public AnimalWorld(ContinentFactory factory) {
        _hishnik = factory.CreateHishnik();
        _travoyad = factory.CreateTravoyad();
    }
    public void RunFoodChain() {
        _hishnik.Eat(_travoyad);
    }
}

abstract class Travoyad {

}

class Zebra : Travoyad {

}

class Bizon : Travoyad {

}

abstract class Hishnik {
    public abstract void Eat(Travoyad travoyad);
}

class Lion : Hishnik {
    public override void Eat(Travoyad travoyad)
    {
        Console.WriteLine($"{this.GetType().Name} ate {travoyad.GetType().Name}");
    }
}

class Wolf : Hishnik {
    public override void Eat(Travoyad travoyad)
    {
        Console.WriteLine($"{this.GetType().Name} ate {travoyad.GetType().Name}");
    }
}

class Program {
    static void Main(string[] args) {
        ContinentFactory africaFactory = new AfricaFactory();
        AnimalWorld animalWorldOfAfrica = new AnimalWorld(africaFactory);
        animalWorldOfAfrica.RunFoodChain();
        
        ContinentFactory americaFactory = new AmericaFactory();
        AnimalWorld animalWorldOfAmerica = new AnimalWorld(americaFactory);
        animalWorldOfAmerica.RunFoodChain();
    }
}