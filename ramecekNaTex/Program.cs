using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Napiš text:");
        string text = Console.ReadLine();

        int width = text.Length + 4;  // šířka rámečku (text + okraje)

        // horní hrana
        Console.WriteLine("+" + new string('-', width - 2) + "+");

        // řádek s textem (mezery + text + mezery)
        Console.WriteLine("|  " + text + "  |");

        // spodní hrana
        Console.WriteLine("+" + new string('-', width - 2) + "+");
    }
}