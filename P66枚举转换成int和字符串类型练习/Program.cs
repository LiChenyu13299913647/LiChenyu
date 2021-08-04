using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P66枚举转换成int和字符串类型练习
{
    public enum QQState
    {
        OnLine=1,
        OffLine,
        Leave,
        Busy,
        QMe
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 枚举可以直接转换成int类型
            //Console.WriteLine((int)QQState.OnLine);
            //Console.WriteLine((int)QQState.OffLine);
            //Console.WriteLine((int)QQState.Leave);
            //Console.WriteLine((int)QQState.Busy);
            //Console.WriteLine((int)QQState.QMe);
            //Console.ReadKey();
            #endregion
            #region int可以强转为枚举类型，如果int是枚举里不存在的值，就不进行转换
            //int n = 3;
            //Console.WriteLine((QQState)n);
            //int m = 9;
            //Console.WriteLine((QQState)m);
            //Console.ReadKey();
            #endregion
            #region 枚举类型转换成字符串类型
            ////所有类型都能转换成字符串类型
            //QQState state = QQState.OnLine;
            //Console.WriteLine(state.ToString());
            //Console.ReadKey();
            #endregion
            #region 字符串类型转换成为枚举类型
            //string s = "OnLine";
            //QQState state = (QQState)Enum.Parse(typeof(QQState), s);
            //Console.WriteLine(state);
            //Console.ReadKey();
            #endregion
            //提示用户选择一个在线状态，我们接收，并将用户的输入转换成枚举类型，
            //再次打印到控制台中
            Console.WriteLine("请选择您的在线状态：1--OnLine 2--OffLine 3--Leave 4--Busy 5--QMe");
            QQState userState = (QQState)Enum.Parse(typeof(QQState), Console.ReadLine());
            Console.WriteLine("您的状态已切换为{0}",userState);
            Console.ReadKey();
        }
    }
}
