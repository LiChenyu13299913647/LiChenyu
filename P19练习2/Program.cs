using System;

namespace P19练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您的名字");
            string name = Console.ReadLine();
            Console.WriteLine("请输入您的年龄");
            string age = Console.ReadLine();
            Console.WriteLine("请输入您的性别");
            string gender = Console.ReadLine();
            Console.WriteLine("您好，{1}您的年龄是{0}，是个{2}生", age, name, gender);
            Console.ReadKey();
        }
    }
}
