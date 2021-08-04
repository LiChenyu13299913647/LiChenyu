using System;

namespace 程序练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            //P15 练习题1
            string name = "卡卡西";
            int age = 30;
            string address = "火影村";
            string mailbox = "kakaxi@qq.com";
            decimal wages = 2000;
            Console.WriteLine("我叫" + name + ",我住在" + address + "，我今天" + age + "了，我的邮箱是" + mailbox + ",我的工资" + wages + "。");
            Console.ReadKey();
        }
    }
}
