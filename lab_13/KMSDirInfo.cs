using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab_13
{
    class KMSDirInfo
    {
        private string action;

        public string FilesNum(string dirName = @"D:\3 сем\ООП 3 сем\ЛР")
        {
            int countFiles = 0;
            DirectoryInfo dirInfo = new DirectoryInfo(dirName);

            var filesList = dirInfo.GetFiles();
            foreach (var file in filesList)
            {
                countFiles++;
            }

            action = "Количестве файлов в " + dirName + ": " + countFiles;

            return action;
        }

        public string CreationTime(string dirName = @"D:\3 сем\ООП 3 сем\ЛР")
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dirName);

            action = "Время создания каталога " + dirName + ": " + dirInfo.CreationTime;
            return action;
        }

        public string DirNum(string dirName = @"D:\3 сем\ООП 3 сем\ЛР")
        {
            int countDirs = 0;

            DirectoryInfo dirInfo = new DirectoryInfo(dirName);

            var directoriesList = dirInfo.GetDirectories();
            foreach (var file in directoriesList)
            {
                countDirs++;
            }

            action = "Количестве поддиректорий в " + dirName + ": " + countDirs;

            return action;
        }

        public string ParentDir(string dirName = @"D:\3 сем\ООП 3 сем\ЛР")
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dirName);

            action = "Родительский каталог для " + dirName + ": " + dirInfo.Parent;
            return action;
        }
    }
}
