using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab_13
{
    class KMSDiskInfo
    {        
        private string actionOneStr;
        private List<string> action = new List<string>();

        public string DriveFreeSpace()
        {
            var allDriveInfo = DriveInfo.GetDrives();

            foreach (var drive in allDriveInfo)
            {
                long totalFreeSpace = drive.TotalFreeSpace;
                actionOneStr = "Общий объём свободного места на диске в байтах: " + totalFreeSpace.ToString();
            }

            return actionOneStr;
        }

        public string FileSystem()
        {
            var allDriveInfo = DriveInfo.GetDrives();

            foreach (var drive in allDriveInfo)
            {

                string fileSystem = "Файловая система: " + drive.DriveFormat;
                actionOneStr = fileSystem;
            }

            return actionOneStr;
        }

        public List<string> DriveComboInfo()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                string driveName = "Имя диска: " + drive.Name;
                action.Add(driveName);
                long totalSize = drive.TotalSize;                
                long availableFreeSpace = drive.AvailableFreeSpace;               
                string label = "Метка: " + drive.VolumeLabel;               

                string totalSizeStr = "Размер диска в байтах: " + totalSize.ToString();
                action.Add(totalSizeStr);
                string availableFreeSpaceStr = "Объём доступного свободного места на диске в байтах: " + availableFreeSpace.ToString();
                action.Add(availableFreeSpaceStr); 

                action.Add(label);
            }

            return action;
        }


    }
}
