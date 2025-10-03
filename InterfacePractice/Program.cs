// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Bidoof doofy = new Bidoof();
Shuckle shuck = new Shuckle();

doofy.Call();
shuck.Call();

doofy.TypeOne();
doofy.TypeTwo();

shuck.TypeOne();
shuck.TypeTwo();

interface IPokemon
{
    void Call();
    void TypeOne();
    void TypeTwo();
}

class Bidoof : IPokemon
{
    public void TypeOne()
    {
        Console.WriteLine("Type 1: Normal");
    }

    public void TypeTwo()
    {
        Console.WriteLine("Type 2: None");
    }

    public void Call()
    {
        Console.WriteLine("BOOF!!!");
    }
}

class Shuckle : IPokemon
{
    public void Call()
    {
        Console.WriteLine("Shuck!");
    }

    public void TypeOne()
    {
        Console.WriteLine("Type 1: Rock");
    }

    public void TypeTwo()
    {
        Console.WriteLine("Type 2: Bug");
    }
}
