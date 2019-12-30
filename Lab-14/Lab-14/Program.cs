using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Xml.Serialization;

namespace Lab_14
{
    

    class Program
    {
        static void Main(string[] args)
        {
            //First.Action();
            //Second.Action();
            //Third.Action();
            //Fourth.Action();

            //===========================бинарный===================================================================
            // объект для сериализации 
            Author a = new Author("Ann", "Smith", 23, "Unique life");

            // создаем объект 
            BinaryFormatter formatterBin = new BinaryFormatter();

            // получаем поток, куда будем записывать сериализованный объект 
            using (FileStream fs = new FileStream("serial.dat", FileMode.OpenOrCreate))
            {
                formatterBin.Serialize(fs, a);
            }

            // десериализация 
            using (FileStream fs = new FileStream("serial.dat", FileMode.OpenOrCreate))
            {
                Author newA = (Author)formatterBin.Deserialize(fs);
                Console.WriteLine($"FirstName: {newA.FirstName}\nFirstName: {newA.LastName}\nAge:{newA.Age}");
                Console.WriteLine($"New book: {newA.BookTitle}");
            }

            //==================SOAP===================================================================================
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream fStream = new FileStream("SoapData.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormatter.Serialize(fStream, a);
            }

            //==================JSON===================================================================================
            Author a2 = new Author("Jack", "Fish", 46, "Magic of  sea");
            Author[] authors = new Author[] { a, a2 };

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Author[]));
            using (FileStream fs = new FileStream("authors.json", FileMode.OpenOrCreate)) 
            { 
                jsonFormatter.WriteObject(fs, authors); 
            }
            using (FileStream fs = new FileStream("authors.json", FileMode.OpenOrCreate))
            {
                Author[] newAuthors = (Author[])jsonFormatter.ReadObject(fs);
            }
        }
    }
}
