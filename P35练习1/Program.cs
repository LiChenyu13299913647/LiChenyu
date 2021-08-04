using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P35练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 比较三个数的大小，不考虑相等
            // 让用户输入三个数，并将这三个数转换为int类型
            Console.WriteLine("比较三个数的大小，请输入第一个数");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("比较三个数的大小，请输入第二个数");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("比较三个数的大小，请输入第三个数");
            int number3 = Convert.ToInt32(Console.ReadLine());
            //先让第一个和第二个比较大小，如果一比二大，再让二和三比较，三如果比二小，三是最小的，三比二大，三和一比较
            if (number1 > number2)
            {
                if (number2 > number3)
                {
                    Console.WriteLine("{0}>{1}>{2}", number1, number2, number3);
                }

                else if (number3 > number1)
                {
                    Console.WriteLine("{0}>{1}>{2}", number3, number1, number2);
                }
                else
                {
                    Console.WriteLine("{0}>{1}>{2}", number1, number3, number2);
                }

            }
            //二比一大，一再和三比较大小
            else if (number1 > number3)
            {
                Console.WriteLine("{0}>{1}>{2}", number2, number1, number3);
            }
            //三比一大，三和二比较
            else if (number3 > number2)
            {
                Console.WriteLine("{0}>{1}>{2}", number3, number2, number1);
            }
            else
            {
                Console.WriteLine("{0}>{1}>{2}", number2, number3, number1);
            }
            Console.ReadKey();

        }
    }
}
