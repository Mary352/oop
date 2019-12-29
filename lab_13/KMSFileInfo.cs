using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab_13
{
    class KMSFileInfo
    {
        private string action;
        private List<string> actionList = new List<string>();
        
        public string FullPath(string filePath = @"D:\3 сем\ООП 3 сем\ЛР\lab_12\file.txt")
        {
            FileInfo fi = new FileInfo(filePath);
            action = "Полный путь к файлу " + filePath + ": " + fi.DirectoryName;

            return action;
        }

        public List<string> FileComboInfo(string filePath = @"D:\3 сем\ООП 3 сем\ЛР\lab_12\file.txt")
        {
            FileInfo fi = new FileInfo(filePath);
            actionList.Add("Размер файла " + filePath + ": " + fi.Length);
            actionList.Add("Расширение файла " + filePath + ": " + fi.Extension);
            actionList.Add("Имя файла " + filePath + ": " + fi.Name);

            return actionList;
        }

        public string CreationTime(string filePath = @"D:\3 сем\ООП 3 сем\ЛР\lab_12\file.txt")
        {
            FileInfo fi = new FileInfo(filePath);
            action = "Время создания файла " + filePath + ": " + fi.CreationTime;

            return action;
        }
    }
}
