// Chris Baert
// CS 3500
// PS_1
// Project Format
// 01-17-2019

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PS1
{/// <summary>
/// Format takes in a positive integar, n, as a command line parameter.  It then reads lines
/// from standard input and breaks the input into tokens and then writes the tokens in order, 
/// n per line to the output stream, until the input stream has ended.
/// 
/// </summary>
    class Format
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

            // Read lines from standard input until the end of the input
            while ((line = Console.ReadLine()) != null)
            {
                // Split the line into individual tokens and store in the words array
                string[] words = line.Split(deliminators);

                // For each token in the string, add them to the queue
                foreach (var word in words)
                {
                    myQ.Enqueue(word);
                }
                int wordCount = myQ.Count;

                // Loop once for each full line of words available to be printed
                for (int i = 1; i <= wordCount / n; i++)
                {
                    // Print to the console the words with a space until the end of the line
                    for (int j = 1; j < n; j++)
                    {
                        Console.Write(myQ.Dequeue() + " ");
                    }
                    // Then print the last word on the line with a carraige return
                    Console.WriteLine(myQ.Dequeue());
                }
            }

            // Print any remaining words left in the queue
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