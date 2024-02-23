using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestResponseSpeed
{
    internal static class RandomString
    {
        /// <summary>
        /// 获取一个随机字符(string)
        /// </summary>
        /// <param name="start">起始ascii</param>
        /// <param name="end">结束ascii</param>
        /// <returns></returns>
        public static string GetOneStrRandom(int start,int end)
        {
            byte ascii = (byte)RandomNumber.GetIntRandom(start, end);//随机ascii
            byte[] asciiArray = new byte[] {ascii};

            string result = AsciiAndString.AsciiToStr(asciiArray);//由ascii数组获取字符
            return result;
        }

        /// <summary>
        /// 获取随机字符串
        /// </summary>
        /// <param name="minVaule">最小长度</param>
        /// <param name="maxVaule">最大长度</param>
        /// <returns></returns>
        public static string GetStrsRandom(int minVaule,int maxVaule)
        {
            int strsLength = RandomNumber.GetIntRandom(minVaule, maxVaule);//获取随机长度
            string strs = "";

            //单个字符拼接成字符串
            for(int i = 0; i < strsLength; i++)
            {
                string oneStr = GetOneStrRandom(33, 126);//获取单个随机字符
                strs += oneStr;
            }

            return strs;
        }
    }
}
