// See https://aka.ms/new-console-template for more information


//void PrintStarsPyramid(int n)
//{



//    for (int i = 0; i < n; i++)
//    {
//        //Added spaces on left

//        for (int j = 0; j < n - i - 1; j++)
//        {
//            Console.Write(" ");
//        }


//        for (int j = 0; j < 2 * i + 1; j++)
//        {
//            Console.Write("*");
//        }

//        //add spaces on right
//        for (int j = 0; j < n - 1 - i; j++)
//        {
//            Console.Write(" ");
//        }
//        Console.WriteLine();
//    }


//}

//PrintStarsPyramid(5);

//void PrintStarsPyramidReverse(int n)
//{
//    for (int i = 0; i < n; i++)
//    {
//        for (int j = 0; j < i; j++)
//        {
//            Console.Write(" ");
//        }

//        for (int j = 0; j < (2 * n) - (2 * i + 1); j++)
//        {
//            Console.Write("*");
//        }

//        for (int j = 0; j < i; j++)
//        {
//            Console.Write(" ");
//        }
//        Console.WriteLine();
//    }
//}

//PrintStarsPyramidReverse(5);

//void PrintStarsHalfPyramid(int n)
//{
//    for (int i = 0; i < n; i++)
//    {

//        //Add Spaces before
//        for(int j = 0; j < i; j++)
//        {

//        }

//    }
//}


//int CountDigits(int num)
//{
//    int count = 0;
//    while (num != 0)
//    {
//        count++;
//        num = num / 10;
//    }
//    return count;
//}

//Console.WriteLine(CountDigits(15));
//int ReverseNum(int num)
//{
//    int reverseNum = 0;
//    while (num != 0)
//    {
//        int n = num % 10;
//        reverseNum = reverseNum * 10 + n;
//        num = num / 10;
//    }
//    return reverseNum;
//}

//Console.WriteLine(ReverseNum(01937));

//Console.WriteLine(19370%10);

//bool IsPalindrome(int num)
//{
//    int temp = num;
//    int reverseNum = 0;
//    while (temp != 0)
//    {
//        int n = temp % 10;
//        reverseNum = reverseNum * 10 + n;
//        temp = temp / 10;
//    }
//    if (num != reverseNum)
//    {
//        return false;
//    }
//    return true;
//}

//Console.WriteLine(IsPalindrome(321));

//bool IsPrime(int num)
//{
//    int i = 2;
//    while (i<num)
//    {
//        if (num % i == 0)
//        {
//            return false;
//        }
//        i++;
//    }
//    return true;
//}

//Console.WriteLine(IsPrime(13));

//void DivisorOfNum(int num)
//{
//    int i = 1;
//    //List<int> ans = new List<int>();
//    //int[] ans = { };
//    Console.WriteLine($"Divisor of {num} are :");
//    while (i<=num)
//    {
//        if (num % i == 0)
//        {
//            Console.WriteLine(i);
//        }
//        i++;
//    }
//}

//DivisorOfNum(8);

//int GCDofNums(int num1,int num2)
//{
//    int i = 1;
//    //List<int> gcd = new List<int>();
//    int gcd = 0;
//    while (i<=num1 && i<=num2)
//    {
//        if(num1%i==0 && num2 % i == 0)
//        {
//            gcd = i;
//        }
//        i++;
//    }
//    return gcd;
//}
//Console.WriteLine(GCDofNums(9,8));

//bool IsArmstrong(int num)
//{
//    int count = 0;
//    int CountDigits(int num)
//    {
//        count++;
//        num = num / 10;

//        return count;
//    }
//    int cnt = CountDigits(num);

//}

//printing name five times using recursion

//void PrintNamesFiveTimes(int i,int n)
//{
//    if (i == n)
//    {
//        return;
//    }
//    Console.WriteLine("Usama Ashraf");
//    PrintNamesFiveTimes(i + 1, n);

//}

//PrintNamesFiveTimes(0, 4);

