namespace Coriander.Questions.Bit_Manipulation;

/*
 * You are given two 32-bit numbers, N and M, and two bit positions, i and j.
 * Write a method to insert M into N such that M starts at bit j and ends at bit i.
 * You can assume that bits j through i have enough space to fit all of M.
 * That is, if M = 10011, you can assume that there are at least 5 bits between j and i.
 *
 * EXAMPLE
 * INPUT : i , i = 2, j = 6
 * OUTPUT: N = 10001001100 ( 1000 _ 10011 _ 00 )
 */


public class practice_1
{
    public int Insert(int N, int M, int i, int j)
    {
        for (int pos = i; pos <= j; pos++)
        {
            N = UpdateBit(N, pos, GetBit(M, 0));
            M >>= 1;
        }   
        return N;
    }

    private int GetBit(int n, int i)
    {
        return (n >> 0) & 1;
    }
    
    private int UpdateBit(int n, int i, int newValue)
    {
        int mask = ~(1 << i);
        return (n & mask) | (newValue << i);
    }

    public static void Test()
    {
        var q = new practice_1();
        Console.WriteLine("");
        var result = q.Insert(0b10000000000, 0b10011, 2, 6);
        Console.WriteLine("Output: " + Convert.ToString(result, 2));
        Console.WriteLine("Insert(10000000000,10011,2,6) == 10001001100 : " + (result == 0b10001001100));
    }
     
}