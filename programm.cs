using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "Игорь";
        int age = 19;
        int programCount = 48;
        int money = 1000;
        int time = 30;
        bool truth = true;

        Console.WriteLine("Здравствуйте, меня зовут " + name + ".");
        Console.WriteLine("Мне " + age + " лет.");
        Console.WriteLine("Я хочу научиться делать игры, это моя " + programCount + " программа на языке C#.");
        Console.WriteLine("Когда я закончу обучение я хочу зарабатывать " + money + " денег в " + time + " наносекунд.");
        Console.WriteLine("Достигну ли я желаемого? " + truth + "!");
    }
}
