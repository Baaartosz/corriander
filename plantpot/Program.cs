using Coriander.Questions.Stack_and_Queues;

namespace Coriander
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacks and Queues Q4");

            var q = new practice_4.MyQueue<int>();

            Console.WriteLine("ENQUEUE");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + ", ");
                q.Enqueue(i);
            }

            Console.WriteLine("\nDEQUEUE");
            for (int i = 0; i < 10; i++)
            {
                 Console.Write(q.Dequeue() + " ,");
            }
        }
    }
}