using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;


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

        public string CopySomeFiles(string filePath = @"D:\3 сем\ООП 3 сем\ЛР", string newFilePath = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\KMSFiles")
        {
            var dir = new DirectoryInfo(filePath);

            FileInfo[] fi = dir.GetFiles("*.pdf");

            foreach (FileInfo file in fi)
            {
                file.CopyTo(newFilePath + "\\" + file.Name);
            }

            return "Файлы скопированы";
        }

        public string MoveDir(string oldFilePath = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\KMSFiles", string newFilePath = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\KMSInspect\KMSFiles")
        {
            DirectoryInfo dir = new DirectoryInfo(oldFilePath);

            if (dir.Exists && !Directory.Exists(newFilePath))
            {
                dir.MoveTo(newFilePath);
            }
            else if (dir.Exists && Directory.Exists(newFilePath))
            {
                Directory.Delete(newFilePath);
                dir.MoveTo(newFilePath);
            }

            return "Папка " + oldFilePath + " перемещена в " + newFilePath;
        }

        public string Zip_unZip()
        {
            string startPath = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\KMSInspect\KMSFiles";
            string zipPath = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\KMSInspect\result.zip";
            string extractPath = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\extract";

            if (Directory.Exists(zipPath))
            {
                Directory.Delete(zipPath);
                ZipFile.CreateFromDirectory(startPath, zipPath);
            }
            else
            {
                ZipFile.CreateFromDirectory(startPath, zipPath);
            }

            if (Directory.Exists(extractPath))
            {
                Directory.Delete(extractPath, true);
                ZipFile.ExtractToDirectory(zipPath, extractPath);
            }
            else
            {
                ZipFile.ExtractToDirectory(zipPath, extractPath);
            }            

            return "Архив создан и разархивирован";
        }
    }
}
