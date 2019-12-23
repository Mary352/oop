using System;
using System.Reflection;

namespace lab_12
{
    class Program
    {       

        static void Main(string[] args)
        {
            Reflector r = new Reflector();

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

        }
    }
}
