using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P70数组的练习3
{
    class Program
    {
        static void Main(string[] args)
        {
            //将一个整数数组的每一个元素进行如下的处理：
            //如果元素是正数，则将这个位置的元素的值加1
            //如果元素是负数，则将这个位置的元素的值减1
            //如果是0，则不变
            int[] nums = { 1, 3, -3, -6, 9, -7, 0, 23, 6 };
            string saveNums = null;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    nums[i] += 1;
                }
                else if (nums[i] < 0)
                {
                    nums[i] -= 1;
                }
                else
                {

                }
                saveNums += nums[i]+" ";
            }
            Console.WriteLine(saveNums);
            Console.ReadKey();
        }
    }
}
