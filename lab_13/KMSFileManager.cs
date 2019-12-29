using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab_13
{
    class KMSFileManager
    {
        private List<string> actionList = new List<string>();

        public List<string> FilesDirsList(string diskName = @"D:\")
        {
            //DirectoryInfo dirInfo = new DirectoryInfo(dirName);

            string[] filesList = Directory.GetFiles(diskName);

            actionList.Add("Файлы на диске: ");
            foreach (var file in filesList)
            {
                actionList.Add(file);
            }

            string[] dirList = Directory.GetDirectories(diskName);

            actionList.Add("Папки на диске: ");
            foreach (var dir in dirList)
            {
                actionList.Add(dir);
            }
            return actionList;
        }

        public string CreateSpecialDir(string dirPath = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\KMSInspect")
        {
            DirectoryInfo newDir = new DirectoryInfo(dirPath);

            if (newDir.Exists)
            {
                newDir.Delete();
            }

            newDir.Create();

            return "Создана директория " + dirPath;
        }

        public string NewTxtFileInSpecDir(string dirPath = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\KMSInspect\KMSdirinfo.txt")
        {
            FileInfo newFile = new FileInfo(dirPath);

            if (newFile.Exists)
            {
                newFile.Delete();
            }

            newFile.Create();

            return "Создан файл " + dirPath;
        }
    }
}
