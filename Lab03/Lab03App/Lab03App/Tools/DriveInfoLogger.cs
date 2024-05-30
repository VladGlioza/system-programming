using System;
using System.IO;
using System.Text;

namespace Lab03App.Tools
{
    public class DriveInfoLogger
    {
        private readonly StringBuilder _logBuilder;

        public DriveInfoLogger(DriveInfo drive)
        {
            _logBuilder = new StringBuilder();
            LogDriveInformation(drive);
        }

        private void LogDriveInformation(DriveInfo drive)
        {
            _logBuilder.AppendLine($"Drive type: {drive.DriveType}");
            _logBuilder.AppendLine($"Volume label: {drive.VolumeLabel}");
            _logBuilder.AppendLine($"File system: {drive.DriveFormat}");
            _logBuilder.AppendLine($"Root directory: {drive.RootDirectory}");
            _logBuilder.AppendLine($"Available space to current user: {drive.AvailableFreeSpace / 1024 / 1024 / 1024} GB");
            _logBuilder.AppendLine($"Total available space: {drive.TotalFreeSpace / 1024 / 1024 / 1024} GB");
            _logBuilder.AppendLine($"Total size of drive: {drive.TotalSize / 1024 / 1024 / 1024} GB");
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