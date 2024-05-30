using System;
using System.IO;
using System.Text;

namespace Lab03App.Tools
{
    public class DirInfoLogger
    {
        private readonly StringBuilder _logBuilder;
        private readonly DirectoryInfo _systemDirectoryInfo;
        private readonly DirectoryInfo _tempDirectoryInfo;
        private readonly DirectoryInfo _currentDirectoryInfo;

        public DirInfoLogger()
        {
            _logBuilder = new StringBuilder();
            _systemDirectoryInfo = new DirectoryInfo(Environment.SystemDirectory);
            _tempDirectoryInfo = new DirectoryInfo(Path.GetTempPath());
            _currentDirectoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            LogDirectoryInformation();
        }

        private void LogDirectoryInformation()
        {
            LogDirectoryDetails("System directory", _systemDirectoryInfo);
            LogDirectoryDetails("Temporary directory", _tempDirectoryInfo);
            LogDirectoryDetails("Current directory", _currentDirectoryInfo);
        }

        private void LogDirectoryDetails(string title, DirectoryInfo directoryInfo)
        {
            _logBuilder.AppendLine($"\n{title}:");
            _logBuilder.AppendLine($"Name: {directoryInfo.Name}");
            _logBuilder.AppendLine($"Full name: {directoryInfo.FullName}");
            _logBuilder.AppendLine($"Creation time: {directoryInfo.CreationTime}");
            _logBuilder.AppendLine($"Root: {directoryInfo.Root}");
        }

        public void ClearLog()
        {
            _logBuilder.Clear();
        }

        public string GetLog()
        {
            return _logBuilder.ToString();
        }

        public override string ToString()
        {
            return _logBuilder.ToString();
        }
    }
}