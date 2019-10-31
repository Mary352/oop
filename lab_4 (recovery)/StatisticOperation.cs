using System;

namespace lab_4__recovery_
{
    static class StatisticOperation
    {
        public static int sum = 0;

        public static int GetSum(Stack stack)
        {
            while (stack.Elements != 0)
            {
                sum = sum + stack.Elements;
                stack--;
            }
            return sum;
            //for(int i = 5; i >= 0; i--)
            //{
            //    sum = sum + stack.Elems[i];
            //}

        }

    }
}