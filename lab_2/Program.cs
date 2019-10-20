using System;
using System.Collections;
using System.Text;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string sssss = "123";
            string ssssss = "1234567";
            Console.WriteLine(sssss.CompareTo(ssssss));
            


            //-----------------------------------1-------------------------------------------
            //----a------------------
            int a = -1000000000;
              double b = 10.25454;
              float c = 10.22f;
              char d = 's';
              bool e = true;
              decimal f = 5.46M;
              sbyte l = -127;
              byte m = 255;
              uint n = 1000000000;
              long o = -9223372036854775807;
              ulong p = 18446744073709551615;
              short q = -32768;
              ushort r = 65535;

              //----b------------------
              //неявно
              long s = a;
              double t = c;
              short u = m;
              int v = q;
              decimal w = m;

              //явно
              int x = (int)b;
              byte y = (byte)d;
              char z = (char)m;
              decimal aa = (decimal)b;
              uint bb = (uint)q;

              //----c------------------
              object cc = l;          //упаковка
              sbyte dd = (sbyte)cc;   //распаковка

              //----d------------------
              var ee = 5;
              //ee = "bee";     //ee условно типа int (по значению 5), поэтому типы, требующие явного преобразования нельзя присвоить
              ee = 10;

              //----e------------------
              int? x1 = null;
              Nullable<int> x2 = null;
              if(x1 == x2)
              {
                  Console.WriteLine("yes!");
              }
              else
              {
                  Console.WriteLine("no");
              }

              //---------------------------------2---------------------------------------------
              //----a------------------
              string strl1 = @"Hello!->
  ->My dear friend!";
              Console.WriteLine(strl1);
              string strl2 = "/Hola!/";            
              Console.WriteLine(strl2);

              if (strl1 == strl2)
              {
                  Console.WriteLine("strl1 = strl2");
              }
              else
              {
                  Console.WriteLine("strl1 and strl2 are not equal");
              }

              //----b------------------
              string str1 = " Первая тестовая строка ";
              string str2 = " Креатив - наше всё ";
              string str3 = " На дворе трава, на траве дрова, не руби дрова на траве двора ";

              //сцепление
              string strCnct = String.Concat(str2, str3);
              Console.WriteLine(strCnct);

              //копирование
              string strCopy = String.Copy(str1);
              Console.WriteLine(strCopy);

              //выделение подстроки (индекс первого символа (нумерац. с 0), длина подстроки)
              string strSub = str1.Substring(8, 15);
              Console.WriteLine(strSub);

              //разделение строки на слова
              string[] someWords = str1.Split(' ');
              foreach(string oneWord in someWords)
              {
                  Console.WriteLine(oneWord);
              }

              //{ ' ', ',' } - убираем ненужные символы с помощью массива разделителей
              //StringSplitOptions.RemoveEmptyEntries - избавляемся от пустых элементов массива, которые появились потому, 
              //что между разделителями нет ни одного строчного символа
              string[] words = str3.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
              foreach (string word in words)
              {
                  Console.WriteLine(word);
              }

              //вставка подстроки в заданную позицию
              string strIns = str3.Insert(55, " странного");
              Console.WriteLine(strIns);

              //удаление заданной подстроки
              string strRmv = str3.Remove(15, 16);    //(стартовый индекс, длина подстроки)
              Console.WriteLine(strRmv);

              string strRmv2 = str3.Remove(31);    //(стартовый индекс)
              Console.WriteLine(strRmv2);

              //----c------------------
              string strEmpty = "";
              string strNull = null;

              Console.WriteLine("|{0}|", String.Concat(strEmpty, strNull));

              if(strEmpty.Equals(strNull) == false)
              {
                  Console.WriteLine("строки не равны");
              }
              else
              {
                  Console.WriteLine("строки равны");
              }

              int num = strEmpty.CompareTo(strNull);
              if (num < 0)
              {
                  Console.WriteLine("{0} - значение strEmpty больше strNull", num);
              }
              else if(num > 0)
              {
                  Console.WriteLine("{0} - значение strEmpty меньше strNull", num);
              }
              else
              {
                  Console.WriteLine("{0} - значение strEmpty равно strNull", num);
              }

              //----d------------------
              StringBuilder sb = new StringBuilder("There are a lot of frogs( ", 70);

              string newStrApp = "Where is my socks?";
              sb.Append(newStrApp);
              Console.WriteLine(sb);

              sb.Insert(0, "It's raining cats and dogs. ");
              Console.WriteLine(sb);

              sb.Append('!');
              Console.WriteLine(sb);

              sb.Insert(0, ":)");
              Console.WriteLine(sb);

              sb.Remove(0, 2);
              Console.WriteLine(sb);

              //---------------------------------3---------------------------------------------
              //----a------------------
              int[,] arr = { { 1, 2, 3 }, { 8, 9, 10 } };
              int count = 0;
              foreach (int i in arr)
              {
                  count++;

                  if (count == arr.GetLength(1) + 1)   //arr.GetLength(0) - число строк, arr.GetLength(1) - число столбцов
                  {
                      Console.Write("\n");
                  }

                  Console.Write(" " + i);
              }
              Console.Write("\n");

              //----b------------------
              string[] arr2 = { "second", "minute", "hour", "day", "week", "month", "year" };
              foreach(string st in arr2)
              {
                  Console.Write("\t" + st);
              }

              Console.WriteLine("\nДлина массива = " + arr2.Length);

              Console.Write("Введите позицию нового элемента массива (от 0 до 6): ");
              int fromUser = int.Parse(Console.ReadLine());   //ввод числа в консоль
              Console.Write("Введите значение нового элемента массива: ");
              string valFromUser = Console.ReadLine();
              if (fromUser >= 0 && fromUser < arr2.Length)
              {
                  arr2[fromUser] = valFromUser;

                  foreach (string st in arr2)
                  {
                      Console.Write("\t" + st);
                  }
              }
              else
              {
                  Console.WriteLine("Incorrect value {0}", fromUser);
              }

              Console.WriteLine();

              //----с------------------
              float[][] arrFL = { new float[2], new float[3], new float[4] };
              Console.WriteLine("Начните вводить элементы массива float:");
              for(int k = 0; k < 4; k++)
              {
                  if(k < 2)
                  {
                      arrFL[0][k] = float.Parse(Console.ReadLine());
                  }
                  if (k < 3)
                  {
                      arrFL[1][k] = float.Parse(Console.ReadLine());
                  }
                  if (k < 4)
                  {
                      arrFL[2][k] = float.Parse(Console.ReadLine());
                  }
              }
              foreach(float[] ff in arrFL)
              {
                  foreach(float xx in ff)
                  {
                      Console.Write("\t" + xx);
                  }

                  Console.WriteLine();
              }

              //----d------------------
              var strUnt = "hourse in my house";
              var arrUnt = new int[] { 1, 3, 5, 7 };

            //---------------------------------4---------------------------------------------
            //----a------------------
            (int, string, char, string, ulong) tuple = (10, "Austria", 'd', "the UK", 1024);

            //----b------------------
            Console.WriteLine($"{tuple}");
            Console.WriteLine(tuple.Item1 + " " + tuple.Item3 + " " + tuple.Item4);

            //----c------------------
            int num1 = tuple.Item1;
            string str5 = tuple.Item2;
            char symb = tuple.Item3;
            string str6 = tuple.Item4;
            ulong num2 = tuple.Item5;

            //----d------------------
            (int num3, string str7, char symb2, string str8, ulong num4) tuple2 = (10, "Finland", 'b', "China", 164845);
            int total = tuple.CompareTo(tuple2);

            if(total < 0)
            {
                Console.WriteLine("tuple предшествует параметру tuple2");
            }
            else if (total > 0)
            {
                Console.WriteLine("tuple стоит после параметра tuple2 или свойство tuple2 имеет значение null");
            }
            else
            {
                Console.WriteLine("tuple имеет ту же позицию в порядке сортировки, что и tuple2");
            }

            //---------------------------------5---------------------------------------------
            (int, int, int, string) retTuple(int[] arr5, string str10)
            {
                Array.Sort(arr5);       //сортировка элементов массива по возрастанию
                int minArr = arr5[0];
                int maxArr = arr5[4];

                int elemSum = 0;
                for(int i2 = 0; i2 < 5; i2++)
                {
                    elemSum += arr5[i2];
                }

                string symStr = str10.Substring(0, 1);

                return (minArr, maxArr, elemSum, symStr);
            }

            int[] arrInt = { 2, 5, 1, 3, 4 };
            (int, int, int, string) tuple3 = retTuple(arrInt, "Lazy cat");
            Console.WriteLine($"{tuple3}");
        }
    }
}