//Print linearly from 1 to N

//void PrintNumbersLinearlyToN(int i,int n)
//{
//    if (i > n)
//    {
//        return;
//    }
//    Console.WriteLine(i);
//    PrintNumbersLinearlyToN(i+1,n);
//}

//PrintNumbersLinearlyToN(1, 10);

//print numbers from N to 1

//void PrintNumbersFromN(int i,int n)
//{
//    if (i > n)
//    {
//        return;
//    }
//    Console.WriteLine(n);
//    PrintNumbersFromN(i, n-1);

//}
//PrintNumbersFromN(1, 10);

//Print linearly from 1 to N using backtracking

//void PrintNumberLinearly(int i,int n)
//{
//    if (i < 1)
//    {
//        return;
//    }
//    PrintNumberLinearly(i-1, n);
//    Console.WriteLine(i);
//}

//PrintNumberLinearly(3, 3);

//Print numbers from N to 1 using backtracking

//void PrintNumbersFromN(int i,int n)
//{
//    if (i > n)
//    {
//        return;
//    }
//    PrintNumbersFromN(i + 1, n);
//    Console.WriteLine(i);
//}

//PrintNumbersFromN(1, 3);

//Sum of first N number
//void SumOfFirstNNumbers(int i,int sum)
//{
//    if (i <1)
//    {
//        Console.WriteLine(sum);
//        return;
//    }
//    SumOfFirstNNumbers(i-1,sum+i);

//}
//SumOfFirstNNumbers(10,0);

//factorial of N numbers

//void FactorialNumber(int fact,int n)
//{
//    if (n < 1)
//    {
//        Console.WriteLine(fact);
//        return;
//    }
//    FactorialNumber(fact*n,n-1);
//}
//FactorialNumber(1, 5);

//Reverse an Array

//void ReverseArray(int i,int[] arr, int n)
//{
//    int j = n - i - 1;
//    if (i >= n-i-1)
//    {
//        foreach(int item in arr)
//        {
//            if (Array.IndexOf(arr, item) < arr.Length-1)
//            {
//                Console.Write($"{item},");
//            }
//            else
//            {
//                Console.Write($"{item}");
//            }

//        }
//        return;
//    }
//    int newArr = arr[i];
//    arr[i] = arr[j];
//    arr[j] = newArr;

//    ReverseArray(i+1,arr, n);
//}

//ReverseArray(0,[1,2,3,4,5], 5);

//Check if string is palindrome

//void IsPalindrome(int i,string str)
//{
//    int j = str.Length - i - 1;

//    if (str[i] != str[j])
//    {
//        Console.WriteLine("String is not Palindrome");
//        return;
//    }

//    if (i >= j)
//    {
//        Console.WriteLine("String is Palindrome");
//        return;
//    }



//    IsPalindrome(i+1, str);
//}

//IsPalindrome(0,"aabbdcccdbbaa");

//Print Fabionacci up to Nth Term

//void PrintFabionacciUptoNthTerm(int n)
//{
//    int n1 = 0;
//    int n2 = 1;
//    int nextNum;
//    Console.Write(n1 + "," + n2+",");
//    for(int i = 1; i < n; i++)
//    {
//        nextNum = n1 + n2;
//        Console.Write(i < n - 1 ? nextNum+"," : nextNum);
//        int temp = n1;
//        n1 = n2;
//        n2= nextNum;
//    }
//}
//PrintFabionacciUptoNthTerm(5);

//int CountDigits(int n)
//{
//    int count = 0;
//    while (n != 0)
//    {
//        count++;
//        n = n / 10;
//    }
//    return count;
//}

//Console.WriteLine(CountDigits(12370));

//int ReverseNumber(int num)
//{
//    int reverseNum = 0;
//    while (num != 0)
//    {
//        int n = num % 10;
//        reverseNum = reverseNum * 10 + n;
//        num = num / 10;
//    }
//    return reverseNum;
//}

