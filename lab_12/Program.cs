using System;
using System.Reflection;

namespace lab_12
{
    class Program
    {       

        static void Main(string[] args)
        {
            Reflector<int> r = new Reflector<int>();
            Reflector<Human> r2 = new Reflector<Human>();
            Reflector<Str> r3 = new Reflector<Str>();

            //r.WriteFile<Human>();
            //r.WriteFile<Game>();
            r.WriteFile<Book>();

            r.Metods<LibControl>();
            Console.WriteLine();
            r.Metods<Library>();
            Console.WriteLine();

            r.FieldAndProperInfo<Author>();
            Console.WriteLine();
            r.FieldAndProperInfo<Book>();
            Console.WriteLine();

            r.Interf<Magazine>();
            r.Interf<Author>();
            Console.WriteLine();

            Type t = typeof(Int32);
            Human h1 = new Human("nczn");
            r2.MethodWithParamType(h1, t);
            Console.WriteLine();
            Type t2 = typeof(String);
            Str b = new Str();
            r3.MethodWithParamType(b, t2);



        }
    }
}
