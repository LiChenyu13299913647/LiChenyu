using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p33if_else结构练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入结业考试成绩");
            int result = Convert.ToInt32(Console.ReadLine());
            if (result >= 90)
            {
                Console.WriteLine("评测等级为A");
            }
            else if (result >= 80)
            {
                Console.WriteLine("评测等级为B");
            }
            else if (result >= 70)
            {
                Console.WriteLine("测评结果为C");
            }
            else if (result >= 60)
            {
                Console.WriteLine("测评结果为D");
            }
            else
            {
                Console.WriteLine("测评结果为E");
            }
            Console.ReadKey();
        }
    }
}
