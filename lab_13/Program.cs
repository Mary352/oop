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

            //KMSFileInfo file = new KMSFileInfo();
            //log.WriteFile(file.FullPath());
            //log.WriteFile(file.CreationTime());
            //log.WriteFile(file.FileComboInfo());

            KMSFileManager manager = new KMSFileManager();
            log.WriteFile(manager.CreateSpecialDir());      // создана папка KMSInspect
            log.WriteFile(manager.NewTxtFileInSpecDir());   // создан файл KMSdirinfo.txt
            log.WriteFile(manager.CopyNewFile());           // файл KMSdirinfo.txt скопирован
            log.WriteFile(manager.Rename());         // файл KMSdirinfo.txt удалён из KMSInspect
            log.WriteFile(manager.DeleteOldFile());         // файл KMSdirinfo.txt удалён из KMSInspect

        }
    }
}
