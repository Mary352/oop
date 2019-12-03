using System;

namespace lab_8
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CollectionType<int>.Stack<int> stack = new CollectionType<int>.Stack<int>();

                //System.ArgumentOutOfRangeException
                //stack.SeeAll();

                stack.AddEl(5);
                stack.AddEl(7);
                stack.AddEl(12);
                stack.AddEl(3);
                stack.AddEl(8);

                stack.DelEl();
                stack.SeeAll();

                //CollectionType<Author>.Stack<Author> stack3 = new CollectionType<Author>.Stack<Author>();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Стек пуст. Вы не можете вывести его элементы");
            }
            finally
            {
                CollectionType<Person>.Stack<Person> stack2 = new CollectionType<Person>.Stack<Person>();
                Person p1 = new Person("Ann", "Walter", 25);
                Person p2 = new Person("Kate", "Smith", 41);
                Person p3 = new Person("John", "Hole", 32);
                Person p4 = new Person("Joanne", "Rowling", 54);
                Person p5 = new Person("Joseph", "Popper", 27);

                stack2.AddEl(p1);
                stack2.AddEl(p2);
                stack2.AddEl(p3);
                stack2.AddEl(p4);
                stack2.AddEl(p5);

                stack2.DelEl();
                stack2.SeeAll();
            }
        }
    }
}