using System;
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
            Console.ReadLine();
        }

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
