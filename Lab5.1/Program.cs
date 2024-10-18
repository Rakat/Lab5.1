using System;

class Program
{
    static void Main(string[] args)
    {
        Animal myCat = new Cat();
        myCat.Name = "Мурка";
        myCat.Age = 2;

        Console.WriteLine($"Це {myCat.Name}, їй {myCat.Age} роки.");
        myCat.Golos();
        Console.WriteLine($"Порода: {myCat.Poroda()}");

        Animal myDog = new Dog();
        myDog.Name = "Рекс";
        myDog.Age = 4;

        Console.WriteLine($"Це {myDog.Name}, йому {myDog.Age} роки.");
        myDog.Golos();
        Console.WriteLine($"Порода: {myDog.Poroda()}");
    }
}
