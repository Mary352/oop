using System;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace Lab_14
{
    

    class Program
    {
        static void Main(string[] args)
        {
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

            //==================JSON===================================================================================

            DataContractJsonSerializer jsonFormatter2 = new DataContractJsonSerializer(typeof(Author));
            using (FileStream fs2 = new FileStream("autho.json", FileMode.OpenOrCreate))
            {
                jsonFormatter2.WriteObject(fs2, a2);
            }
            using (FileStream fs2 = new FileStream("autho.json", FileMode.OpenOrCreate))
            {
                Author newAuthor = (Author)jsonFormatter2.ReadObject(fs2);
                Console.WriteLine(newAuthor.ToString());
            }

            //==================XML====================================================================================
            // передаем в конструктор тип класса Author=Point dot = a
            XmlSerializer xSer = new XmlSerializer(typeof(Author));

            // получаем поток, куда будем записывать сериализованный объект 
            using (FileStream fs = new FileStream("author.xml", FileMode.OpenOrCreate)) 
            { 
                xSer.Serialize(fs, a); 
            }

            // десериализация 
            using (FileStream fs = new FileStream("author.xml", FileMode.OpenOrCreate))
            {
                Author newP = xSer.Deserialize(fs) as Author; 
                Console.WriteLine(newP.ToString());
            }

            //==================XML====================================================================================
            // передаем в конструктор тип класса Author=Point dot = a
            XmlSerializer xSer2 = new XmlSerializer(typeof(Author[]));

            // получаем поток, куда будем записывать сериализованный объект 
            using (FileStream fs8 = new FileStream("authorss.xml", FileMode.OpenOrCreate))
            {
                xSer2.Serialize(fs8, authors);
            }

            // десериализация 
            using (FileStream fs8 = new FileStream("authorss.xml", FileMode.OpenOrCreate))
            {
                Author[] newAuths = xSer2.Deserialize(fs8) as Author[];
                foreach (var item in newAuths)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            //==================XPath====================================================================================

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("authorss.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            XmlNodeList childnodes = xRoot.SelectNodes("*");
            foreach (XmlNode n in childnodes)
            {
                Console.WriteLine(n.OuterXml);
            }

            XmlNode childnode2 = xRoot.SelectSingleNode("Author[Age='23']");
            if (childnode2 != null)
            {
                Console.WriteLine();
                Console.WriteLine(childnode2.OuterXml);
            }

            //==================Linq to XML================================================================================
            // создаём док. .xml
            XDocument xdoc = new XDocument(new XElement("Hogwarts",
               new XElement("student",
                   new XAttribute("name", "Bill Weasley"),
                   new XElement("house", "Gryffindor"),
                   new XElement("year", "7")),
               new XElement("student",
                   new XAttribute("name", "Charlie Weasley"),
                   new XElement("house", "Gryffindor"),
                   new XElement("year", "5")),
               new XElement("student",
                   new XAttribute("name", "Penny Haywood"),
                   new XElement("house", "Hufflepuff"),
                   new XElement("year", "5")),
               new XElement("student",
                   new XAttribute("name", "Cedric Diggory"),
                   new XElement("house", "Hufflepuff"),
                   new XElement("year", "1")),
               new XElement("student",
                   new XAttribute("name", "Liz Tuttle"),
                   new XElement("house", "Slytherin"),
                   new XElement("year", "5")),
               new XElement("student",
                   new XAttribute("name", "Barnaby Lee"),
                   new XElement("house", "Slytherin"),
                   new XElement("year", "2")),
               new XElement("student",
                   new XAttribute("name", "Talbott Winger"),
                   new XElement("house", "Ravenclaw"),
                   new XElement("year", "5")),
                new XElement("student",
                   new XAttribute("name", "Tulip Karasu"),
                   new XElement("house", "Ravenclaw"),
                   new XElement("year", "4"))));
            xdoc.Save("Hogwarts.xml");

            // запросы к созданному .xml
            XDocument xdoc2 = XDocument.Load("Hogwarts.xml");
            var items = from xe in xdoc2.Descendants("student")
                        where xe.Element("year").Value == "5"
                        select new
                        {
                            Name = xe.Attribute("name").Value,
                            House = xe.Element("house").Value
                        };

            Console.WriteLine();
            foreach (var item in items)
                Console.WriteLine($"{item.Name} - {item.House}");
        }
    }
}
