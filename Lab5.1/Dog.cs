using System;

public class Dog : Animal
{
    // Реалізація методу Golos
    public override void Golos()
    {
        Console.WriteLine("Гав!");
    }

    // Реалізація методу Poroda
    public override string Poroda()
    {
        return "Німецька вівчарка";
    }
}
