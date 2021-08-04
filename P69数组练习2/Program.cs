using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P69数组练习2
{
    class Program
    {
        static void Main(string[] args)
        {//数组里面都是人的名字，分割成：老杨|老苏|老邹...
            //(老杨、老苏、老邹、老虎、老牛、老蒋、老王、老马)
            string[] personName = { "老杨", "老苏", "老邹", "老虎", "老牛", "老王", "老马" };
            string str = null;
            for (int i = 0; i < personName.Length - 1; i++)
            {
                str += personName[i] + "|";
            }
            Console.WriteLine(str + personName[personName.Length-1]);
            Console.ReadKey();
        }
    }
}
