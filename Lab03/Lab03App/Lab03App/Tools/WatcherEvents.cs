using System;
using System.IO;

namespace Lab03App.Tools
{
    public static class WatcherEvents
    {
        private const string LogFilePath = @"P:\labs\log.txt";

        public static void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }

            string message = $"Was changed: {e.FullPath}";
            LogEvent(message);
            Console.WriteLine(message);
        }

        public static void OnCreated(object sender, FileSystemEventArgs e)
        {
            string message = $"Was created: {e.FullPath}";
            LogEvent(message);
            Console.WriteLine(message);
        }

        public static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            string message = $"Was deleted: {e.FullPath}";
            LogEvent(message);
            Console.WriteLine(message);
        }

        public static void OnRenamed(object sender, RenamedEventArgs e)
        {
            string message = $"Was renamed:\n\tOld: {e.OldFullPath}\n\tCurrent: {e.FullPath}";
            LogEvent(message);
            Console.WriteLine(message);
        }

        public static void OnError(object sender, ErrorEventArgs e) =>
            PrintException(e.GetException());

        private static void LogEvent(string message)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(LogFilePath))
                {
                    sw.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to log: {ex.Message}");
            }
        }

        private static void PrintException(Exception? ex)
        {
            if (ex != null)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine("Exception:");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
                PrintException(ex.InnerException);
            }
        }
    }
}