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
                newDir.Delete(true);
            }

            newDir.Create();

            return "Создана директория " + dirPath;
        }

        public string NewTxtFileInSpecDir(string filePath = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\KMSInspect\KMSdirinfo.txt")
        {
            string txt = "Hello!";

            // открываем файл (стираем содержимое файла) 
            FileStream fs = File.Open(filePath, FileMode.Create);

            StreamWriter sw = new StreamWriter(fs);

            // записываем текст в поток 
            sw.Write(txt);

            // закрываем поток 
            sw.Close();

            return "Создан файл " + filePath;
        }

        public string CopyNewFile(string filePath = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\KMSInspect\KMSdirinfo.txt")
        {
            string filePath2 = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\KMSdirinfo.txt";
            FileInfo fi = new FileInfo(filePath);
            FileInfo fi2 = new FileInfo(filePath2);
            if (fi.Exists)
            {
                if (fi2.Exists)
                {
                    fi2.Delete();
                }
                fi.CopyTo(filePath2, true);
            }

            return "Файл скопирован";
        }

        public string DeleteOldFile(string filePath = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\KMSInspect\KMSdirinfo.txt")
        {
            FileInfo fi = new FileInfo(filePath);
            
            if (fi.Exists)
            {
                fi.Delete();
            }

            return "Файл " + filePath + " удалён";
        }

        public string Rename(string filePath = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\KMSdirinfo.txt", string filePath2 = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\Newname.txt")
        {
            FileInfo fi = new FileInfo(filePath);
            FileInfo fi2 = new FileInfo(filePath2);

            if (fi.Exists && !fi2.Exists)
            {                
                fi.CopyTo(filePath2);
                fi.Delete();

                return "Файл " + filePath + " переименован";

            }
            else if (fi.Exists && fi2.Exists)
            {
                fi2.Delete();
                fi.CopyTo(filePath2);
                fi.Delete();

                return "Файл " + filePath + " переименован";
            }
            else
            {
                Console.WriteLine("Файл, который нужно переименовать, не существует");

                return null;

            }
        }

        public string CopySomeFiles()
        {

            return "Файлы скопированы";
        }
    }
}
