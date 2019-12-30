//using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;
//using System.Text.Json;
//using System.Xml.Serialization;
//using System.Text.Json.Serialization;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml;
//using System.Xml.Linq;
//using System;


//namespace Lab_14
//{
//    class Third
//    {
//        public static void Action() {
//            string path = @"D:\Labs\3_sem\OOP\Lab-14\Lab-14\xml.xml";
//            XmlDocument xDoc = new XmlDocument();
//            xDoc.Load(path);
//            XmlElement xRoot = xDoc.DocumentElement;

//            // выбор всех дочерних узлов
//            XmlNodeList childnodes = xRoot.SelectNodes("*");
//            foreach (XmlNode n in childnodes)
//            {
//                Console.WriteLine(n.OuterXml);
//            }

//            XmlNodeList childnodes1 = xRoot.SelectNodes("//Car/NumCar");
//            foreach (XmlNode n in childnodes1)
//                Console.WriteLine(n.InnerText);
//        }
//    }
//}
