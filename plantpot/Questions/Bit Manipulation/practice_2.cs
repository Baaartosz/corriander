using System.Text;

namespace Coriander.Questions.Bit_Manipulation;

/*
 * Binary to String
 * 
 * Give a real number between 0 and 1 ( E.g 0.72 ) that is passed in as a double,
 * print the binary representation. If the number cannot be represented accurately in binary with at
 * most 32 characters, print "ERROR".
 */

public class practice_2
{
    public string BinaryToString(double num)
    {
        if (num >= 1 || num <= 0)
        {
            return "ERROR (num >= 1 || num <= 0";
        }

        StringBuilder binary = new();
        binary.Append('.');

        while (num > 0)
        {
            if (binary.Length >= 32)
            {
                return "ERROR (Longer then 32bits)";
            }

            double r = num * 2;
            if (r >= 1)
            {
                binary.Append(1);
                num = r - 1;
            }
            else
            {
                binary.Append(0);
                num = r;
            }
        }
        
        return binary.ToString();
    }

    public static void Test()
    {
        var q = new practice_2();
        Console.WriteLine(q.BinaryToString(0.01));
    }
}