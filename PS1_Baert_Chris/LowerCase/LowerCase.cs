using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    class Program
    {/// <summary>
     /// Read lines of input from standard input stream, break each line 
     /// into tokens and then covert each token into lower case and then 
     /// write each token to the standard output stream in the order that
     /// they were read, each on a new line.
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Use these characters as deliminators to split the string into tokens
            char[] deliminators = { ' ', '\t', '\r', '\n' };
            string line;

            // Read lines from standard input until there are no more
            while((line = Console.ReadLine())!= null)
            {
                // Split the line into individual tokens and store in the words array
                string[] words = line.Split(deliminators);

                // For each token in words, cast to lower case and then write to console
                foreach (var word in words)
                {
                    Console.WriteLine(word.ToLower());
                }
            }
        }
    }
}
