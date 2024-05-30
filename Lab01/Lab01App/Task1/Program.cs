using System;
using System.IO;

class Program
{
    static void Main()
    {
        //get file path
        var basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
        var dataFilePath = Path.Combine(basePath, "data.dat");
        Console.WriteLine("Шлях до файлу: " + dataFilePath);

        var byteArray = new byte[25];
        var rng = new Random();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Генерація випадкових чисел:");
        Console.ResetColor();

        //arr gen
        for (int i = 0; i < byteArray.Length; i++)
        {
            byteArray[i] = (byte)rng.Next(1, 100);
            Console.Write($"{byteArray[i]} ");
        }

        Console.WriteLine();

        //write
        using (var fileStream = new FileStream(dataFilePath, FileMode.OpenOrCreate))
        {
            fileStream.Write(byteArray, 0, byteArray.Length);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Робота завершена");
            Console.ResetColor();
        }
    }
}