using System;

namespace lab_4__recovery_
{
    class Program
    {
        static void Main(string[] args)
        {
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


            //stack1.Elements = 6 + stack1;                    //переполнение стека
            //Console.WriteLine("Sixth elem: " + stack1.Elements);
            stack1--;

            Console.WriteLine($"{stack1.GetElsNum() + 1} elem: " + stack1.Elements);

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
                Console.WriteLine("Стек пуст");
            }
            else
            {
                Console.WriteLine($"В стеке есть элементы {stack2.GetElsNum() + 1}");
            }
            stack2 = stack1 > stack2;

            Console.WriteLine($"Upper elem {stack2.GetElsNum()}: " + stack2.Elements);

            Stack.Owner owner = new Stack.Owner("Maria", 51548647, "BSTU");

            owner.GetInfo();

            Stack.Date date = new Stack.Date(24, 10, 2019);

            date.GetDate();

            Console.WriteLine(StatisticOperation.GetSum(stack2)); 
        }
    }
}
