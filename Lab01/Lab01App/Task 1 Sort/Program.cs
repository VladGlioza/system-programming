using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Threading;

class Program
{
    static void Main()
    {
        bool isError = false;

        //get file path
        var filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "data.dat");

        //wait for Enter
        Console.WriteLine("Натисніть Enter, щоб почати");
        while (true)
        {
            if (Console.ReadKey().Key == ConsoleKey.Enter)
                break;
        }
        using (var mmf = MemoryMappedFile.CreateFromFile(filePath, FileMode.Open, "mappedFile"))
        {
            using (var accessor = mmf.CreateViewAccessor(0, 25))
                using (Mutex mutex = new Mutex())
                {
                do
                {
                    try
                    {
                        var isSorted = false;
                        do
                        {
                            isSorted = false;
                            for (int i = 0; i < 24; i++)
                            {
                                mutex.WaitOne();
                                byte currentByte, nextByte;
                                accessor.Read(i, out currentByte);
                                accessor.Read(i + 1, out nextByte);

                                if (currentByte > nextByte)
                                {
                                    accessor.Write(i, nextByte);
                                    accessor.Write(i + 1, currentByte);
                                    isSorted = true;
                                }
                            }
                            //pause between iterations
                            Thread.Sleep(1500);
                            Console.WriteLine("Пауза між ітераціями..");
                            mutex.ReleaseMutex();
                        } while (!isSorted);
                    }
                    catch (Exception e)
                    {
                        isError = true;
                    }
                    } while (isError);
                }
        }
    }
}