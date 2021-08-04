using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P69数组的练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            //从一个整数数组中取出最大的整数，最小整数，总和，平均值
            int[] a = new int[4];
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            bool flag = false;
            while (flag == false) 
            {
                try
                {
                    Console.WriteLine("请输入4个数字");
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i] = Convert.ToInt32(Console.ReadLine());
                        if (max < a[i])
                        {

                            max = a[i];
                        }
                        if (min > a[i])
                        {
                            min = a[i];
                        }
                        sum += a[i];

                    }
                    Console.WriteLine("其中最大的数为{0}，最小的数是{1}，总和是{2}，平均数为{3}", max, min, sum, sum / a.Length);
                    flag = true;
                }
                catch
                {
                    Console.WriteLine("输入的类型不对，请重新输入。");
                }

            }
            Console.ReadKey();
        }
    }
}
