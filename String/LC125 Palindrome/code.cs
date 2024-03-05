// Leet code : 125
/* there are two method to solve this problem
method 1 : reverse string and compare with original Time o(n), Space o(n)

take input and remove all char excet letters and numbers : Time o(n)
reverse input and copy in another string : time o(n), space o(n)
compare both input and new string :o(n)

method 2: Two pointers; traverse string inwards and outwards Time o(n), space o(1)

rather than filter at first we can loop each char and avoid special char
Time o(n), we traverse each char at most once, no extra space

*/

//Time :o(n), Space: o(1)
static void Main(string[] args)
        {
            string input = "A man, a plan, a canal: Panama";
            method1(input);
            Console.ReadLine();
        }

        // Time : o(n), Space:o(1)
        public static bool IsPalindrom(string s)
        {
            int left = 0;
            int right = 0;
            for (left = 0; (left < s.Length - 1 && left < right); left++, right--)
            {
                while (!Char.IsLetterOrDigit(s[left]) && left < right)
                    left++;

                while (!Char.IsLetterOrDigit(s[right]) && left < right)
                    right--;

                if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
                    return false;
            }
            return true;
        }

        // Time : o(n), Space: o(n)
        public static bool method1(string s)
        {
            System.Text.StringBuilder bui = new System.Text.StringBuilder();
            foreach (var value in s)
            {
                if (Char.IsLetterOrDigit(value))
                {
                    bui.Append(Char.ToLower(value));
                }
            }
           
            //.int j=0;
            System.Text.StringBuilder buinew = new System.Text.StringBuilder();
            for (int i = bui.Length - 1; i >= 0; i--)
            {
                buinew.Append(bui[i]);
            }
            if (bui.Equals(buinew))
                return true;
            return false;
        }

