//problem 1

// method 1 : Sort Array and arrange in reverse order, max number infront
        //Time : o(nlogn) array sort time
        //Space : o(1)
        static string Method1_FindMax(int[] arr)
        {
            int n = arr.Length;
            int number=0;
            Array.Sort(arr);
            StringBuilder sb = new StringBuilder();
            for (int i = n - 1; i >= 0; i--)
            {
                sb.Append(arr[i]);
                number = number * 10 + arr[i];// if you want to store in int value
            }
            return sb.ToString();
        }
//Method 2: as we know number is 0 to 9, we can use hash of size 10,
//hash table key is 0 to 9 number
//hash table value is count of their occurrences in array
//Print the digits the number of times they occure in descending order starting from digit 9

//Time : o(n), number of digit; 
//Space: o(1), size of hash is only 10 which is constant
        static string Method2_FindMax(int[] arr)
        {
            int n = arr.Length;
            //Each value default 0
            int[] hash = new int[10];// its hash array , where value is reps 

            for (int i = 0; i < n; i++)
            {
                hash[arr[i]]++;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 9; i >= 0; i--)
            {
                for (int j = 0; j < hash[i]; j++)// print the number of times a digit occurs
                    sb.Append(i);
            }
            return sb.ToString();
        }

//Problem 2:

//if number has last digit 0 or 5 than only its divisible by 5
// here we check three condition
// if array dont have 0 or 5 digit its not divisible by 5 and return 0
// if array have zero number , same as like above program as zero go in last by default
//if array  have five number and dont have zero, put one 5 number in the last and make that number divisible by 5

//Time : o(n), number of digit; 
//Space: o(1), size of hash is only 10 which is constant
        static string Method1_Divisible5(int[] arr)
        {
            int n=arr.Length;
            bool isZero=false;
            bool isfive=false;

            int[] hash =new int[10];
        
            for(int i=0; i<n; i++)
            hash[arr[i]]++;
            
            if(hash[0]>0)
            isZero=true;

            if(hash[5]>0)
            isfive=true;

            if (isZero==false && isfive==false)
            return "0";// if there are no 5 or 0 than its not divisible by 5

            StringBuilder sb = new StringBuilder();
            if(isZero==false)
                hash[5]--;// only isfive==true so , we remove one 5 from array
            for(int i=9; i>=0; i--)
            {
                for(int j=0; j<hash[i];j++)
                {
                    sb.Append(i);
                }
            }
            if(isZero==false)
            sb.Append(5);// only if five ==true at the end append 5, if zero than no change

            return sb.ToString();
        }
