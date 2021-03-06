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
            int[] ArrNumForThirtyFirst = { 1, 1, 2, 3, 1 };
            int[] ArrNumForThirtyFifth = { 5, 5, 2, 5, 5 };
            int[] ArrNumForThirtySixth = { 1, 1, 2, 2, 1 };

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
            Console.WriteLine("Eighteenth: {0}", Eighteenth(1, 2, 3));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ninteenth: {0}", Ninteenth(78, 95));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ninteenth2: {0}", Ninteenth2(102, 95));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Twentieth: {0}", Twentieth(78, 95));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Twentieth2: {0}", Twentieth2(40, 42));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentyFirst: {0}", TwentyFirst(21, 25));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentyFirst2: {0}", TwentyFirst2(21, 25));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentySecond: {0}", TwentySecond("fizz"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentyThird: {0}", TwentyThird(123, 453));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentyThird2: {0}", TwentyThird2(123, 453));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentyFourth: {0}", TwentyFourth("JS", 3));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentyFourth2: {0}", TwentyFourth2("JS", 3));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentyFifth: {0}", TwentyFifth("Python", 2));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentyFifth2: {0}", TwentyFifth2("Python", 2));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentyFifth2Practice: {0}", TwentyFifth2Practice("Python", 2));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentySixth: {0}", TwentySixth("bbaaacaag"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentySixth2: {0}", TwentySixth2("bbaaacaag"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentySeventh: {0}", TwentySeventh("bbaaacaag"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentySeventh2: {0}", TwentySeventh2("bbaaacaag"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentyEighth: {0}", TwentyEighth("Python"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentyEighth2: {0}", TwentyEighth2("Python"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentyNinth: {0}", TwentyNinth("abcd"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("TwentyNinth2: {0}", TwentyNinth2("abcd"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Thirty: {0}", Thirty("abcdsab"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Thirty2: {0}", Thirty2("abcdsab"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("ThirtyFirst: {0}", ThirtyFirst(ArrNumForThirtyFirst));
            Console.WriteLine("---------------------------");
            Console.WriteLine("ThirtySecond: {0}", ThirtySecond("abcdefgh", "abijsklm"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("ThirtySecond2: {0}", ThirtySecond2("abcdefgh", "abijsklm"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("ThirtyThird: {0}", ThirtyThird("xxHxix", 'x'));
            Console.WriteLine("---------------------------");
            Console.WriteLine("ThirtyThird2: {0}", ThirtyThird2("xxHxix", "x"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("ThirtyFourth: {0}", ThirtyFourth("JavaScript"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("ThirtyFourth2: {0}", ThirtyFourth2("JavaScript"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("ThirtyFifth: {0}", ThirtyFifth(ArrNumForThirtyFifth));
            Console.WriteLine("---------------------------");
            Console.WriteLine("ThirtyFifth2: {0}", ThirtyFifth2(ArrNumForThirtyFifth, ArrNumForThirtyFifth.Length));
            Console.WriteLine("---------------------------");
            Console.WriteLine("QuestionFromMe_SimularToThistySixth: {0}", QuestionFromMe_SimularToThistySixth(ArrNumForThirtySixth));
            Console.WriteLine("---------------------------");
            Console.WriteLine("ThirtySixth: {0}", ThistySixth(ArrNumForThirtySixth));
            Console.WriteLine("---------------------------");
            Console.WriteLine("ThirtySixth2: {0}", ThistySixth2(ArrNumForThirtySixth, ArrNumForThirtySixth.Length));
            Console.WriteLine("---------------------------");
            Console.WriteLine("ThistySeventh: {0}", ThistySeventh(12, 17));
            Console.WriteLine("---------------------------");
            Console.WriteLine("ThistySeventh2: {0}", ThistySeventh2(12, 17));
            Console.WriteLine("---------------------------");
            Console.WriteLine("ThistyEighth: {0}", ThistyEighth(5, 4));
            Console.WriteLine("---------------------------");
            Console.WriteLine("ThistyNinth: {0}", ThistyNinth(14));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Fourty: {0}", Fourty(21));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FourtyP: {0}", Fourty2(3));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FourtyFirst: {0}", FourtyFirst2(8));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FourtySecond: {0}", FourtySecond(8, 12));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FourtyThird: {0}", FourtyThird("FizzBuzz"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FourtyThird2: {0}", FourtyThird2("FizzBuzz"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FourtyFourth: {0}", FourtyFourth(1, 2, 3));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FourtyFourth2: {0}", FourtyFourth2(-1, 1, 0));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FourtyFifth: {0}", FourtyFifth(1, 2, 3));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FourtyFifth2: {0}", FourtyFifth2(1, 2, 3));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FourtySixth2: {0}", FourtySixth2(1, 2, 3, true));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FourtySeventh2: {0}", FourtySeventh2(11, 21, 31));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FourtyEighth: {0}", FourtyEighth(1, 20, 35));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FourtyEighth2: {0}", FourtyEighth2(1, 20, 35));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FourtyNinth: {0}", FourtyNinth(11, 21));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FourtyNinth2: {0}", FourtyNinth2(11, 21));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Fifty: {0}", Fifty(13, 33));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Fifty2: {0}", Fifty2(13, 33));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftyFirst: {0}", FiftyFirst(13, 33));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftyFirst2: {0}", FiftyFirst2(13, 33));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftySecond: {0}", FiftySecond(5, 5, 7));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftySecond2: {0}", FiftySecond2(5, 5, 7));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftyThird: {0}", FiftyThird(5, 5, 13));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftyThird2: {0}", FiftyThird2(5, 5, 13));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftyFourth: {0}", FiftyFourth(5, 5, 13));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftyFourth2: {0}", FiftyFourth2(5, 5, 11));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftyFifth: {0}", FiftyFifth(10, 11));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftyFifth2: {0}", FiftyFifth2(10, 11));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftySixth: {0}", FiftySixth(10, 11, 12));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftySixth2: {0}", FiftySixth2(10, 11, 12));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftySeventh: {0}", FiftySeventh("salam", "chetory"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftySeventh2: {0}", FiftySeventh2("salam", "chetory"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftyEighth: {0}", FiftyEighth("[[]]", "chetory"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftyEighth2: {0}", FiftyEighth2("[[]]", "chetory"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftyNinth: {0}", FiftyNinth("chetory"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("FiftyNinth2: {0}", FiftyNinth2("chetory"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Sixty: {0}", Sixty("chetory"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Sixty2: {0}", Sixty2("chetory"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SixtyFirst: {0}", SixtyFirst("Hello"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SixtyFirst2: {0}", SixtyFirst2("Hello"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SixtySecond: {0}", SixtySecond("Hello"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SixtySecond2: {0}", SixtySecond2("Hello"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SixtyThird: {0}", SixtyThird("Hell", "Hello"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SixtyThird2: {0}", SixtyThird2("Hell", "Hello"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SixtyFourth: {0}", SixtyFourth2("Hell", "Hello"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SixtyFifth: {0}", SixtyFifth("Hello"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SixtyFifth2: {0}", SixtyFifth2("Hello"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SixtySeventh: {0}", SixtySeventh("Hell"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SixtyEighth: {0}", SixtyEighth("Hello", 2));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SixtyEighth2: {0}", SixtyEighth2("Hello", 2));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SixtyNinth2: {0}", SixtyNinth2("Hello", 2));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Seventy: {0}", Seventy("Hello"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SeventyFirst: {0}", SeventyFirst("Hello"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SeventySecond: {0}", SeventySecond("Hello", "Hi"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SeventySecond2: {0}", SeventySecond2("Hello", "Hi"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SeventyThird2: {0}", SeventyThird2("Hello"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SeventyForth: {0}", SeventyForth("abcabc"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SeventyFifth: {0}", SeventyFifth("abca"));
            Console.WriteLine("---------------------------");
            Console.WriteLine("SeventyFifth2: {0}", SeventyFifth2("abca"));
            Console.WriteLine("---------------------------");

            Console.ReadLine();
        }


        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static bool SeventyFifth2(string s)
        {
            return s.Substring(0, 2) == s.Substring(s.Length - 2);
        }

        //Khodam neveshtam.
        private static bool SeventyFifth(string s)
        {
            return s.Substring(0, 2) == s.Substring(s.Length - 2, 2) ? true : false;
        }

        //Khodam neveshtam.
        private static string SeventyForth(string s)
        {
            return s.StartsWith("xyz") || s.StartsWith("abc") ? "abc" : " ";
        }

        private static string SeventyThird2(string s)
        {
            return s.Substring(0, s.Length - 2) + s[s.Length - 1] + s[s.Length - 2];
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string SeventySecond2(string x, string y)
        {
            string lastChars = "";

            if (x.Length > 0)
            {
                lastChars += x.Substring(0, 1);
            }
            else
            {
                lastChars += "#";
            }

            if (y.Length > 0)
            {
                lastChars += y.Substring(y.Length - 1);
            }
            else
            {
                lastChars += "#";
            }

            return lastChars;
        }

        //Khodam neveshtam.
        //Yejurai ghalat neveshtam.
        private static string SeventySecond(string x, string y)
        {
            return x.Length == 0 & y.Length == 0 ? "#" : x.Substring(0, 1) + y.Substring(y.Length - 1, 1);
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string SeventyFirst(string s)
        {
            return s.Substring((s.Length - 1) / 2 - 1, 3);
        }

        //Khodam neveshtam.
        //Vali benazar miad efficient naneveshtam.
        private static string Seventy(string s)
        {
            if ((s.Length % 2 != 0) & (s.Length / 2) - 1 + 3 <= s.Length)
                return s.Substring((s.Length / 2) - 1, 3);

            else if ((s.Length % 2 == 0) & (s.Length / 2) - 1 + 3 <= s.Length)
                return s.Substring((s.Length / 2), 3);
            return s.Substring((s.Length / 2), 3);
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string SixtyNinth2(string s1, int index)
        {
            return index + 2 <= s1.Length ? s1.Substring(index, 2) : s1.Substring(0, 2);
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string SixtyEighth2(string s, int n)
        {
            return s.Substring(0, n) + s.Substring(s.Length - n);

        }

        //Khodam neveshtam.
        private static string SixtyEighth(string s, int x)
        {

            return s.Substring(0, x) + s.Substring(s.Length - x, x);
        }

        //Khodam neveshtam.
        private static string SixtySeventh(string s)
        {
            return s.Length > 2 & s.Length % 2 == 0 ? s.Substring(s.Length / 2 - 1, 2) : s;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string SixtyFifth2(string s1)
        {
            string s2 = s1;
            return s1.Remove(0, 2) + s2.Substring(0, 2);
        }

        //Khodam neveshtam.
        private static string SixtyFifth(string s)
        {
            string newS = s.Substring(0, 2);
            return s.Length > 2 ? s.Substring(2) + newS : s;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string SixtyFourth2(string s1, string s2)
        {
            return s1.Substring(1) + s2.Substring(1);
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string SixtyThird2(string s1, string s2)
        {
            return s1.Length > s2.Length ? s1 + s2 + s1 : s2 + s1 + s2;
        }

        //Khodam neveshtam.
        private static string SixtyThird(string s1, string s2)
        {
            return s1.Length > s2.Length ? s1 + s2 + s1 : s2 + s1 + s2;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string SixtySecond2(string s1)
        {

            return s1.Substring(1).Substring(0, s1.Length - 2);
        }

        //Khodam neveshtam.
        private static string SixtySecond(string s)
        {
            return s.Length < 2 ? s : s.Substring(1, s.Length - 2);
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string SixtyFirst2(string s)
        {
            return s.Substring(0, s.Length / 2);
        }

        //Khodam neveshtam.
        private static string SixtyFirst(string s)
        {
            return s.Substring(0, s.Length / 2);
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string Sixty2(string s1)
        {
            return s1.Length < 2 ? s1 : s1.Substring(0, 2);
        }

        //Khodam neveshtam.
        private static string Sixty(string s)
        {
            string newS = s.Substring(0, 2);
            return newS.Length >= 2 ? newS : s;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string FiftyNinth2(string s1)
        {
            string last2 = s1.Substring(s1.Length - 2);
            return last2 + last2 + last2;
        }

        //Khodam neveshtam.
        private static string FiftyNinth(string s)
        {
            string newS = "";
            int n = 1;
            while(n <= 3)
            {
                newS += s.Substring(s.Length - 2, 2);
                n++;
            }
            return newS;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string FiftyEighth2(string s1, string word)
        {
            return s1.Substring(0, 2) + word + s1.Substring(2);
        }

        //Khodam neveshtam.
        private static string FiftyEighth(string s1, string s2)
        {
            int middle = (s1.Length / 2) - 1;
            string newS = "";
            if(s1.Length == 4)
            {
                for(int i = 0; i < s1.Length; i++)
                {
                    newS += s1[i];
                    if (i == middle)
                        newS += s2;
                }
            }
            return newS;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string FiftySeventh2(string s1, string s2)
        {
            return s1 + s2 + s2 + s1;
        }

        //Khodam neveshtam.
        private static string FiftySeventh(string s1, string s2)
        {
            string newS = "";
            return newS = s1 + s2 + s2 + s1;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static bool FiftySixth2(int x, int y, int z)
        {
            if (x > y && x > z && y > z) return x - y == y - z;
            if (x > y && x > z && z > y) return x - z == z - y;
            if (y > x && y > z && x > z) return y - x == x - z;
            if (y > x && y > z && z > x) return y - z == z - x;
            if (z > x && z > y && x > y) return z - x == x - y;
            return z - y == y - x;
        }

        //Khodam neveshtam.
        private static bool FiftySixth(int x, int y, int z)
        {
            return (z - y) == (y - x) ? true : false;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static int FiftyFifth2(int x, int y)
        {
            if (x > 13 && y > 13) return 0;
            if (x <= 13 && y > 13) return x;
            if (y <= 13 && x > 13) return y;
            return x > y ? x : y;
        }

        //Khodam neveshtam.
        private static int FiftyFifth(int x, int y)
        {
            if (x > 13 & y > 13)
                return 0;
            return (x > y & x < 13) ? x : y;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static int FiftyFourth2(int x, int y, int z)
        {
            return FiftyFourth2Engine(x) + FiftyFourth2Engine(y) + FiftyFourth2Engine(z);
        }

        private static int FiftyFourth2Engine(int n)
        {
            return (n >= 10 & n <= 13 || n >= 17 & n <= 20) ? 0: n;
        }

        //Khodam neveshtam.
        //Yezare moshkel dare vali eshkalatesh mohem nist.
        private static int FiftyFourth(int x, int y, int z)
        {
            if(x >= 10 & x <= 20)
            {
                x = 0;
            }
            if(y >= 10 & y <= 20)
            {
                y = 0;
            }
            if(z >= 10 & z <= 20)
            {
                z = 0;
            }
            return x + y + z;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static int FiftyThird2(int x, int y, int z)
        {
            if (x == 13) return 0;
            if (y == 13) return x;
            if (z == 13) return x + y;
            return x + y + z;
        }

        //Khodam neveshtam.
        //I have modified this question a bit.
        //Qustion: Write a C# program to compute the sum of the three integers.
        //If one of the values is 13 (x is 13 return 0) return the sum of the numbers before reaching the number 13.
        private static int FiftyThird(int x, int y, int z)
        {
            int[] arr = { x, y, z };
            int container = 0;
            if (arr[0] == 13)
                return 0;
            if (x != 13 & y != 13 & z != 13)
                return x + y + z;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == 13)
                    for (int j = 0; j < i; j++)
                    {
                        container += arr[j];
                    }
            }
            return container;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static int FiftySecond2(int x, int y, int z)
        {
            if (x == y && y == z) return 0;
            if (x == y) return z;
            if (x == z) return y;
            if (y == z) return x;
            return x + y + z;
        }

        //Khodam neveshtam.
        //Vali oon chizi nist ke soal mikhad.
        private static int FiftySecond(int x, int y, int z)
        {
            return x == y ? (x + y + z) : z;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static int FiftyFirst2(int x, int y)
        {
            return (x + y).ToString().Length > x.ToString().Length ? x : x + y;

        }

        //Khodam neveshtam.
        private static int FiftyFirst(int x, int y)
        {
            int sum = x + y;
            if (sum.ToString().Length == x.ToString().Length)
                return sum;
            return x;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static bool Fifty2(int x, int y)
        {
            return x / 10 == y / 10 || x / 10 == y % 10 || x % 10 == y / 10 || x % 10 == y % 10;
        }

        //Khodam neveshtam.
        private static bool Fifty(int n1, int n2)
        {
            if(n1 >= 10 & n1 <= 99 & n2 >= 10 & n2 <= 99)
            {
                for(int i = 0; i < n1.ToString().Length; i++)
                {
                    for (int j = 0; j < n1.ToString().Length; j++)
                    {
                        if (n1.ToString()[i] == n2.ToString()[j])
                            return true;
                    }
                }
            }
            return false;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static int FourtyNinth2(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }
            else if ((x % 7 == y % 7 && x < y) || x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        //Khodam neveshtam.
        //Ba taghalob as website fixesh kardam.
        private static int FourtyNinth(int n1, int n2)
        {
            if (n1 == n2)
                return 0;
            if (n1 % 7 == n2 % 7 & n1 < n2 || n1 > n2)
                return n1;
            return n2;
        }

        //The question is not clear to me.
        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static bool FourtyEighth2(int x, int y, int z)
        {
            return Math.Abs(x - y) >= 20 || Math.Abs(x - z) >= 20 ||
                               Math.Abs(y - z) >= 20;
        }

        //Khodam neveshtam.
        //Keili ba ini ke neveshtam haal nemikonam vali hade aghal tu in mesal kar ro dare anjam mide.
        private static bool FourtyEighth(int n1, int n2, int n3)
        {
            int[] arr = {n1, n2, n3};
            int container = 0;
            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] >= 20 & arr[i] <= 25)
                {
                    container = arr[i];
                    arr[i] = arr[i + 1];
                    for(int j = 0; j < arr.Length - 1; j++)
                    {
                        if (arr[j] > container) return true;
                    }
                    return false;
                }
            }
            return false;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static bool FourtySeventh2(int x, int y, int z)
        {
            return x % 10 == y % 10 || x % 10 == z % 10 || y % 10 == z % 10;
        }

        //I found skipping this quesiton would save me time as I do not understand the math part. 
        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static bool FourtySixth2(int x, int y, int z, bool flag)
        {
            return flag ? x <= y && y <= z : x < y && y < z;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static bool FourtyFifth2 (int x, int y, int z)
        {
            return x < y && y < z;
        }

        //Khodam neveshtam.
        private static bool FourtyFifth(int x, int y, int z)
        {
            return y > x & z > y ? true : false;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static bool FourtyFourth2(int x, int y, int z)
        {
            return x == y + z || y == x + z || z == x + y;
        }

        //Khodam neveshtam.
        private static bool FourtyFourth(int n1, int n2, int n3)
        {
            int[] arr = { n1, n2, n3 };
            int container = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (container < arr[i])
                    container = arr[i];
            }

            if (n1 + n2 == container)
            {
                return true;
            }
            return false;
        }

        //I think this question has an Error. 
        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string FourtyThird2(string str)
        {
            if ((str.Substring(0, 1) == "F") && (str.Substring(str.Length - 1, 1) == "B"))
            {
                return "FizzBuzz";
            }
            else if (str.Substring(0, 1) == "F")
            {
                return "Fizz";
            }
            else if (str.Substring(str.Length - 1, 1) == "B")
            {
                return "Buzz";
            }
            else
            {
                return str;
            }
        }

        //Khodam neveshtam. Ba komak.
        private static string FourtyThird(string s)
        {
            string b = "B";

            for(int i = 1; i < s.Length; i++)
            {
                if (s.StartsWith('F'.ToString()) & s.Substring(i, 1) == "B")
                    return "FizzBuzz";
            }
            if (s.StartsWith('B'.ToString()))
                return "Buzz";
            if (s.StartsWith('F'.ToString()))
                return "Fizz";
            return s;
        }

        //Khodam neveshtam
        private static int FourtySecond(int n1, int n2)
        {
            return (n1 >= 10 & n1 <= 20) || (n2 >= 10 & n2 <= 20) ? 18 : n1 + n2;
        }

        //I do not understand this question.
        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static bool FourtyFirst2(int n)
        {
            return n % 10 <= 2 || n % 10 >= 8;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static bool Fourty2(int n)
        {
            //(^) is called XOR and acts exactly same as XOR Gate in Logic Circuit.
            return Math.Abs(n) % 3 == 0 ^ Math.Abs(n) % 7 == 0;
        }

        //Khodam neveshtam
        private static bool Fourty(int n)
        {
            if(Math.Abs(n) % 3 == 0 || Math.Abs(n) % 7 == 0)
            {
                if (Math.Abs(n) % 3 == 0 & Math.Abs(n) % 7 == 0)
                    return false;
                return true;
            }
            return false;
        }

        //Khodam neveshtam
        private static bool ThistyNinth(int n)
        {
            return Math.Abs(n) % 13 == 0 || Math.Abs(n) % 13 == 1 ? true : false;
        }

        //Khodam neveshtam
        private static bool ThistyEighth(int n1, int n2)
        {
            return n1 == 5 || n2 == 5 || n1 + n2 == 5 || Math.Abs(n1 - n2) == 5 ? true : false;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static int ThistySeventh2(int a, int b)
        {
            return a + b >= 10 && a + b <= 20 ? 30 : a + b;
        }

        //Khodam neveshtam
        private static int ThistySeventh(int n1, int n2)
        {
            int sum = n1 + n2;
            if (sum >= 10 & sum <= 20)
                return 30;
            else
                return sum;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static bool ThistySixth2(int[] nums, int arr_length)
        {
            int arra_len = arr_length - 1;
            int n = 0;
            for (int i = 0; i < arra_len; i++)
            {
                n = nums[i];
                if (n == nums[i + 1] && n == nums[i + 2]) 
                    return true;
            }
            return false;
        }

        //Khodam neveshtam
        //This mothod does not work so I commented out. I do not remove this code because later I may find a developer and get help with it.
        private static bool ThistySixth(int[] n)
        {

            //for (int i = 0; i < n.Length - 1; i++)
            //{
            //    if (n[i].ToString().Substring(i, 3) == n[i].ToString())
            //        return true;
            //}
            //    return false;
            return false;
        }

        //Khodam neveshtam
        //Question:  Write a C# program to check if a number either in order or not appears three time in an array of integers or not.
        private static bool QuestionFromMe_SimularToThistySixth(int[] n)
        {
            int indexZero = n[0];
            int counter = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == indexZero)
                    counter++;
                if (counter == 3)
                    return true;
            }

            return false;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static int ThirtyFifth2(int[] numbers, int arr_length)
        {
            int ctr = 0;
            for (int i = 0; i < arr_length - 1; i++)
            {
                if ((numbers[i] == 5 && (numbers[i + 1] == 5)) || (numbers[i] == 5 && (numbers[i + 1] == 6))) ctr++;
            }
            return ctr;
        }

        //Khodam neveshtam
        private static int ThirtyFifth(int[] nArr)
        {
            int counter = 0;

            for (int i = 0; i < nArr.Length - 1; i++)
            {
                if (nArr[i] == 5 & (nArr[i + 1] == 5 || nArr[i + 1] == 6))
                    counter++;
            }
            return counter;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string ThirtyFourth2(string str1)
        {
            string result = "";
            for (int i = 0; i < str1.Length; i += 4)
            {
                int c = i + 2;
                int n = 0;
                n += c > str1.Length ? 1 : 2;
                result += str1.Substring(i, n);
            }
            return result;
        }

        //Khodam neveshtam
        private static string ThirtyFourth(string s)
        {
            string newS = "";
            for(int i = 0; i < s.Length - 1;)
            {
                if (s.Length % 2 == 0)
                {
                    newS += s.Substring(i, 2);
                    i += 4;
                }
                else
                    return newS;
            }
            return newS;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string ThirtyThird2(string str1, string c)
        {
            for (int i = str1.Length - 2; i > 0; i--)
            {
                if (str1[i] == c[0])
                {
                    str1 = str1.Remove(i, 1);
                }
            }

            return str1;
        }

        //Khodam neveshtam
        private static string ThirtyThird(string s, char c)
        {
            string newS = "";
            int j = 0;
            foreach(char i in s)
            {
                if(j != 0 & j != s.Length)
                {
                    if (i != c)
                        newS += i;
                }
                j++;
            }
            return s[0] + newS + s[s.Length - 1];
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static int ThirtySecond2(string str1, string str2)
        {
            int ctr = 0;
            for (int i = 0; i < str1.Length - 1; i++)
            {
                string firstString = str1.Substring(i, 2);
                for (int j = 0; j < str2.Length - 1; j++)
                {
                    string secondString = str2.Substring(j, 2);
                    if (firstString == secondString)
                        ctr++;
                }
            }
            return ctr;
        }

        //Khodam neveshtam
        private static int ThirtySecond(string s1, string s2)
        {
            int counter = 0;

            for (int i = 0; i < s1.Length - 1 || i < s2.Length - 1; i++)
            {
               if (s1.Substring(i, 2) == s2.Substring(i, 2))
                    counter++;
            }

            return counter;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static bool ThirtyFirst(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == 1 && n[i + 1] == 2 && n[i + 2] == 3)
                    return true;
            }
            return false;  
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static int Thirty2(string str)
        {
            string last_two_char = str.Substring(str.Length - 2);
            int ctr = 0;

            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 2) == (last_two_char)) ctr++;
            }
            return ctr;
        }

        //Khodam neveshtam
        private static int Thirty(string s)
        {
            string newS = s.Substring(0, 2);
            int counter = 0;
            for (int i = 0; i < s.Length - 3; i++)
            {
                if (s[i] == newS[0] & s[i + 1] == newS[1])
                    counter++;
            }
            return counter;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string TwentyNinth2(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result += str.Substring(0, i + 1);
            }
            return result;
        }

        //Khodam neveshtam
        private static string TwentyNinth(string s)
        {
            string newS = "";
            int k = 1;
            while(k <= s.Length - 1)
            {
                newS += s.Substring(0, k);
                k++;
            }
            return newS + s;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static string TwentyEighth2(string s)
        {
            string result = " ";
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (i % 2 == 0) result += s[i];
            }
            return result;
        }

        //Khodam neveshtam
        private static string TwentyEighth(string s)
        {
            string newS = "";
            for(int i = 0; i < s.Length - 1; i += 2)
            {
                newS += s[i];
            }
            return newS;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static bool TwentySeventh2(string str)
        {
            int counter = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'a') counter++;
                if (str.Substring(i, 2) == "aa" && counter < 2)
                    return true;
            }
            return false;
        }

        //Khodam neveshtam
        private static bool TwentySeventh(string s)
        {
            int i = 0;
            while(i < s.Length - 1)
            {
                if (s[i] == 'a' & s[i + 1] == 'a')
                    return true;
                i++;
            }

            return false;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam.
        private static int TwentySixth2(string s)
        {
            int ctr_aa = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s.Substring(i, 2) == "aa")
                {
                    ctr_aa++;
                }
            }
            return ctr_aa;
        }

        //Khodam neveshtam
        private static int TwentySixth(string s)
        {
            int counter = 0;
            int c = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if(i != 0)
                {
                    if (s[i] == 'a' & s[i - 1] == 'a')
                    {
                        if (s[i + 1] != 'a')
                            c++;
                        else
                            counter++;
                    }
                }
            }
                return counter + c;
        }

        //TwentyFifth2Practice.
        private static string TwentyFifth2Practice(string s, int n)
        {
            string newS = "";
            int n2 = 3;
            if (s.Length < n2)
                n2 = s.Length;
            newS = s.Substring(0, 3);
            for(int i = 1; i < n; i++)
            {
                newS += newS;
            }
            return newS;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam
        private static string TwentyFifth2(string s, int n)
        {
            string result = "";
            int frontOfString = 3;

            if (frontOfString > s.Length)
                frontOfString = s.Length;

            string front = s.Substring(0, frontOfString);

            for (int i = 0; i < n; i++)
            {
                result += front;
            }
            return result;
        }

        //Khodam neveshtam. Alan ke daram be kode TwentyFifth2 negah mikonam mibinam bazi az jahaye in code moshkel dare. 
        private static string TwentyFifth(string s, int n)
        {
            string newS = "";
            if(s.Length - 1 >= n)
            {
                for (int i = 0; i <= n; i++)
                {
                    newS += s[i];
                }
            }
            
            for(int j = 1; j < n; j++)
            {
                newS += newS;
            }
            return newS;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam
        private static string TwentyFourth2(string s, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += s;
            }
            return result;
        }

        //Khodam neveshtam
        private static string TwentyFourth(string s, int v)
        {
            string newS = "";
            for(int i = 1; i <= v; i++)
            {
                newS += s;
            }
            return newS;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam
        private static bool TwentyThird2(int v1, int v2)
        {
            return Math.Abs(v1 % 10) == (v2 % 10);
        }

        //Khodam neveshtam
        private static bool TwentyThird(int v1, int v2)
        {
            char[] v1ChrArr = v1.ToString().ToCharArray();
            char[] v2ChrArr = v2.ToString().ToCharArray();
            if (v1 > 0 & v2 > 0)
            {
                if (v1ChrArr[v1ChrArr.Length - 1] == v2ChrArr[v2ChrArr.Length - 1])
                    return true;
            }
            return false;
        }

        //Khodam neveshtam. Idehye for loop neveshtan ro az StackOverFlow.com gereftam.
        private static bool TwentySecond(string s)
        {
            int a = 0;
            for(int i = 0; i <= s.Length - 1; i++)
            {
                if(s[i] == 'z')
                    a++;
            }

            return (a >= 2 & a <= 4) ? true : false;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam
        private static int TwentyFirst2(int x, int y)
        {
            if (x >= 20 && x <= 30 && y >= 20 && y <= 30)
            {
                if (x >= y)
                {
                    return x;
                }
                else
                {
                    return y;
                }
            }
            else if (x >= 20 && y <= 30)
            {
                return x;
            }
            else if (y >= 20 && y <= 30)
            {
                return y;
            }
            else
            {
                return 0;
            }
        }

        //Khodam neveshtam ba ye negahe kuchick andakhtan be "Click me to see the sample solution". Albate "Click me to see the sample solution" yejure dige neveshte.
        private static int TwentyFirst(int v1, int v2)
        {
            if((v1 >= 20 & v1 <= 30) & (v2 >= 20 & v2 <= 30))
            {
                return (v1 > v2) ? v1 : v2;
            }
            return 0;
        }

        private static bool Twentieth2(int x, int y)
        {
            return (x >= 40 && x <= 50 && y >= 40 && y <= 50) || (x >= 50 && x <= 60 && y >= 50 && y <= 60);
        }

        //Khodam neveshtam
        private static int Twentieth(int v1, int v2)
        {
            return (v1 >= 40 & v1 <= 60) & (v2 >= 40 & v2 <= 60) ? 1 : 0;
        }

        //Az "Click me to see the sample solution" tu hamin website neveshtam
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
