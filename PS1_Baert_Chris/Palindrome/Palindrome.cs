using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    class Program
    {/// <summary>
    /// Reads lines from standard input and then checks to see if the input
    /// is a palindrome, meaning that it is the same regardless if it is read
    /// forwards or backwards, including puncuaiton, case and white space. 
    /// If the input is a palindrome, then it writes the input back to 
    /// standard output
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            // string variable to hold the line from standard input
            string line;
            
            // Read line from standard input unti there is not more input
            while((line = Console.ReadLine()) != null){

                // create an array of chars out of the line from standard input
                char [] lineArray = line.ToCharArray();

                // create variables to use when determining if input is palindrome
                int i = line.Length - 1;
                bool isPalindrome = true;

                // Check each char in the array to see if it is the same in reverse
                for (int j = 0; j < (line.Length/2) + 1; j++)
                {
                    // if the 2 chars are not the same, the input is not a palindrome
                    if(lineArray[i] != lineArray[j])
                    {
                        isPalindrome = false;
                        break;
                    }
                    i--;

                }
                // write the line to console if it is a palindrome
                if (isPalindrome)
                {
                    Console.WriteLine(line);
                }

            }
        }
    }
}
