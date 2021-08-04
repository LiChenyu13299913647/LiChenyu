using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P67结构练习
{
    public struct MyColor
    {
        public int _red;
        public int _green;
        public int _blue;
    }

    public enum Gender
    {
        男,
        女
    }
    public struct Person
    {
        public string _name;
        public Gender _gender;
        public int _age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ////练习1：定义一个结构叫MyColor，有三个成员，分别定义为int类型的red，green，blue
            //MyColor newColor;
            //newColor._red = 255;
            //newColor._green = 0;
            //newColor._blue = 0;

            //练习2：定义1个结构类型Person，有三个成员，分别为姓名，性别，年龄
            //性别用枚举类型，声明两个Person类型的变量，分别表示张三 男 18岁、小兰 女 16岁
            Person zhangsan;
            zhangsan._name = "张三";
            zhangsan._gender = Gender.男;
            zhangsan._age = 18;

            Person xiaolan;
            xiaolan._name = "小兰";
            xiaolan._gender = Gender.女;
            xiaolan._age = 16;

            Console.WriteLine("我叫{0}，性别{2}，今年{1}岁了", zhangsan._name, zhangsan._age, zhangsan._gender);
            Console.WriteLine("我叫{0}，性别{2}，今年{1}岁了", xiaolan._name, xiaolan._age, xiaolan._gender);
            Console.ReadKey();

        }
    }
}
