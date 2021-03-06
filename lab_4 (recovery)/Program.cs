﻿using System;

namespace lab_4__recovery_
{
    
    class Program
    {        

        static void Main(string[] args)
        {
            string xv = "Bacon and eggs. Frogs and dogs? Chess and mess!";
            
            Console.WriteLine("Количество предложений: " + xv.NumOfSent());

            Stack stack1 = new Stack();
            if (stack1)
            {
                Console.WriteLine("Стек пуст");
            }
            else
            {
                Console.WriteLine($"В стеке есть элементы {stack1.GetElsNum() + 1}");
            }

            stack1.Elements = 5 + stack1;
            Console.WriteLine($"{stack1.GetElsNum() + 1} elem: " + stack1.Elements);
            stack1.Elements = 8 + stack1;
            Console.WriteLine($"{stack1.GetElsNum() + 1} elem: " + stack1.Elements);
            stack1.Elements = 9 + stack1;
            Console.WriteLine($"{stack1.GetElsNum() + 1} elem: " + stack1.Elements);
            stack1.Elements = 3 + stack1;
            Console.WriteLine($"{stack1.GetElsNum() + 1} elem: " + stack1.Elements);
            stack1.Elements = 7 + stack1;
            Console.WriteLine($"{stack1.GetElsNum() + 1} elem: " + stack1.Elements);


            //stack1.Elements = 6 + stack1;             //переполнение стека
            //Console.WriteLine("Sixth elem: " + stack1.Elements);
            //stack1--;

            Console.WriteLine($"\n{stack1.GetElsNum() + 1} elem: " + stack1.Elements);
            
            if (stack1)
            {
                Console.WriteLine("Стек пуст");
            }
            else
            {
                Console.WriteLine($"В стеке есть элементы {stack1.GetElsNum() + 1}");
            }

            Stack stack2 = new Stack();
                        
            if (stack2)
            {
                Console.WriteLine("\nНовый стек пуст");
            }
            else
            {
                Console.WriteLine($"\nВ новом стеке есть элементы {stack2.GetElsNum() + 1}");
            }
            stack2 = stack1 > stack2;

            Console.WriteLine($"Upper elem {stack2.GetElsNum() + 1}: " + stack2.ElementsUpSort + "\n");

            //Stack stack3 = new Stack();
            //stack3 = stack1 < stack3;
            //Console.WriteLine($"Upper elem {stack3.GetElsNum() + 1}: " + stack3.Elements + "\n");

            Stack.Owner owner = new Stack.Owner("Maria", 51548647, "BSTU");

            owner.GetInfo();

            Stack.Date date = new Stack.Date(24, 10, 2019);

            date.GetDate();

            StatisticOperation.GetSum(stack1);
            //StatisticOperation.Max_Min(stack1);
            //StatisticOperation.ElsCounter(stack1);

            //stack1.Average();
        }
        

    }

    public static class StackExtension
    {
        public static void Average(this Stack stk)
        {
            int q = stk.GetElsNum() + 1;

            if (q % 2 != 0)      //нечёт кол-во эл-в
            {
                while (stk.GetElsNum() != q / 2)
                {
                    stk--;
                }

                Console.WriteLine("Средний эл-т стека: " + stk.Elements);
            }

            else        //чёт кол-во эл-в
            {
                //while (stk.GetElsNum() != q / 2 - 1)
                //{
                //    stk--;
                //}

                Console.WriteLine("Невозможно определить средний эл-т стека");
            }

        }
        
    }

    public static class StringExtension
    {
        public static int NumOfSent(this String str)
        {
            int count = 0;

            foreach (char isEnd in str)
            {
                if (isEnd.Equals('.') || isEnd.Equals('!') || isEnd.Equals('?'))
                {
                    count++;
                }
            }

            //Console.WriteLine("Количество предложений: " + count);    д/void
            return count;
        }
    }
}
