using System;

namespace lab_4__recovery_
{
    static class StatisticOperation
    {
        public static int sum = 0;

        public static int GetSum(Stack stack)
        {
            //for (int i = stack.GetElsNum(); i >= 0; i--)
            //{
            //    Console.WriteLine("ElsNum: " + stack.GetElsNum());
            //    sum = sum + stack.Elements;
            //    Console.WriteLine(sum);
            //    Console.WriteLine("");

            //    stack--;
            //}

            for (int i = 5; i >= 2; i--)
            {
                Console.WriteLine("ElsNum: " + stack.GetElsNumUpSort());
                sum = sum + stack.Elements;
                Console.WriteLine(sum);
                Console.WriteLine("");

                stack--;
            }
            return sum;
        }

    }
}