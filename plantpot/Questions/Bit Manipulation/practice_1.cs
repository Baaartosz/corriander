namespace Coriander.Questions.Bit_Manipulation;

/*
 * Insertion
 * 
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
    // First Attempt
    public int Insert(int N, int M, int i, int j)
    {
        for (int pos = i; pos <= j; pos++) // O(length of inserting binary number)
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
    
    // Second Attempt 
    public int InsertV2(int N, int M, int i, int j) // O(1)
    {
        // Clear bits between i & j on N.
        // +1 because otherwise i, j would be on indexes 5 -> 1;
        // When we -1, we lose the current 1, for the remainder 1's
        // E.g (0b1000000) - 1 = 0111111;
        int clearMask = ((1 << j + 1 ) - 1) ^ ((1 << i) - 1);
        N &= ~clearMask;
        
        // Shift M bits into place.
        M <<= i;

        // Merge together results.
        N |= M;

        return N;
    }

    public static void Test()
    {
        var q = new practice_1();
        Console.WriteLine("");
        var result = q.Insert(0b10000000000, 0b10011, 2, 6);
        var resultV2 = q.InsertV2(0b10000000000, 0b10011, 2, 6);
        Console.WriteLine("Output V1: " + Convert.ToString(result, 2));
        Console.WriteLine("Insert(10000000000,10011,2,6) == 10001001100 : " + (result == 0b10001001100));
        
        Console.WriteLine("Output V2: " + Convert.ToString(resultV2, 2));
        Console.WriteLine("Insert(10000000000,10011,2,6) == 10001001100 : " + (resultV2 == 0b10001001100));
        
        var test = q.InsertV2(0b10110011100, 0b10011, 2, 6);
        Console.WriteLine("Output Final Random Test: " + Convert.ToString(test, 2));
        Console.WriteLine("Insert(10000000000,10011,2,6) == 10001001100 : " + (test == 0b10111001100));
    }
     
}