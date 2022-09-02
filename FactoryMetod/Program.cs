// See https://aka.ms/new-console-template for more information

Director director = new ConcreteSedan("Мерседес");
Cars car = director.Create();
Console.WriteLine("Доставлен один седан марки Мерседес");

director = new ConcreteUniversal("Тайота");
Cars car2 = director.Create();
Console.WriteLine("Доставлен один универсал марки Тайота");

director = new ConcreteTruk("Френч");
Cars car3 = director.Create();
Console.WriteLine("Доставлен один грузовик марки Френч");

abstract class Director
{
    public string Dostavka { get; set; }

    public Director(string n)
    {
        Dostavka = n;
    }
    // фабричный метод
    abstract public Cars Create();
}

class ConcreteSedan : Director
{
    public ConcreteSedan(string n) : base(n)
    {
        Console.WriteLine("Создаем седан");
    }

    public override Cars Create()
    {
        return new Sedan();
    }
}

class ConcreteTruk : Director
{
    public ConcreteTruk(string n) : base(n)
    {
        Console.WriteLine("Создаем грузовик");
    }

    public override Cars Create()
    {
        return new Truk();
    }
}

class ConcreteUniversal : Director
{
    public ConcreteUniversal(string n) : base(n)
    {
        Console.WriteLine("Создаем универсал");
    }

    public override Cars Create()
    {
        return new Universal(); 
    }
}

abstract class Cars
{
    public abstract Cars FactoryMethod();
}

class Sedan : Cars
{
    public Sedan()
    {
        Console.WriteLine("Создали седан");
    }

    public override Cars FactoryMethod()
    {
        return new Sedan();
    }
}

class Universal : Cars
{
    public Universal()
    {
        Console.WriteLine("Создали унмверсал");
    }

    public override Cars FactoryMethod()
    {
        return new Universal();
    }
}

class Truk: Cars
{
    public Truk()
    {
        Console.WriteLine("Создали грузовик");
    }

    public override Cars FactoryMethod()
    {
        return new Truk();
    }
}
