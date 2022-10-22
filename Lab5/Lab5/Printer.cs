using System;

class Printer
{
    protected ConsoleColor color = Console.ForegroundColor;

    public void Print(string value)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(value);
    }
}

class Company : Printer
{
    public Company()
    {
        color = ConsoleColor.Blue;
    }
}

class Position : Printer
{
    public Position()
    {
        color = ConsoleColor.Yellow;
    }
}

class NamePerson : Printer
{
    public NamePerson()
    {
        color = ConsoleColor.Grey;
    }
}