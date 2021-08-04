using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31练习3逻辑运算符与或非
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入用户名");
            string user = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string passWord = Console.ReadLine();
            if (user=="admin"||passWord=="mypass")
            {
                Console.WriteLine("登陆成功");
            }
            Console.ReadKey();
        }
    }
}
