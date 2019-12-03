using System;

namespace lab_8
{

    class Program
    {
        static void Main(string[] args)
        {
            CollectionType<int>.Stack<int> stack = new CollectionType<int>.Stack<int>();

            //stack.SeeAll();
            stack.AddEl(5);
            stack.AddEl(7);
            stack.AddEl(12);
            stack.AddEl(3);
            stack.AddEl(8);

            stack.DelEl();
            stack.SeeAll();
        }
    }
}