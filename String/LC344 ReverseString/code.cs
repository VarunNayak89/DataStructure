using System;
//Leet code 344

/*
Three Approch to Solve this problem
Method 1 : time o(n), Space o(n){extra space for new Array}
 Creat new Array (extra space o(n)), and reverse each char

 Method 2 : time o(n), Space o(n) {extra space for recursion stack}
In place recursion , no extra array,
we are doing n/2 swapping so time o(n)

Method 3: Time O(n), Space o(1)
*/

namespace StringPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = new char[] { 'n', 'u', 'r', 'a', 'v' };

           // var output = ReverseString1(input);
          // Reversestring2(input,0,input.Length-1);
            ReverseString3(input);
           var output=input;
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        //Time: o(n), Space: o(n) extra array
        public static char[] ReverseString1(char[] s)
        {
            char[] ara = new char[s.Length];
            int j = 0;
            for (int i = s.Length - 1; i >= 0; i--, j++)
                ara[j] = s[i];

            return ara;
        }

        //Time : o(n), Space o(n) recursive stack
        public static void Reversestring2(char[] s, int left, int right)
        {
            if(left>=right)
            return;

            char temp= s[left];
            s[left]=s[right];
            s[right]=temp;

            Reversestring2(s,left+1,right-1);
        } 

        
        // Time : 0(n), Space o(1)
        public static void ReverseString3 (char[]s)
        {
            int left=0, right=s.Length-1;
            while(left<=right)
            {
                char temp= s[left];
                s[left]=s[right];
                s[right]=temp;
                left++;
                right--;
            }
        }     
        
       
    }
}
