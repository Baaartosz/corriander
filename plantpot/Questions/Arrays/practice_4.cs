namespace Coriander.Questions.Arrays;

/*
 * Palindrome Permutation
 *
 * Given a string , write a function to check if it's a permutation of a palindrome.
 *
 * A palindrome is a word or phrase that is the same forwards and backwards.
 *
 * A permutation is a rearrangement of letters. The palindrome does not need to be limited to just
 * dictionary words.
 *
 * You may ignore casing and non-letter characters.
 *
 * baaart.dev
 */

public class practice_4
{
    public bool IsPermutationOfPalindrome(string text)
    {
        int[] charTable = GenerateTable(text); 
        return MaxOneOdd(charTable);
    }

    private int[] GenerateTable(string text)
    {
        int[] table = new int['z' - 'a' + 1];
        foreach (var t in text) // O(n)
        {
            int m = GetMappedCharCode(t);
            if (m != -1)
            {
                table[GetMappedCharCode(t)]++;
            }
        }
        return table;
    }

    private int GetMappedCharCode(char c)
    {
        // Check if char is in Alphabet, return ASCII code else -1;
        int arrayOffset = 'a';
        return c <= 'z' && c >= 'a' ? c - arrayOffset : -1;
    }

    private bool MaxOneOdd(int[] cTable)
    {
        // Check for the max of one odd.
        int odds = 0;
        foreach (var charCount in cTable) // O(n)
        {
            if(charCount == 1)
                odds++;
        }
        return odds == 1;
    }
}