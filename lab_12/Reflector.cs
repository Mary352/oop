using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;

namespace lab_12
{
    class Reflector<U>
    {
        public void WriteFile<T>()
        {
            string filePath = @"D:\3 сем\ООП 3 сем\ЛР\lab_12\file.txt";
            
            Type t = typeof(T);

            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.Default))
            {
                foreach (FieldInfo fi in t.GetFields())
                {
                    //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
                    sw.WriteLine("Field name = " + fi.Name);

                }

            }

            using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default))
            {
                foreach (MethodInfo mi in t.GetMethods())
                {
                                              //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
                    sw.WriteLine("Method Name = " + mi.Name);
                    foreach (ParameterInfo pr in mi.GetParameters())
                    {
                        //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
                        sw.WriteLine("Parameter Name = " + pr.Name);

                    }
                }            
           
                foreach (PropertyInfo pi in t.GetProperties())
                {
                                                   //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
                        sw.WriteLine("Property name = " + pi.Name);
                
                }

                foreach (Type tt in t.GetInterfaces())
                {
                                                  //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
                        sw.WriteLine("Interface name = " + tt.Name);
                
                }

                foreach (EventInfo ei in t.GetEvents())
                {
                                                   //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
                        sw.WriteLine("Event name = " + ei.Name);
                
                }
            }
            //foreach (MemberInfo mei in t.GetMembers())
            //{                
            //    using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.Default))
            //    {                               //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
            //        sw.WriteLine("Member name = " + mei.Name);
            //    }
            //}

            //foreach (MethodInfo mi in t.GetMethods())
            //{
            //    using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default))
            //    {                               //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
            //        sw.WriteLine("Method Name = " + mi.Name);
            //    }

            //    foreach (ParameterInfo pr in mi.GetParameters())
            //    {                   
            //        using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default))
            //        {                               //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
            //            sw.WriteLine("Parameter Name = " + pr.Name);
            //        }                   
            //    }

            //}

            //foreach (FieldInfo fi in t.GetFields())
            //{
            //    using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default))
            //    {                               //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
            //        sw.WriteLine("Field name = " + fi.Name);
            //    }
            //}

            //foreach (PropertyInfo pi in t.GetProperties())
            //{
            //    using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default))
            //    {                               //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
            //        sw.WriteLine("Property name = " + pi.Name);
            //    }
            //}

            //foreach (Type tt in t.GetInterfaces())
            //{
            //    using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default))
            //    {                               //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
            //        sw.WriteLine("Interface name = " + tt.Name);
            //    }
            //}

            //foreach (EventInfo ei in t.GetEvents())
            //{
            //    using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default))
            //    {                               //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
            //        sw.WriteLine("Event name = " + ei.Name);
            //    }
            //}
        }

        public void Metods<T>()
        {
            Type t = typeof(T);
            foreach (MethodInfo mi in t.GetMethods())
            {
                Console.WriteLine("Public method name = " + mi.Name); 
            }
        }

        public void FieldAndProperInfo<T>()
        {
            Type t = typeof(T);
            foreach (FieldInfo fi in t.GetFields())
            {
                Console.WriteLine("Field name = " + fi.Name);
            }
            Console.WriteLine();
            foreach (PropertyInfo pi in t.GetProperties())
            {
                Console.WriteLine("Property name = " + pi.Name);
            }
        }

        public void Interf<T>()
        {
            Type t = typeof(T);
            foreach (Type tt in t.GetInterfaces())
            {
                //string s = tt.Name;
                Console.WriteLine("Interface name = " + tt.Name);
            }
        }

        public void MethodWithParamType(U cl, Type UserType)
        {
            Type t = typeof(U);

            foreach (MethodInfo mi in t.GetMethods())
            {
                foreach (ParameterInfo pi in mi.GetParameters())
                {
                    if (pi.ParameterType == UserType)
                    {
                        Console.WriteLine("Name of method that contains type " + UserType + " = " + mi.Name);
                    }

                }
            }

        }
    }
}
