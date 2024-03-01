using System;
using System.Collections;

namespace InterfaceExample2
{
    /// <summary>
    /// 因为Array和ArrayList都是经过 IEnumerable进行迭代和继承的，这个是父类，
    /// 所以范围要广，所以我们就这可以用这个类型去定义两个方法中变里，不用重复写那么多方
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[] { 1, 2, 3, 4, 5, 6 };
            ArrayList num2 = new ArrayList() { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(Sum(num1));
            Console.WriteLine(Avg(num1));

            Console.WriteLine(Sum(num2));
            Console.WriteLine(Avg(num2));
        }
        static int Sum(IEnumerable nums)
        {
            int sum = 0;
            foreach (var num in nums)
            {
                sum += (int)num;
            }
            return sum;
        }
        static double Avg(IEnumerable nums)
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
