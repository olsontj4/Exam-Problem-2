using System;

namespace IsPalindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word or phrase:");
            if (IsPalindrome(Console.ReadLine()))
            {
                Console.WriteLine("This is a palindrome!");
            }
            else
            {
                Console.WriteLine("This is not a palindrome.");
            }
        }
        static bool IsPalindrome(string input)
        {
            Queue<string> forwards = new Queue<string>();
            Stack<string> reverse = new Stack<string>();
            foreach (char c in input.ToLower())//Fill both data structures with only letters.
            {
                if (Char.IsLetter(c))
                {
                    forwards.Enqueue(c.ToString());
                    reverse.Push(c.ToString());
                }
            }
            for (int i = 0; i < forwards.Count; i++)//Empty data structures and check for mismatch.
            {
                if (forwards.Dequeue() != reverse.Pop())
                {
                    return false;
                }
            }
            return true;
        }
    }
}