namespace Coriander.Questions.Bit_Manipulation;

/*
 * You are given two 32-bit numbers, N and M, and two bit positions, i and j.
 * Write a method to insert M into N such that M starts at bit j and ends at bit i.
 * You can assume that bits j through i have enough space to fit all of M.
 * That is, if M = 10011, you can assume that there are at least 5 bits between j and i.
 *
 * EXAMPLE
 * INPUT : N = 10000000000, M = 10011, i = 2, j = 6
 * OUTPUT: N = 10001001100 ( 1000 _ 10011 _ 00 )
 */


public class practice_1
{
    public long Insert(long N, long M, int i, int j)
    {
        return N;
    }

    public static void Test()
    {
        var q = new practice_1();
        Console.WriteLine("");
        var result = q.Insert(10000000000, 10011, 2, 6);
        Console.WriteLine("Output: " + result);
        Console.WriteLine("Insert(10000000000,10011,2,6) == 10001001100 : " + (result == 10001001100));
    }
     
}