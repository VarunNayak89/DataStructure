using System;

//Company : Scalar AI, 2024 , Online code

/*
Given a string encoded for transfer to the receiver, the encoding conditions are as follows:

Reverse each character for each word.
There is an extra space at the beginning of the sentence, end of the message, and between each word.
Output: There should be no space at the beginning and end of the message. Additionally, each word should have only one space between them, and they should be reversed.
*/

namespace StringPractise
{
    class Program
    {
        static void Main(string[] args)
        {           
            string input = "  olleH  dlroW  nurav ";

            string output = Decodestring(input);
            Console.WriteLine(output);
            Console.ReadLine();
        }
        
        static string Decodestring(string input)
        {
            //base case
            if (input == "")
                return "";
            string[] Inputarray = input.Split(" ");

            input = "";
            foreach(var item in Inputarray)
            {
                if (item != "")
                    input = input + " " + Reverseword(item);
            }
            return input.Trim().TrimStart();

        }
        static string Reverseword(string input)
        {
            char[] array = input.ToCharArray();
            int left = 0, right = array.Length - 1;
            while(left<right)
            {
                char temp = array[left];
                array[left] = array[right];
                array[right] = temp;
                left++;
                right--;
            }
            string result = new string(array);
            return result;

        }
    }
}
