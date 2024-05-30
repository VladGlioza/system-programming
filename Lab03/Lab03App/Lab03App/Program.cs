using Lab03App.Tools;
using System;
using System.IO;

namespace Lab03App
{
    class Program
    {
        static void Main(string[] args)
        {
            string watchedFolder = @"P:";
            DirInfoLogger dirInfoLogger = new();

            Console.WriteLine("Logical disks:");

            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {
                var driveInfoLogger = new DriveInfoLogger(drive);
                Console.WriteLine("\n");
                Console.WriteLine(driveInfoLogger.GetLog());
            }

            Console.WriteLine(dirInfoLogger.GetLog());

            Console.WriteLine($"Monitoring folder: {watchedFolder}");

            using var watcher = new FileSystemWatcher(watchedFolder)
            {
                NotifyFilter = NotifyFilters.Attributes
                              | NotifyFilters.CreationTime
                              | NotifyFilters.DirectoryName
                              | NotifyFilters.FileName
                              | NotifyFilters.LastAccess
                              | NotifyFilters.LastWrite
                              | NotifyFilters.Security
                              | NotifyFilters.Size,
                IncludeSubdirectories = true,
                EnableRaisingEvents = true
            };

            watcher.Changed += WatcherEvents.OnChanged;
            watcher.Created += WatcherEvents.OnCreated;
            watcher.Deleted += WatcherEvents.OnDeleted;
            watcher.Renamed += WatcherEvents.OnRenamed;
            watcher.Error += WatcherEvents.OnError;

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}