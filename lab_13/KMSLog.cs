using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab_13
{
    class KMSLog
    {
        private readonly DateTime dateOfCreation = DateTime.Now;

        public void WriteFile(string action, string filePath = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\KMSlogfile.txt", string fileName = "KMSlogfile.txt")
        {
            using StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default);
                                            //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
            sw.WriteLine("Имя файла: " + fileName);
            sw.WriteLine("Путь к файлу: " + filePath);
            sw.WriteLine("Дата создания: " + dateOfCreation);
            sw.WriteLine(action);
            sw.WriteLine();            
        }

        public void WriteFile(List<string> action, string filePath = @"D:\3 сем\ООП 3 сем\ЛР\lab_13\KMSlogfile.txt", string fileName = "KMSlogfile.txt")
        {
            using StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default);
                                                //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
            sw.WriteLine("Имя файла: " + fileName);
            sw.WriteLine("Путь к файлу: " + filePath);
            sw.WriteLine("Дата создания: " + dateOfCreation);
            foreach (var item in action)
            {
                sw.WriteLine(item);
            }
            sw.WriteLine();
        }


    }
}
