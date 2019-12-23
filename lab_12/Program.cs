using System;
using System.Reflection;
using System.IO;
using System.Text;

namespace lab_12
{
    class Program
    {       

        static void Main(string[] args)
        {
            Reflector<Book, int> r = new Reflector<Book, int>();
            Reflector<Human, int> r2 = new Reflector<Human, int>();
            Reflector<Str, int> r3 = new Reflector<Str, int>();
            Reflector<Game, int> r4 = new Reflector<Game, int>();
            Reflector<Magazine, int> r5 = new Reflector<Magazine, int>();


            r.WriteFile<Human>();
            //r.WriteFile<Game>();
            //r.WriteFile<Book>();

            r.Metods<LibControl>();
            Console.WriteLine();
            r.Metods<Library>();
            Console.WriteLine();

            r.FieldAndProperInfo<Author>();
            Console.WriteLine();
            r.FieldAndProperInfo<Book>();
            Console.WriteLine();

            Magazine m1 = new Magazine();
            r5.Interf(m1);
            Console.WriteLine();

            Type t = typeof(Int32);
            Human h1 = new Human("Gamer");
            r2.MethodWithParamType(h1, t);
            Console.WriteLine();
            Type t2 = typeof(String);
            Str b = new Str();
            r3.MethodWithParamType(b, t2);

            int p;
            Game g = new Game();
            string readf = @"D:\3 сем\ООП 3 сем\ЛР\lab_12\read.txt";
            using (StreamReader sr = new StreamReader(readf, Encoding.Default))
            {
                p = int.Parse(sr.ReadLine());
            }

            r4.CallMethod(g, p, g.moveTo);
        }
    }
}
