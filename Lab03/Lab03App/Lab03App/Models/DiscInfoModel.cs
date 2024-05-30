using System;
using System.IO;

namespace Lab03App.Models
{
    public class DiskInfoModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string VolumeLabel { get; set; }
        public string FileSystem { get; set; }
        public string RootDirectory { get; set; }
        public string AvailableFreeSpaceGB { get; set; }
        public string TotalFreeSpaceGB { get; set; }
        public string TotalSizeGB { get; set; }

        public DiskInfoModel(DriveInfo drive)
        {
            Name = drive.Name;
            Type = drive.DriveType.ToString();
            VolumeLabel = drive.VolumeLabel;
            FileSystem = drive.DriveFormat;
            RootDirectory = drive.RootDirectory.ToString();
            AvailableFreeSpaceGB = (drive.AvailableFreeSpace / 1024 / 1024 / 1024).ToString();
            TotalFreeSpaceGB = (drive.TotalFreeSpace / 1024 / 1024 / 1024).ToString();
            TotalSizeGB = (drive.TotalSize / 1024 / 1024 / 1024).ToString();
        }

        public override string ToString()
        {
            return $@"Disk Type: {Type}
                    Volume Label: {VolumeLabel}
                    File System: {FileSystem}
                    Root Directory: {RootDirectory}
                    Available Space to Current User: {AvailableFreeSpaceGB} GB
                    Total Available Space: {TotalFreeSpaceGB} GB
                    Total Size of Drive: {TotalSizeGB} GB";
        }
    }
}