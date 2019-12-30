//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;
//namespace Lab_14
//{
//    public class Items{
//        public int age { get; set; }
//        public string name { get; set; }
//        public string location { get; set; }
//    }
//    class Fourth
//    {
//        public static void Action() {
//            string path = @"D:\Labs\3_sem\OOP\Lab-14\Lab-14\bookxml.xml";

//            XDocument xdoc = new XDocument();
//            XElement book = new XElement("book");
//            XAttribute bookNameAttr = new XAttribute("name", "CS");
//            XElement bookPriceElem = new XElement("price", "40000");
//            book.Add(bookNameAttr);
//            book.Add(bookPriceElem);
  


//            XElement book1 = new XElement("Author");
//            XAttribute bookNameAttr1 = new XAttribute("name", "Pavel");
//            XElement bookPriceElem1 = new XElement("price", "20000");
//            XElement bookPriceElem2 = new XElement("age", "19");
//            XElement bookPriceElem3 = new XElement("location", "by");

//            XElement book2 = new XElement("Author");
//            XAttribute bookNameAttr2 = new XAttribute("name", "Sveta");
//            XElement bookPriceElem4 = new XElement("price", "4000");
//            XElement bookPriceElem5 = new XElement("age", "19");
//            XElement bookPriceElem6 = new XElement("location", "ru");

//            XElement book3 = new XElement("Author");
//            XAttribute bookNameAttr23 = new XAttribute("name", "Andrey");
//            XElement bookPriceElem43 = new XElement("price", "4000");
//            XElement bookPriceElem53 = new XElement("age", "18");
//            XElement bookPriceElem63 = new XElement("location", "ru");

//            book1.Add(bookNameAttr1);
//            book1.Add(bookPriceElem1);
//            book1.Add(bookPriceElem2);
//            book1.Add(bookPriceElem3);

//            book2.Add(bookNameAttr2);
//            book2.Add(bookPriceElem4);
//            book2.Add(bookPriceElem5);
//            book2.Add(bookPriceElem6);


//            book3.Add(bookNameAttr23);
//            book3.Add(bookPriceElem43);
//            book3.Add(bookPriceElem53);
//            book3.Add(bookPriceElem63);

//            XElement books = new XElement("books");
//            books.Add(book);
//            books.Add(book1);
//            books.Add(book2);
//            books.Add(book3);
//            xdoc.Add(books);
//            xdoc.Save(path);


//            XDocument xdoc3 = XDocument.Load(path);

//            Console.WriteLine("Выборка по возрасту: ");
//            var result = from xe in xdoc3.Descendants("Author")
//                         where xe.Element("age").Value == "19"
//                         select new 
//                         {
//                             age = xe.Element("age").Value,
//                             name = xe.Attribute("name").Value,
//                             location = xe.Element("location").Value,
//                         };
//            foreach (var item in result) {
//                Console.WriteLine($"Name: {item.name}  Age: {item.age}   Location: {item.location}");
//            }
//            Console.WriteLine("Выборка по стране: ");
//            var result1 = from xe in xdoc3.Descendants("Author")
//                         where xe.Element("location").Value == "by"
//                         select new
//                         {
//                             age = xe.Element("age").Value,
//                             name = xe.Attribute("name").Value,
//                             location = xe.Element("location").Value,
//                         };
//            foreach (var item in result1)
//            {
//                Console.WriteLine($"Name: {item.name}  Age: {item.age}   Location: {item.location}");
//            }
//        }
//    }
//}
