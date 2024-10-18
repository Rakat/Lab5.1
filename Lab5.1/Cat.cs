using System;

public class Cat : Animal
{
    // Реалізація методу Golos
    public override void Golos()
    {
        Console.WriteLine("Мяу!");
    }

    // Реалізація методу Poroda
    public override string Poroda()
    {
        return "Британська короткошерста";
    }
}
