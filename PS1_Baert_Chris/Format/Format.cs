using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Queue<string> myQ = new Queue<string>();

            // If there is not just a single command line input parameter, set n to 1
            if (args.Length != 1)
            {
                n = 1;
            }
            else
            {
                // If the input cannot be parsed to an int, then set n to 1
                // If it can be parsed to an int, set n to that value
                if (!int.TryParse(args[0], out n))
                {
                    n = 1;
                }

                // If the int used to set n is not positive, set n to 1
                if (n <= 0)
                {
                    n = 1;
                }
            }

            // Use these characters as deliminators to split the string into tokens
            char[] deliminators = { ' ', '\t', '\r', '\n' };
            string line;

            // Read lines from standard input until there are no more
            while ((line = Console.ReadLine()) != null)
            {
                // Split the line into individual tokens and store in the words array
                string[] words = line.Split(deliminators);

                // For each token in words, cast to lower case and then write to console
                foreach (var word in words)
                {
                    myQ.Enqueue(word);
                }
                int wordCount = myQ.Count;
                for (int i = 1; i <= wordCount / n; i++)
                {
                    for (int j = 1; j < n; j++)
                    {
                        Console.Write(myQ.Dequeue() + " ");
                    }
                    Console.WriteLine(myQ.Dequeue());
                }
            }
            while (myQ.Count > 1)
            {
                Console.Write(myQ.Dequeue() + " ");
            }

            if (myQ.Count == 1)
            {
                Console.WriteLine(myQ.Dequeue());
            }
        }
    }
}