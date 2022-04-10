namespace Coriander.Questions.LinkedList;

/*
Sum Lists

You have two lists represented by a linked list, where each node contains a single digit.
Digits are stored in reverse order.

E.g (6 -> 5 -> 1) = 156

Not allowed to cheat and convert linked list into an integer.

baaart.dev
*/

using DataStructures.Collection;

public class practice_5
{
    public ListNode<int> SumLists(ListNode<int>? a, ListNode<int>? b)
    {
        ListNode<int> result = new ListNode<int>(0);
        
        while (a != null || b != null)
        {
            int v = result.Value + a.Value + b.Value;
            result.Value = v % 10;
            
            if (v > 9)
            {
                result = new ListNode<int>(1, result);
            }
            else
            {
                if (a.Next != null || b.Next != null)
                {
                    result = new ListNode<int>(0, result);
                }
            }

            a = a.Next;
            b = b.Next;
        }
        
        return result;
    }

    /* Helper Function for testing */
    private static void GetValue(ListNode<int> l)
    {
        while (l != null)
        {
            Console.Write(l.Value);
            l = l.Next;
        }
        Console.WriteLine();
    }
    
    /* Helper Function for testing */
    public static void Test()
    {
        var Question = new practice_5();
        var a = new ListNode<int>(4, new ListNode<int>(5, new ListNode<int>(3)));
        var b = new ListNode<int>(5, new ListNode<int>(9, new ListNode<int>(8)));
        var result = Question.SumLists(a, b);
        
        var c = new ListNode<int>(1, new ListNode<int>(2, new ListNode<int>(3)));
        var d = new ListNode<int>(1, new ListNode<int>(2, new ListNode<int>(3)));
        var result2 = Question.SumLists(c, d);
        
        GetValue(result);
        GetValue(result2);
    }
}