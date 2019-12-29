using System;

namespace lab_13
{
    class Program
    {
        static void Main()
        {
            KMSLog log = new KMSLog();

            //KMSDiskInfo disk = new KMSDiskInfo();
            //log.WriteFile(disk.DriveFreeSpace());
            //log.WriteFile(disk.FileSystem());
            //log.WriteFile(disk.DriveComboInfo());

            //KMSDirInfo dir = new KMSDirInfo();
            //log.WriteFile(dir.FilesNum());
            //log.WriteFile(dir.CreationTime());
            //log.WriteFile(dir.DirNum());
            //log.WriteFile(dir.ParentDir());

            KMSFileInfo file = new KMSFileInfo();
            log.WriteFile(file.FullPath());
            log.WriteFile(file.CreationTime());
            log.WriteFile(file.FileComboInfo());
        }
    }
}
