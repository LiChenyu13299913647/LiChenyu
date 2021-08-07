using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P76方法的调用
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法，判断年份是否是闰年
            bool result = LeapYear(2000);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断输入的年份是不是闰年，如果是返回true,不是返回false
        /// </summary>
        /// <param name="year">要判断的年份</param>
        /// <returns>是闰年返回true</returns>
        public static bool LeapYear(int year)
        {
            bool result = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            return result;
        }
    }
}
