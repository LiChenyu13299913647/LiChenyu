using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P65枚举的类型
{
    public enum Season
    {
        春,
        夏,
        秋,
        冬
    }
    enum Name
    {
        小李,
        小王,
        小明
    }
    class Program
    {
        static void Main(string[] args)
        {
            Season s = Season.春;
            Name n = Name.小明;
        }
    }
}
