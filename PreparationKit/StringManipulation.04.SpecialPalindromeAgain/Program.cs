using System;
namespace StringManipulation._04.SpecialPalindromeAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = substrCount(5, "asasd");
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static long substrCount(int n, string s)
        {
            var result = 0;
            var currentString = string.Empty;
            for (int i = 0; i < n; i++)
            {
                result++;
                currentString = s[i].ToString();
                for (int j = i+1; j < n; j++)
                {
                    if (s[j] == s[i])
                    {
                        result++;
                        currentString += s[j];
                    }
                    else
                    {
                        // prevent index out of bond exception
                        if (j+ currentString.Length < n)
                        {
                            var subCompareString = s.Substring(j + 1, currentString.Length);
                            // check if All characters except the middle one are the same, e.g. aadaa.
                            if (subCompareString == currentString)
                            {
                                result++;
                            }
                        }
                        break;
                    }
                }
            }
            return result;
        }
    }
}
