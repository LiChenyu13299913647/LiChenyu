using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您的年龄");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age>=23)
            {
                Console.WriteLine("您到了结婚的年龄了");
            }
            Console.ReadKey();
        }
    }
}
