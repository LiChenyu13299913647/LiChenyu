using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("老苏，请输入你的语文成绩");
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("再输入你的音乐成绩");
            int music = Convert.ToInt32(Console.ReadLine());
            bool result = (chinese > 90 && music > 80) || (chinese == 100 && music > 70);
            if (result)
            {
                Console.WriteLine("奖励老苏100块钱！");
            }
            Console.ReadKey();
        }
    }
}
