//using System;
//using System.Linq;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;
//using System.Text.Json;
//using System.Xml.Serialization;
//using System.Runtime.Serialization.Json;
//namespace Lab_14
//{
//    [Serializable]
//    public class Car : Vehicle
//    {
//        public int NumCar;
//        public string ModelCar;


//        public override void Drive()
//        {
//            Console.WriteLine($"{ModelCar} Машина едет");
//        }
//        public override string ToString()
//        {
//            return ($"Модель: {ModelCar} и номер машины: {NumCar}");
//        }
//        public Car(int x, string nam) : base(x, nam)
//        {
//            NumCar = x;
//            ModelCar = nam;
//        }

//        public Car()
//        {

//        }
//        public void Show()
//        {
//            Console.WriteLine($"Модель: {ModelCar} и номер машины: {NumCar}");
//        }

//    }
//    [Serializable]
//    public class Vehicle : Engine, ICarControl
//    {
//        public int Num;
//        public string model;

//        public Vehicle(int n, string m)
//        {
//            Num = n;
//            model = m;
//        }
//        public Vehicle()
//        {

//        }

//        public virtual void Drive()
//        {
//            Console.WriteLine("транспортное средтство едет");
//        }


//        public override bool DoClone()
//        {
//            return false;
//        }

//        bool ICarControl.DoClone()
//        {
//            return true;
//        }
//        public override string ToString()
//        {
//            Console.WriteLine($"Номер: {Num.ToString()} Модель: {model}");
//            return ($"Номер: {Num.ToString()} Модель: {model}");
//        }
//        public override int EngineNum
//        {
//            get;
//            set;
//        }
//        public override string EngineModel
//        {
//            get;
//            set;
//        }


//    }

//    interface ICarControl
//    {
//        void Drive();
//        bool DoClone();
//    }
//    [Serializable]
//    public abstract class Engine
//    {
//        public abstract int EngineNum { get; set; }
//        public abstract string EngineModel { get; set; }

//        public abstract bool DoClone();
//        public override string ToString()
//        {
//            return ($"Номер: {EngineNum} Модель: {EngineModel}");
//        }
//    }


//    class First
//    {
//      public static void Action()
//      {

//            string pathBin = @"D:\Labs\3_sem\OOP\Lab-14\Lab-14\points.dat";
//            string pathSOAP = @"D:\Labs\3_sem\OOP\Lab-14\Lab-14\SOAP.soap";
//            string pathJSON = @"D:\Labs\3_sem\OOP\Lab-14\Lab-14\json.json";
//            string pathXML = @"D:\Labs\3_sem\OOP\Lab-14\Lab-14\xml.xml";
//            Car Machine = new Car(220, "BMW");
//            BinaryFormatter formatterBIN = new BinaryFormatter();


//            //BINARY
//            try
//            {
//                // получаем поток, куда будем записывать сериализованный объект
//                using (FileStream fs = new FileStream(pathBin,
//                FileMode.OpenOrCreate))
//                {
//                    formatterBIN.Serialize(fs, Machine);
//                }

//            }
//            catch (Exception error)
//            {
//                Console.WriteLine(error);
//            }

//            //SOAP
//            SoapFormatter formatterSOAP = new SoapFormatter();
//            using (Stream fStream = new FileStream(pathSOAP,
//            FileMode.Create, FileAccess.Write, FileShare.None))
//            {
//                formatterSOAP.Serialize(fStream, Machine);
//            }

//            //XML
//            XmlSerializer xSer = new XmlSerializer(typeof(Car));

//            //try
//            //{
//            //    using (FileStream we = new FileStream(pathXML, FileMode.OpenOrCreate))
//            //    {
//            //        xSer.Serialize(we, Machine);
//            //    }
//            //}
//            //catch (Exception error)
//            //{
//            //    Console.WriteLine(error);
//            //}


//            using (FileStream fs = new FileStream(pathXML, FileMode.OpenOrCreate))
//            {
//                xSer.Serialize(fs, Machine);

//                Console.WriteLine("Объект сериализован");
//            }

//            // десериализация
//            using (FileStream fs = new FileStream(pathXML, FileMode.OpenOrCreate))
//            {
//                Car newPerson = (Car)xSer.Deserialize(fs);

//                Console.WriteLine("Объект десериализован");
//                Console.WriteLine(newPerson);

//            }

//            // JSON
//            //string json = JsonSerializer.Serialize(Machine);
//            //using (StreamWriter we = new StreamWriter(pathJSON, true, System.Text.Encoding.Default))
//            //{
//            //    we.WriteLine(json);
//            //}
//            DataContractJsonSerializer jsonFormatter =
//            new DataContractJsonSerializer(typeof(Car));
//            using (FileStream fs = new FileStream(pathJSON,
//            FileMode.OpenOrCreate))
//            {
//                jsonFormatter.WriteObject(fs, Machine);
//            }


//        }
//    }
//}