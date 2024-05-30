using System;
using System.IO;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace Lab03App.Tools
{
    public class DirWatcher
    {
        private readonly DriveInfoLogger _driveInfoLogger;
        private readonly DirInfoLogger _dirInfoLogger;
        private readonly CancellationTokenSource _cancellationTokenSource;
        private const string LogFilePath = @"P:\labs\log.txt";

        public DirWatcher(DriveInfoLogger driveLogger, DirInfoLogger dirLogger)
        {
            _driveInfoLogger = driveLogger;
            _dirInfoLogger = dirLogger;
            _cancellationTokenSource = new CancellationTokenSource();
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public void MonitorDirAndFile(string path)
        {
            Task.Run(() => StartMonitoring(path, _cancellationTokenSource.Token));
        }

        private void StartMonitoring(string path, CancellationToken cancellationToken)
        {
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = path;
                watcher.NotifyFilter = NotifyFilters.LastAccess
                                       | NotifyFilters.LastWrite
                                       | NotifyFilters.FileName
                                       | NotifyFilters.DirectoryName;
                watcher.Filter = "";
                watcher.Changed += OnChanged;
                watcher.EnableRaisingEvents = true;

                try
                {
                    while (!cancellationToken.IsCancellationRequested)
                    {
                        Thread.Sleep(1000);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(LogFilePath))
                {
                    sw.WriteLine($"File: {e.FullPath} {e.ChangeType}");
                }

                ShowDisksInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to log: {ex.Message}");
            }
        }

        public void Close()
        {
            _cancellationTokenSource.Cancel();
        }

        public void ShowDisksInfo()
        {
            _driveInfoLogger.ClearLog();
            _dirInfoLogger.ClearLog();

            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {
                var driveLogger = new DriveInfoLogger(drive);
                string logData = driveLogger.GetLog();
                Console.WriteLine("\n");
                Console.WriteLine(logData);
            }

            Console.WriteLine(_dirInfoLogger.GetLog());
        }
    }
}