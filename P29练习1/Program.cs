using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P29练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("小木子，请输入你的语文成绩。");
            int Chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("再输入你的英语成绩");
            int English = Convert.ToInt32(Console.ReadLine());
            bool result = Chinese > 90 && English > 90;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
