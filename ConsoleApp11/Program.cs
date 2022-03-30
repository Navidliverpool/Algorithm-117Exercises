﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First: {0}", First(2, 2));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Second: {0}", Second(53));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Third: {0}", Third(30, 0));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Forth: {0}", Forth(211));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Fifth: {0}", Fifth("else"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Fifth2: {0}", Fifth2("else"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Sixth: {0}", Sixth("Python", 1));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Seventh: {0}", Seventh("abcd"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Eighth: {0}", Eighth("JS"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Eighth2: {0}", Eighth2("js"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ninth: {0}", Ninth("1"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ninth2: {0}", Ninth2("1"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Tenth: {0}", Tenth(14));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Tenth2: {0}", Tenth2(11));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Eleventh: {0}", Eleventh("Python"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Twelfth: {0}", Twelfth("C#Python"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Twelfth2: {0}", Twelfth2("C# Python"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Thirteen: {0}", Thirteen(120, -1));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Fourteenth: {0}", Fourteenth(100, 199));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Fifteenth2: {0}", Fifteenth2(11, 20, 62));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Sixteenth: {0}", Sixteenth(11, 19));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Seventeenth: {0}", Seventeenth("Python"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Seventeenth2: {0}", Seventeenth2("Python"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Eighteenth: {0}", Eighteenth(1,2,3));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ninteenth: {0}", Ninteenth(78, 95));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ninteenth2: {0}", Ninteenth2(102, 95));
            Console.WriteLine("---------------------------");
            Console.ReadLine();
        }



        private static int Ninteenth2(int v1, int v2)
        {
            const int n = 100;
            int val = Math.Abs(v1 - n);
            int val2 = Math.Abs(v2 - n);

            return val == val2 ? 0 : (val < val2 ? v1 : v2);
        }

        //Khodam neveshtam. Darvaghe ghalate yejurai. Aadaade ballaye 100 ham ok hast estefadeh beshan. Roju shavad be Ninteenth2 baraye javabe sahih.
        private static int Ninteenth(int v1, int v2)
        {
            if ((v1 > 0 & v1 < 100) & (v2 > 0 & v2 < 100))
            {
                if (v1 > v2)
                    return v1;
                if (v2 > v1)
                    return v2;
                if (v1 == v2)
                    return 0;
            }
            return 0;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam
        private static int Eighteenth(int v1, int v2, int v3)
        {
            int result = Math.Max(v1, Math.Max(v2, v3));
            return result;

        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam
        private static string Seventeenth2(string s)
        {
            return s.Substring(1, 2) == "yt" ? s.Remove(1, 2) : s;
        }

        //Yejurai khodam neveshtam.
        private static string Seventeenth(string s)
        {
            string newS = "";
            if (s.Substring(1, 2) == "yt")
                newS = s.Remove(1, 2);
            else
                return s;
            return newS;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam
        private static bool Sixteenth(int x, int y)
        {
            return (x <= 20 || y >= 50) || (y <= 20 || x >= 50);
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam
        private static bool Fifteenth2(int v1, int v2, int v3)
        {
            return (v1 >= 20 & v1 <= 50) || (v2 >= 20 & v2 <= 50) || (v3 >= 20 & v3 <= 50);
        }

        //Khodam neveshtam
        //private static bool Fifteenth(int v1, int v2, int v3)
        //{
              //Ghalate. Kar nemikone. return baadesh tu hamun khat == ba false gharar bedam kar nemikone.
        //    return (v1 < 20 || v1 > 50) || (v2 < 20 || v2 > 50) || (v3 < 20 || v3 > 50) == false;
        //}

        //Khodam neveshtam
        private static bool Fourteenth(int n1, int n2)
        {
            return (n1 >= 100 & n2 <= 200) || (n2 >= 100 & n1 <= 200);
        }

        //Khodam neveshtam
        private static bool Thirteen(int n1, int n2)
        {
            return (n1 > 0 & n2 > 0) == false;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam
        private static bool Twelfth2(string s)
        {
            return (s.Length < 3 & s == "C#") || (s.Substring(0, 2) == "C#" & s[2] == ' ');
        }

        //Khodam neveshtam
        private static bool Twelfth(string s)
        {
            if (s.StartsWith("C#"))
                return true;
            return false;
        }

        //Khodam neveshtam baa search kardan
        private static string Eleventh(string s)
        {
            if (s.Length < 3)
                return s + s + s;
            else
            {
                string newS = s.Substring(0, 3);
                return newS + s + newS;
            }            
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam
        private static bool Tenth2(int n)
        {
            return n % 3 == 0 || n % 7 == 0;
        }

        //Khodam neveshtam
        private static bool Tenth(int n)
        {
            if(n % 3 == 0 || n % 7 == 0 & n >= 0)
                return true;
            return false;

        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam
        private static string Ninth2(string s)
        {
            string newS = s.Substring(s.Length - 1);
            return newS + s + newS;
        }

        //Khodam neveshtam
        private static string Ninth(string s)
        {
            string newS = "";
            return newS = s[s.Length - 1] + s + s[s.Length - 1];
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam
        private static string Eighth2(string s)
        {
            return s.Length < 2 ? s : s.Substring(0, 2) + s.Substring(0, 2) + s.Substring(0, 2) + s.Substring(0, 2);
        }

        //Khodam neveshtam baa search kardan
        private static string Eighth(string s)
        {
            string newSs = "";
            if(s.Length <= 2)
            {
                newSs = s + s + s + s;
                return newSs;
            }

            return  s[0].ToString() + s[1].ToString() + s[0].ToString() + s[1].ToString() +
                   s[0].ToString() + s[1].ToString() + s[0].ToString() + s[1].ToString();
        }

        //Khodam neveshtam baa search kardan
        private static string Seventh(string s)
        {
            string newS = " ";
            char[] chr = s.ToCharArray();
            char temp = chr[0];
            chr[0] = chr[chr.Length - 1];
            chr[chr.Length - 1] = temp;
            return new string(chr);
        }

        //Khodam neveshtam
        private static string Sixth(string s, int i)
        {
            char[] chr = s.ToCharArray();
            string newS = " ";
            string iToStr = chr[i].ToString();
            newS = s.Replace(iToStr, string.Empty);
            return newS;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam
        private static string Fifth2(string s)
        {
            if (s.Length > 2 & s.Substring(0, 2) == "if")
                return s;

            return "if " + s;
        }

        //Khodam neveshtam
        private static string Fifth(string s)
        {
            string newS = " ";
            if (s.StartsWith("if"))
                return s;

            newS = "if " + s;
            return newS;
        }

        //Khodam neveshtam
        private static bool Forth(int n)
        {
            if(n - 100 >= 0)
            {
                if ((n - 100) <= 10 || (n - 200) <= 10)
                    return true;
            }

            if((n - 100) < 0)
            {
                if ((n - 100) >= -10 || (n - 200) <= -10)
                    return true;
            }

            return false;
        }

        //Khodam neveshtam
        private static bool Third(int n1, int n2)
        {
            if (n1 == 30 || n1 + n2 == 30)
                return true;
            else
                return false;
        }

        //Khodam neveshtam
        private static int Second(int n)
        {
            int result = 0;
            if (n - 51 >= 0)
            {
                result = (n - 51) * 3;
            }
            return result;
        }

        //Khodam neveshtam
        private static int First(int num1, int num2)
        {
            int result;
            if (num1 == num2)
                return result = (num1 + num2) * 3;
            else
                return result = num1 + num2;
        }
    }
}
