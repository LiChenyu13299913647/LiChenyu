using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P43while循环练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入班级人数，然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
            int classNumber;
            double studentScore;
            double sum = 0;
            int i = 0;//用来记录输入学员成绩的次数；
            Console.WriteLine("请输入班级人数");
            classNumber = Convert.ToInt32(Console.ReadLine());
            while (i < classNumber)
            {
                Console.WriteLine("请输入学员{0}的成绩",i+1);
                studentScore = Convert.ToInt32(Console.ReadLine());
                sum += studentScore;
                i++;
            }
            Console.WriteLine("学员的平均成绩是{0}，总成绩是{1}。", sum / classNumber, sum);
            Console.ReadKey();
        }
    }
}
