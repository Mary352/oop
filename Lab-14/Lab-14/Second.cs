//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.IO;
//using System.Text;
//using System.Threading.Tasks;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Json;
//using System.Text.Json;
//using System.Xml.Serialization;
//namespace Lab_14
//{
//    class Second
//    {
//        public static void Action() {
//            List<Car> Arr = new List<Car>();
//            Car car1 = new Car(1,"1");
//            Car car2 = new Car(2,"2");
//            Car car3 = new Car(3,"3");
//            Car car4 = new Car(4,"4");
//            Car car5 = new Car(5,"5");
//            Car car6 = new Car(6,"6");
//            Arr.Add(car1);
//            Arr.Add(car2);
//            Arr.Add(car3);
//            Arr.Add(car4);
//            Arr.Add(car5);
//            Arr.Add(car6);
//            string pathXML = @"D:\Labs\3_sem\OOP\Lab-14\Lab-14\xmlArr.xml";

//            XmlSerializer xSer = new XmlSerializer(Arr.GetType());
      
//            try
//            {
//                using (FileStream we = new FileStream(pathXML, FileMode.OpenOrCreate))
//                {
          
//                        xSer.Serialize(we, Arr);
//                }
//            }
//            catch (Exception error)
//            {
//                Console.WriteLine(error);
//            }

//            using (FileStream fs = new FileStream(pathXML, FileMode.OpenOrCreate))
//            {
//                List<Car> newpeople = (List<Car>)xSer.Deserialize(fs);

//                foreach (Car p in newpeople)
//                {
//                    Console.WriteLine(p.ToString());
//                }
//            }

//        }
//    }
//}