//Console.WriteLine(ReverseNumber(12312));

//bool CheckPalindrome(int num)
//{
//    int temp = num;
//    int reverseNum = 0;

//    while (temp != 0)
//    {
//        int n = temp % 10;
//        reverseNum = reverseNum * 10 + n;
//        temp = temp / 10;
//    }

//    if (reverseNum != num)
//    {
//        return false;
//    }
//    return true;
//}

//Console.WriteLine(CheckPalindrome(321));

//int  GCDOfNums(int num1,int num2)
//{
//    int gcd=0;
//    int i = 1;
//    while (i < num1)
//    {
//        if(num1%i==0 && num2 % i == 0)
//        {
//            gcd = i;
//        }
//        i++;
//    }
//    return gcd;
//}

//Console.WriteLine(GCDOfNums(20,15));

//First and Last Position of element in sorted arrayintint

//List<int> SearchRange(int target,int[] nums)
//{
//    int first = -1;
//    int last = -1;
//    for(int i=0;i<nums.Length; i++)
//    {
//        if(target == nums[i])
//        {
//            if(first == -1)
//            {
//                first = i;
//            }
//            last = i;
//        }
//    }
//    return new List<int> { first,last};
//}

//List<int> arr=SearchRange(0, []);

//foreach(int i in arr)
//{
//    Console.Write(i+" ");
//}


//Half the number, if the number is odd put the largest half on the right side of array and smalles into left
//int[] HalfTheNumber(int num)
//{
//    int left = num / 2;
//    int right = num - left;

//    return new int[] { left, right };
//}

//int[] ans = HalfTheNumber(15);
//foreach(int num in ans)
//{
//    Console.Write(num + " ");
//}

//Merge two sorted arrays

//void MergeTwoArrays(int[] nums1,int m,int[] nums2,int n)
//{
//    for (int i = 0; i < n; i++)
//    {
//        nums1[m + 1] = nums2[i];
//    }

//    for (int i = 0; i < nums1.Length; i++)
//    {
//        for (int j = 1; j < nums1.Length; j++)
//        {
//            if (nums1[i] > nums1[j])
//            {
//                int temp = nums1[i];
//                nums1[i] = nums1[j];
//                nums1[j] = temp;
//            }
//        }
//    }
//}


//Half the number, if the number is odd put the largest half on the right side of array and smalles into left
//int[] HalfTheNumber(int num)
//{
//    int left = num / 2;
//    int right = num - left;
//    return new int[] { left, right };
//}

//int[] arr = HalfTheNumber(17);
//foreach(int num in arr)
//{
//    Console.Write(num + " ");
//}

//void CountFrequenciesOfElements(int[] nums)
//{
//    Dictionary<int, int> hash = new Dictionary<int, int>();
//    foreach(int num in nums)
//    {
//        if (hash.ContainsKey(num))
//        {
//            hash[num]++;
//        }
//        else
//        {
//            hash[num] = 1;
//        }
//    }

//    int mostFreq = hash.Max(e => e.Value);
//    int leastFreq = hash.Min(e => e.Value);

//    var mostOccuringElemets = hash.Where(e => e.Value == mostFreq).
//        Select(e => e.Key);
//    var leastOccuringElements = hash.Where(e => e.Value == leastFreq).Select(e => e.Key);

//    Console.WriteLine("Most Occuring Element " + string.Join(",",mostOccuringElemets));
//    Console.WriteLine("Least Occuring Element " + string.Join(",", leastOccuringElements));
//}

//CountFrequenciesOfElements([1,4,3,1,2,6,1,2]);

//bool ValidAnagram(string str1, string str2)
//{
//    Dictionary<char, int> sMap = new Dictionary<char, int>();
//    Dictionary<char, int> pMap = new Dictionary<char, int>();

//    foreach(char s in str1)
//    {
//        if (sMap.ContainsKey(s))
//        {
//            sMap[s]++;
//        }
//        else
//        {
//            sMap[s] = 1;
//        }
//    }

