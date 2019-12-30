using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;


namespace lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //===========================бинарный===================================================================
            // объект для сериализации 
            Author a = new Author("Ann", "Smith", 23, "Unique life");

            // создаем объект 
            BinaryFormatter  formatterBin = new BinaryFormatter(); 

            // получаем поток, куда будем записывать сериализованный объект 
            using (FileStream fs = new FileStream("serial.dat", FileMode.OpenOrCreate)) 
            { 
                formatterBin.Serialize(fs, a); 
            }

            // десериализация 
            using (FileStream fs = new FileStream("serial.dat", FileMode.OpenOrCreate)) 
            {
                Author newA =(Author)formatterBin.Deserialize(fs);
                Console.WriteLine($"FirstName: {newA.FirstName}\nFirstName: {newA.LastName}\nAge:{newA.Age}");
                Console.WriteLine($"New book: {newA.BookTitle}");
            }

            //==================SOAP===================================================================================
            SoapFormatter soapFormatter = new SoapFormatter(); 
            using (Stream fStream = new FileStream("SoapData.dat", FileMode.Create, FileAccess.Write, FileShare.None)) 
            { 
                soapFormatter.Serialize(fStream, a); 
            }


        }

    }
}

