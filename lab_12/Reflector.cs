using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;

namespace lab_12
{
    class Reflector<U, N> where U : class
    {
        public void WriteFile<T>()
        {
            string filePath = @"D:\3 сем\ООП 3 сем\ЛР\lab_12\file.txt";
            var flag = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

            Type t = typeof(T);

            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.Default))
            {                                 //путь к файлу, дозапись в конец файла или нет(новая запись), исп-мая кодировка
                foreach (FieldInfo fi in t.GetFields(flag))
                {                    
                    sw.WriteLine("Field name = " + fi.Name);
                }
            }

            using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default))
            {
                foreach (MethodInfo mi in t.GetMethods(flag))
                {
                    sw.WriteLine("Method Name = " + mi.Name);
                    foreach (ParameterInfo pr in mi.GetParameters())
                    {
                        sw.WriteLine("Parameter Name = " + pr.Name);
                    }
                }            
           
                foreach (PropertyInfo pi in t.GetProperties(flag))
                {
                        sw.WriteLine("Property name = " + pi.Name);                
                }

                foreach(ConstructorInfo ci in t.GetConstructors())
                {
                    sw.WriteLine("Constructor name = " + ci.Name);
                }

                foreach (Type tt in t.GetInterfaces())
                {
                        sw.WriteLine("Interface name = " + tt.Name);                
                }

                foreach (EventInfo ei in t.GetEvents())
                {
                        sw.WriteLine("Event name = " + ei.Name);                
                }
            }
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
            var flag = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

            Type t = typeof(T);
            foreach (FieldInfo fi in t.GetFields(flag))
            {
                Console.WriteLine("Field name = " + fi.Name);
            }

            Console.WriteLine();

            foreach (PropertyInfo pi in t.GetProperties(flag))
            {
                Console.WriteLine("Property name = " + pi.Name);
            }
        }

        public void Interf(U i)
        {
            Type t = typeof(U);
            foreach (Type tt in t.GetInterfaces())
            {
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

        public void CallMethod(U cl, N d, Action<N> method)
        {
            method(d);
        }
    }
}
