using System;
using System.Collections;

namespace InterfaceExample
{
    /// <summary>
    ///因为num1和num2是两种不同类型，所以要有两种不同方法体，这里就会导致类型不同，
    ///需要多个方法体，从而引入接口概念。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[] { 1, 2,3, 4, 5, 6 };
            ArrayList num2 = new ArrayList() { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(Sum(num1));
            Console.WriteLine(Avg(num1));

            Console.WriteLine(Sum(num2));
            Console.WriteLine(Avg(num2));
        }
        static int Sum(int[] nums)
        {
            int sum=0;
            foreach (var num in nums)
            {
                sum += num;
            }
            return sum;
        }
        static double Avg(int[] nums)
        {
            int sum = 0;
            double count = 0;
            foreach (var num in nums)
            {
                sum += num;
                count++;
            }
            return sum/count;
        }

        static int Sum(ArrayList nums)
        {
            int sum = 0;
            foreach (var num in nums)
            {
                sum += (int)num;
            }
            return sum;
        }
        static double Avg(ArrayList nums)
        {
            int sum = 0;
            double count = 0;
            foreach (var num in nums)
            {
                //因为存储的类型是ArrayList，所以要进行类型转换
                sum += (int)num;
                count++;
            }
            return sum / count;
        }
    }
}
