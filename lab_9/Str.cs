using System;
using System.Collections.Generic;
using System.Text;

namespace lab_9
{
    class Str
    {
        public string DeleteMarks(string str)
        {
            string[] str_arr = str.Split(new char[] { ' ', ',', '.' });
            string item = str_arr[0];

            foreach (string s in str_arr)
            {
                if (String.Compare(s, item) != 0)
                {
                    item += s;
                }
            }
            Console.WriteLine(item);
            return item;
        }

        public string[] SortABC(string str)
        {
            string[] str_arr = str.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(str_arr);

            return str_arr;
            //Console.WriteLine();
            //foreach (var item in str_arr)
            //{
            //    Console.WriteLine(item);
            //}
        }

        public string UpLow(string str)
        {
            string[] str_arr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string item = str_arr[0];

            for (int i = 0; i < str_arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    str_arr[i] = str_arr[i].ToUpper();
                    
                    if (i == 0)
                    {
                        item = str_arr[i];
                    }
                }
                else
                {
                    str_arr[i] = str_arr[i].ToLower();
                }
            }

            foreach (string s in str_arr)
            {
                if (String.Compare(s, item) != 0)
                {
                    item += " ";
                    item += s;
                }
            }
            return item;
            //Console.WriteLine();
            //Console.WriteLine(item);
        }

        public string DelSomeWords(string str)
        {
            string[] str_arr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string item = str_arr[0];

            // удаление слов, имеющих чётное количество букв
            for (int i = 0; i < str_arr.Length; i++)
            {
                if (str_arr[i].Length % 2 == 0)
                {
                    str_arr[i] = "0";
                }
            }
            foreach (string s in str_arr)
            {
                if (String.Compare(s, item) != 0 && String.Compare(s, "0") != 0)
                {
                    item += " ";
                    item += s;
                }
            }
            return item;
            //Console.WriteLine();
            //Console.WriteLine(item);
        }

        public string FirstLastHigh(string str)
        {
            str = str.Insert(0, "SurprizE ");
            str = str.Insert(str.Length, " To be continued...");
            return str;
            //Console.WriteLine();
            //Console.WriteLine(str);
        }
    }
}
