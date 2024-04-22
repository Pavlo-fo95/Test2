using System;

class Program
{ 
    static void Main()
    {

        Console.WriteLine("Введите ФИО: ");

        string fullName = Console.ReadLine();

        string[] names = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


        ConsoleColor[] colors = { ConsoleColor.DarkBlue, ConsoleColor.Cyan, ConsoleColor.Green };

        Console.WriteLine("\nФИО в разных цветах: ");

        for (int i = 0; i < names.Length; i++)
        {
            Console.ForegroundColor = colors[i% colors.Length];
    
            Console.WriteLine(names[i] + " ");
        }
        Console.ResetColor();
        Console.WriteLine();
    }
}