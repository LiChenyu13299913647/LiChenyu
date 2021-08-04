using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P72方法的简单练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.PlayGame();
            Program.GameEvent();
            Console.ReadKey();
            Program.PlayGame();
            Program.PlayGame();
            Program.GameEvent();
            Console.ReadKey();

        }
        public static void PlayGame()
        {
            Console.WriteLine("游戏在正常运行，running");
            Console.WriteLine("游戏在正常运行，running");
            Console.WriteLine("游戏在正常运行，running");
            Console.WriteLine("游戏在正常运行，running");
            Console.WriteLine("游戏在正常运行，running");
            Console.WriteLine("游戏在正常运行，running");
        }
        public static void GameEvent()
        {
            Console.WriteLine("出现了特殊时间，stopping");
        }
    }
}
