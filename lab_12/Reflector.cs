using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;

namespace lab_12
{
    class Reflector
    {
        public void WriteFile<T>()
        {
            FileStream fs = new FileStream(@"D:\3 сем\ООП 3 сем\ЛР\lab_12\file.txt", FileMode.OpenOrCreate, FileAccess.Write);
            Type t = typeof(T);
            foreach (MemberInfo mei in t.GetMembers())
            {
                Console.WriteLine("Member name = " + mei.Name);
            }
            foreach (MethodInfo mi in t.GetMethods())
            {
                //fs.Write("Public method name = " + mi.Name);
                foreach (ParameterInfo pr in mi.GetParameters()) 
                { 
                    Console.WriteLine("Parameter Name = " + pr.Name);                    
                }

            }
            foreach (FieldInfo fi in t.GetFields())
            {
                Console.WriteLine("Field name = " + fi.Name);
            }
            Console.WriteLine();
            foreach (PropertyInfo pi in t.GetProperties())
            {
                Console.WriteLine("Property name = " + pi.Name);
            }
            foreach (Type tt in t.GetInterfaces())
            {
                Console.WriteLine("Interface name = " + tt.Name);
            }
            foreach (EventInfo ei in t.GetEvents())
            {
                Console.WriteLine("Interface name = " + ei.Name);
            }

            fs.Close();
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
                Console.WriteLine("Interface name = " + tt.Name);
            }
        }
    }
}
