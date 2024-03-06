/*
Leet code 1324
EX 1:
input: How are you
output [hay,oro,weu]

Array A: H A Y
Array B: O R O
Array C: W E U

Ex 2
input: contest is coming
output: [cic,oso,n m,t i,e n,s g,t]
array 1:cic
array 2:oso
array 3:n m
array 4:t i
array 5:e n
array 6:s g
array 7:t 
find biggest word from string, create that many string builder

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringPractise
{
    class Program
    {
    static void Main(string[] args)
        {
            string input = "contest is coming";
            PrintVertically(input);
            Console.ReadLine();
        }

        // Time : o(n), Space:o(n)
        //String builder is mutable so no extra o(n) space
        public static IList<string> PrintVertically(string s)
        {
            var output = new List<string>(); // output list
            var words = s.Split(' ');// array of words 
            var max = words.Select(w => w.Length).Max();// find biggest word length
            StringBuilder[] sb = new StringBuilder[max];
            for (int i = 0; i < max; i++)
                sb[i] = new StringBuilder(); //intialize string builder for each element sb array

            foreach (var word in words)// loop for entire string
            {
                for (int i = 0; i < max; i++) //for each word 
                {
                    sb[i].Append(i < word.Length ? word[i] : ' ');//add char or no char than add space
                }
            }
            foreach (var lst in sb)
            {
                output.Add(lst.ToString().TrimEnd());//Trim remove leading and trailing space, here we need to remove
                                                     // only trailing white space so trim
            }
            return output;
        }
    }
}