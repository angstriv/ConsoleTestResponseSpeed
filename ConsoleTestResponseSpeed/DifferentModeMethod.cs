using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestResponseSpeed
{
    internal static class DifferentModeMethod
    {
        /// <summary>
        /// 执行简单用户输入模式
        /// </summary>
        public static void ExecuteEasy()
        {
            while (true)
            {
                string answerStr = RandomString.GetStrsRandom(1, 1);
                Console.WriteLine(answerStr);//输出需要打的字符

                string inputStr = Console.ReadLine();//用户输入

                //判断是否正确
                if (inputStr == answerStr)
                {
                    Console.WriteLine("正确！");
                }
                else
                {
                    Console.WriteLine("错误！");
                }
            }
        }


        /// <summary>
        /// 执行中等用户输入模式
        /// </summary>
        public static void ExecuteMedium()
        {
            while (true)
            {
                string answerStr = RandomString.GetStrsRandom(1, 10);
                Console.WriteLine(answerStr);//输出需要打的字符

                string inputStr = Console.ReadLine();//用户输入

                //判断是否正确
                if (inputStr == answerStr)
                {
                    Console.WriteLine("正确！");
                }
                else
                {
                    Console.WriteLine("错误！");
                }
            }
        }


        /// <summary>
        /// 执行困难用户输入模式
        /// </summary>
        public static void ExecuteDifficult()
        {
            while (true)
            {
                string answerStr = RandomString.GetStrsRandom(1, 30);
                Console.WriteLine(answerStr);//输出需要打的字符

                string inputStr = Console.ReadLine();//用户输入

                //判断是否正确
                if (inputStr == answerStr)
                {
                    Console.WriteLine("正确！");
                }
                else
                {
                    Console.WriteLine("错误！");
                }
            }
        }


    }
}