//    foreach(char p in str2)
//    {
//        if (pMap.ContainsKey(p))
//        {
//            pMap[p]++;
//        }
//        else
//        {
//            pMap[p] = 1;
//        }
//    }

//    //foreach(var e in sMap)
//    //{
//    //    Console.WriteLine(e.Key+" "+e.Value);
//    //}
//    foreach(var e in pMap)
//    {
//        if (!sMap.ContainsKey(e.Key) || sMap[e.Key]!= pMap[e.Key])
//        {
//            return false;
//        }
//    }
//    return true;
//}

//Console.WriteLine(ValidAnagram("jar","jam"));


//int[] SelectionSort(int[] arr)
//{
//    for (int i = 0; i < arr.Length - 1; i++)
//    {
//        int minNum = i;
//        for (int j = i + 1; j < arr.Length; j++)
//        {
//            if (arr[j] < arr[minNum])
//            {
//                minNum = j;
//            }
//        }
//        int temp = arr[minNum];
//        arr[minNum] = arr[i];
//        arr[i] = temp;
//    }
//    return arr;
//}

//int[] ansNum = SelectionSort([8,3,5,2]);
//foreach (int num in ansNum)
//{
//    Console.Write(num + " ");
//}

//int[] BubbleSort(int[] arr) 
//{
//    for(int i=0;i<arr.Length-1; i++)
//    {
//        for(int j = i + 1; j < arr.Length; j++)
//        {
//            if (arr[i] > arr[j])
//            {
//                int temp = arr[i];
//                arr[i] = arr[j];
//                arr[j] = temp;
//            }
//        }
//    }
//    return arr;
//}

//int[] ansArr = BubbleSort([3, 4, 2, 1]);
//foreach(int num in ansArr)
//{
//    Console.Write(num+" ");
//}

//int[] InsertionSort(int[] arr)
//{
//    for(int i = 1; i < arr.Length; i++)
//    {
//        int j = i;
//        while(j>0 && arr[j - 1] > arr[j])
//        {
//            int temp = arr[j];
//            arr[j] = arr[j-1];
//            arr[j - 1] = temp;

//            j--;

//        }
//    }
//    return arr;
//}

//int[] ansArr = InsertionSort([8, 3, 5, 1]);

//foreach(int num in ansArr)
//{
//    Console.Write(num + " ");
//}



//int[] SelectionSort(int[] arr)
//{
//    for(int i = 0; i < arr.Length-1; i++)
//    {
//        int minNum = i;
//        for(int j=i+1;j<arr.Length;j++)
//        {
//            if (arr[i] > arr[j])
//            {
//                minNum = j;
//            }
//        }
//        int temp = arr[i];
//        arr[i] = arr[minNum];
//        arr[minNum] = temp;
//    }
//    return arr;
//}

//int[] ansArr = SelectionSort([8,3,5,2]);
//foreach(int num in ansArr)
//{
//    Console.Write(num+" ");
//}

//int[] BubbleSort(int[] arr)
//{
//    for(int i = 0; i < arr.Length; i++)
//    {
//        for(int j = i + 1; j < arr.Length; j++)
//        {
//            if (arr[i] > arr[j])
//            {
//                int temp = arr[i];
//                arr[i] = arr[j];
//                arr[j] = temp;
//            }
//        }
//    }
//    return arr;
//}

//int[] ansArr = BubbleSort([8, 3, 5, 2]);
//foreach(int num in ansArr)
//{
//    Console.Write(num+" ");
//}

int[] InsertionSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int j = i;
        while (j > 0 && arr[j - 1] > arr[j])
        {
            int temp = arr[j-1];
            arr[j - 1] = arr[j];
            arr[j] = temp;

            j--;
        }
    }
    return arr;
}

int[] ansArr = InsertionSort([8, 3, 5, 2]);
foreach(int num in ansArr)
{
    Console.Write(num);
}