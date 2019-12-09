using System;
using System.Collections;
using System.Collections.Generic;

namespace lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tArrayList");
            ArrayList a_list = new ArrayList();

            a_list.AddRange(new int[] { 5, 10, 23, 108, 4 });
            a_list.Add("See the difference");
            a_list.Add(new Student());

            a_list.RemoveAt(a_list.Count-1);

            Console.WriteLine("Number of elements: " + a_list.Count);
            Console.WriteLine("Elements in a_list:");
            foreach (var item in a_list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Index of 23: " + a_list.IndexOf(23));


            Console.WriteLine("\n\tLinkedList");
            LinkedList<char> l_list = new LinkedList<char>();

            l_list.AddFirst('c');
            l_list.AddLast('n');
            l_list.AddFirst('h');
            l_list.AddLast('u');
            l_list.AddLast('a');
            l_list.AddLast('s');
            l_list.AddLast('r');
            l_list.AddLast('t');
            l_list.AddLast('w');
            l_list.AddFirst('b');
            l_list.AddFirst('i');
            l_list.AddFirst('t');

            Console.Write("Before: ");
            foreach (var item in l_list)
            {
                Console.Write(item + " ");
            }

            while (l_list.Count != 7)
            {
                l_list.RemoveFirst();
            }
            Console.WriteLine();

            Console.Write("After: ");
            foreach (var item in l_list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            LinkedListNode<char> node = l_list.First;
            node = node.Next;

            l_list.AddBefore(node, '5');
            node = node.Next;
            l_list.AddAfter(node, '7');

            Console.Write("+new elems: ");
            foreach (var item in l_list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\n\tHashSet");
            HashSet<char> hs = new HashSet<char>();

            foreach (char item in l_list)
            {
                hs.Add(item);
            }

            Console.Write("Elems: ");
            foreach (var item in hs)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            if (hs.Contains('5'))
            {
                Console.WriteLine("Collection contains '5'");
            }
            else
            {
                Console.WriteLine("no '5' in collection");
            }

        }
    }
}
