using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkingMachine
{
    public class HexStringTenByte
    {


        /// <summary>
        /// HEX转为byte数组
        /// </summary>
        /// <param name="hexstr"></param>
        /// <returns></returns>
        public static byte[] HexString2Bytes(string hexstr)
        {
            string[] str = hexstr.Split(' ');
            string strhex = "";
            for (int i = 0; i <= str.Length - 1; i++)
            {
                strhex += str[i];
            }
            int n = strhex.Length / 2;
            byte[] b = new byte[n];
            for (int i = 0; i <= b.Length - 1; i++)
            {
                if (str[i] == "")
                {
                    b[i] = 0;
                }
                else
                {
                    b[i] = Convert.ToByte(str[i], 16);
                }
            }
            return b;
        }

        /// <summary>
        /// 字节数组转为十六进制字符串  
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ByteArrayToHexString(byte[] data)
        {

            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
            {
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            }
            return sb.ToString().ToUpper();
        }

        /// <summary>
        /// byte转化为string字符
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string byteTostring(byte[] by)
        {
            string str = System.Text.Encoding.UTF8.GetString(by);
            return str;
        }

        /// <summary>
        ///一位，二位 十六进制转换到十进制
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static string Hex2Ten(string hex)
        {
            int ten = 0;
            for (int i = 0, j = hex.Length - 1; i < hex.Length; i++)
            {
                ten += HexChar2Value(hex.Substring(i, 1)) * ((int)Math.Pow(16, j));
                j--;
            }
            return ten.ToString();
        }

        public static int HexChar2Value(string hexChar)
        {
            switch (hexChar)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    return Convert.ToInt32(hexChar);
                case "a":
                case "A":
                    return 10;
                case "b":
                case "B":
                    return 11;
                case "c":
                case "C":
                    return 12;
                case "d":
                case "D":
                    return 13;
                case "e":
                case "E":
                    return 14;
                case "f":
                case "F":
                    return 15;
                default:
                    return 0;
            }
        }
        /// <summary>
        /// 4位 十六进制转换到十进制
        /// </summary>
        /// <param name="Hexstr"></param>
        /// <returns></returns>
        public static string Hex4Ten(string Hexstr)
        {
            string[] split = Hexstr.Split(' ');
            int[] Ten = new int[4];
            Ten[0] = Convert.ToInt32(Hex2Ten(split[0]));
            Ten[1] = Convert.ToInt32(Hex2Ten(split[1]));
            Ten[2] = Convert.ToInt32(Hex2Ten(split[2]));
            Ten[3] = Convert.ToInt32(Hex2Ten(split[3]));
            return (Ten[0] * Math.Pow(256, 3) + Ten[1] * Math.Pow(256, 2) + Ten[2] * Math.Pow(256, 1) + Ten[3]).ToString();
        }


        /// <summary>
        /// 从十进制转换到十六进制
        /// </summary>
        /// <param name="ten"></param>
        /// <returns></returns>
        public static string Ten2Hex(string ten)
        {
            ulong tenValue = Convert.ToUInt64(ten);
            ulong divValue, resValue;
            string hex = "";
            do
            {
                //divValue = (ulong)Math.Floor(tenValue / 16);

                divValue = (ulong)Math.Floor((decimal)(tenValue / 16));

                resValue = tenValue % 16;
                hex = tenValue2Char(resValue) + hex;
                tenValue = divValue;
            }
            while (tenValue >= 16);
            if (tenValue != 0)
                hex = tenValue2Char(tenValue) + hex;
            return hex;
        }

        public static string tenValue2Char(ulong ten)
        {
            switch (ten)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    return ten.ToString();
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
                default:
                    return "";
            }
        }


    }
}
