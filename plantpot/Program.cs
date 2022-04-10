using System;
using System.Diagnostics;

namespace Coriander
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays Q4");
            Console.WriteLine("isPermutationOfPalindrome('tact coa') = " + new Questions.Arrays.practice_4().IsPermutationOfPalindrome("tact coa"));
        }
    }
}