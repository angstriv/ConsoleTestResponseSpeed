using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestResponseSpeed
{
    internal static class AsciiAndString
    {
        
        //字符串转ASCII
        public static byte[] StrToASCII(String xmlStr)
        {
            return Encoding.Default.GetBytes(xmlStr);
        }


        //ASCII转字符串
        public static string AsciiToStr(byte[] buf)
        {
            return System.Text.Encoding.ASCII.GetString(buf);
        }
    }
}
