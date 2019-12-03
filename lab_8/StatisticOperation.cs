//using System;

//namespace lab_4__recovery_
//{
//    static class StatisticOperation
//    {
//        public static int sum = 0;

//        public static int GetSum(Stack stack)
//        {
//            for (int i = stack.GetElsNum(); i >= 0; i--)
//            {
//                //Console.WriteLine("ElsNum: " + stack.GetElsNum());
//                sum = sum + stack.Elements;
//                //Console.WriteLine(sum);
//                //Console.WriteLine("");

//                stack--;
//            }

//            Console.WriteLine("\nСумма эл-в стека: " + sum);

//            return sum;
//        }

//        public static void Max_Min(Stack stack)
//        {
//            int res;            
//            int max = stack.Elements;
//            int min = stack.Elements;

//            for (int i = stack.GetElsNum(); i >= 0; i--)
//            {
//                if(stack.Elements > max)
//                {
//                    max = stack.Elements;
//                }
//                else if(stack.Elements < min && stack.Elements != 0)
//                {
//                    min = stack.Elements;
//                }

//                stack--;
//            }

//            res = max - min;

//            //Console.WriteLine(max);
//            //Console.WriteLine(min);
//            Console.WriteLine("\nРазница между макс. и мин. эл-ми стека: " + res);
//        }

//        public static void ElsCounter(Stack stack)
//        {
//            int counter = 0;
                        
//            while (!stack.IsEmpty())
//            {
//                counter++;                
//                stack--;
//            }

//            Console.WriteLine("Эл-в в стеке: " + counter);
//        }

//    }
//}