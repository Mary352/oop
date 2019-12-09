using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;


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

            //-----------------------------------------------------------------
            Console.WriteLine("\n--------------------------------------------------------------------");

            Console.WriteLine("LinkedList user");
            LinkedList<Person> l_listu = new LinkedList<Person>();

            l_listu.AddFirst(new Person("Maggi", "Willson", 54));
            l_listu.AddLast(new Person("Sophie", "Brown", 25));
            l_listu.AddFirst(new Person("Lina", "Miller", 31));
            l_listu.AddLast(new Person("Samanta", "Goodman", 35));
            l_listu.AddLast(new Person("Sophie", "Brown", 25));
            l_listu.AddLast(new Person("Samanta", "Goodman", 35));
            l_listu.AddLast(new Person("Maggi", "Willson", 54));
            
            Console.WriteLine("Before: ");
            foreach (var item in l_listu)
            {
                Console.WriteLine(item);
            }

            while (l_listu.Count != 4)
            {
                l_listu.RemoveLast();
            }
            Console.WriteLine();

            Console.WriteLine("After: ");
            foreach (var item in l_listu)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            LinkedListNode<Person> node2 = l_listu.First;
            node = node.Next;

            l_listu.AddBefore(node2, new Person(1));
            l_listu.AddAfter(node2, new Person('j'));
            node = node.Next;
            node = node.Next;
            l_listu.AddAfter(node2, new Person("ndd"));


            Console.WriteLine("+new elems: ");
            foreach (var item in l_listu)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\tHashSet");
            HashSet<Person> hsu = new HashSet<Person>();

            foreach (Person item in l_listu)
            {
                hsu.Add(item);
            }

            Console.WriteLine("Elems: ");
            foreach (Person item in hsu)
            {
                Console.WriteLine(item);
            }
            
            if (hsu.Contains(new Person(2)))
            {
                Console.WriteLine("Collection contains this object");
            }
            else
            {
                Console.WriteLine("no such object in collection");
            }

            if (hsu.Contains(new Person("Diana", "Goodman", 46)))
            {
                Console.WriteLine("Collection contains this object");
            }
            else
            {
                Console.WriteLine("No such object in collection");
            }

            Console.WriteLine("\n\tObservableCollection");
            ObservableCollection<Person> oc = new ObservableCollection<Person>();

            oc.CollectionChanged += CollectionChanged;

            oc.Add(new Person(5));
            oc.Add(new Person('n'));
            oc.Add(new Person("bshd"));

            foreach (var item in oc)
            {
                Console.WriteLine(item);
            }

        }

        private static void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) 
        { 
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Person newPer = e.NewItems[0] as Person;
                    Console.WriteLine("New object added:");
                    Console.WriteLine(newPer.FirstName);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Person delPer = e.NewItems[0] as Person;
                    Console.WriteLine("Object was deleted: ");
                    Console.WriteLine(delPer);

                    break;
            }
        }

    }
}
