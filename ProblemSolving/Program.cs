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

//int[] InsertionSort(int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        int j = i;
//        while (j > 0 && arr[j - 1] > arr[j])
//        {
//            int temp = arr[j-1];
//            arr[j - 1] = arr[j];
//            arr[j] = temp;

//            j--;
//        }
//    }
//    return arr;
//}

//int[] ansArr = InsertionSort([8, 3, 5, 2]);
//foreach(int num in ansArr)
//{
//    Console.Write(num);
//}

//void MergeSort(int[] arr,int low,int high)
//{
//    if (low >= high)
//    {
//        return;
//    }
//    int mid = (low + high) / 2;
//    MergeSort(arr, low, mid);
//    MergeSort(arr, mid + 1, high);

//}

//int Merge(int[] arr, int low,int mid,int high)
//{
//    int[] result = new int[low + high];
//    int left = low;
//    int right = mid+1;

//    while(left<=low && right <= high)
//    {
//        if (arr[left] < arr[right])
//        {

//        }
//    }
//}

//int MaxElementInArray(int[] arr)
//{
//    int max = arr[0];
//    for(int i = 1; i < arr.Length; i++)
//    {
//        if (arr[i] > max)
//        {
//            max = arr[i];
//        }
//    }
//    return max;
//}

//Console.WriteLine(MaxElementInArray([10,1,2,3,4,5]));

//int SecondLargestElement(int[] arr)
//{
//    int max = arr[0];
//    int second = 0;
//    for(int i = 1; i < arr.Length; i++)
//    {
//        if (arr[i] > max)
//        {
//            max = arr[i];
//        }
//    }
//    for(int i = 1; i < arr.Length; i++)
//    {
//        if (arr[i]!=max && arr[i]<max)
//        {
//            second = arr[i];
//        }
//    }
//    return second;
//}

//Console.WriteLine(SecondLargestElement([10, 1, 2, 3, 4, 5,6]));

//bool IsSorted(int[] arr)
//{
//    for(int i = 0; i < arr.Length-1; i++)
//    {
//        if (arr[i] > arr[i + 1])
//        {
//            return false;
//        }
//    }
//    return true;
//}

//Console.WriteLine(IsSorted([1,3,4]));

//List<int> RemoveDuplicates(int[] arr)
//{
//    List<int> ans = new List<int>();

//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (!ans.Contains(arr[i]))
//        {
//            ans.Add(arr[i]);
//        }
//    }
//    return ans;
//}

//List<int> result = RemoveDuplicates([1,1,2,3,3,3]);

//foreach(int num in result)
//{
//    Console.Write(num+" ");
//}

//int[] LeftRotateAnArray(int[] arr)
//{
//    for(int i = 0; i < arr.Length+1; i++)
//    {
//        arr[i] = arr[i+1];
//    }
//    return arr;
//}

//int[] ans = LeftRotateAnArray([1, 2, 3, 4, 5]);
//foreach(int i in ans)
//{
//    Console.Write(i + " ");
//}


//Console.Write(7 % 2);

//void RotateLeft(int[] arr, int k)
//{
//    int n = arr.Length;
//    k = k % n;
//    int[] rotatedArray = Rotate(arr, 0, n - 1);
//    int[] rotateRight = Rotate(rotatedArray, 0, k-1);
//    int[] rotateLeft = Rotate(rotateRight, k, n - 1);
//    foreach (int i in rotateLeft)
//    {
//        Console.Write(i + " ");
//    }
//}

//int[] Rotate(int[] nums, int left, int right)
//{
//    while (left < right)
//    {
//        int temp = nums[left];
//        nums[left] = nums[right];
//        nums[right] = temp;

//        left++;
//        right--;
//    }
//    return nums;
//}


//int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
//RotateLeft(nums, 3);

//int[] MoveZerosToEnd(int[] nums)
//{
//    int n = nums.Length - 1;
//    int end = n;
//    int start = 0;

//    while (start <= end)
//    {
//        if (nums[start] == 0)
//        {

//            while (nums[end]==0 && start < end)
//            {
//                end--;
//            }
//            int temp = nums[end];
//            nums[end] = nums[start];
//            nums[start] = temp;


//            end--;
//        }

//        start++;

//    }

//    return nums;
//}

//int[] ans = MoveZerosToEnd([1,2,0,1,0,4,0]);
//foreach(int num in ans)
//{
//    Console.Write(num + " ");
//}

//int LinearSearch(int[] nums, int num)
//{
//    int index = -1;
//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] == num)
//        {
//            index = i;
//        }
//    }
//    return index;
//}

//Console.WriteLine(LinearSearch([5, 4, 3, 2, 1], 5));

//void PrintNumberFrom1toN(int i,int num)
//{
//    if (i >num)
//    {
//        return;
//    }
//    Console.WriteLine(i);
//    PrintNumberFrom1toN(i + 1, num);
//}

//PrintNumberFrom1toN(1, 5);

//void PrintNumberFromNto1(int i ,int num)
//{
//    if (i > num)
//    {
//        return;
//    }
//    Console.WriteLine(num);
//    PrintNumberFromNto1(i, num - 1);
//}

//PrintNumberFromNto1(1, 5);

//void SumOfFirstNNumber(int i,int num,int sum)
//{
//    if (i > num)
//    {
//        Console.WriteLine(sum);
//        return;
//    }
//    SumOfFirstNNumber(i + 1, num, sum + i);
//}

//SumOfFirstNNumber(0,5,0);

//void FactorialOfNum(int i,int num,int fact)
//{
//    if (i > num)
//    {
//        Console.WriteLine(fact);
//        return;
//    }
//    FactorialOfNum(i + 1, num, fact * i);
//}
//FactorialOfNum(1, 5, 1);

//void ReverseArray(int i,int[] arr)
//{
//    int j = arr.Length - i - 1;
//    if (i > j)
//    {
//        foreach(int n in arr)
//        {
//            Console.Write(n + " ");
//        }
//        return;
//    }
//    int temp = arr[i];
//    arr[i] = arr[j];
//    arr[j] = temp;
//    ReverseArray(i + 1, arr);
//}

//ReverseArray(0, [1, 2, 3, 4, 5]);

//void IsPalindrome(int i,string str)
//{
//    int j = str.Length - i - 1;
//    if (i >= j)
//    {
//        Console.WriteLine("String is Palindrome");
//        return;
//    }
//    if (str[i] != str[j])
//    {
//        Console.WriteLine("String is not Palindrome");
//        return;
//    }
//    IsPalindrome(i+1, str);
//}

//IsPalindrome(0, "usama");

//void PrintFabioncciSeries(int i, int num,int num1,int num2)
//{
//    if (i == 0)
//    {
//        Console.Write(num1 + " " + num2 + " ");
//    }

//    if (i == num)
//    {
//        return;
//    }
//    int nextNum = num1 + num2;
//    Console.Write(nextNum + " ");
//    PrintFabioncciSeries(i + 1, num, num2, num1 + num2);
//}
//PrintFabioncciSeries(0, 5, 0, 1);

//void PrintFabioncciSeries(int a, int b, int count)
//{
//    if (count == 0)
//    {
//        return;
//    }
//    Console.Write(a + " ");
//    PrintFabioncciSeries(b, a + b, count - 1);
//}
//PrintFabioncciSeries(0, 1, 5);

//void CountFrequencies(int[] arr)
//{
//    Dictionary<int, int> hash = new Dictionary<int, int>();

//    foreach(int i in arr)
//    {
//        if (hash.ContainsKey(i))
//        {
//            hash[i]++;
//        }
//        else
//        {
//            hash[i] = 1;
//        }
//    }

//    foreach(var hashItem in hash)
//    {
//        Console.WriteLine(hashItem.Key+" Occurs " + hashItem.Value +" times.");
//    }
//}

//CountFrequencies([1, 1, 2, 3, 1, 5]);

//void HighestAndLowestFrequenciesElements(int[] arr)
//{
//    Dictionary<int, int> hash = new Dictionary<int, int>();

//    foreach(int num in arr)
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

//    var mostOccuringElement = hash.Where(e => e.Value == mostFreq)
//                               .Select(e => e.Key);

//    var leastOccuringElement = hash.Where(e => e.Value == leastFreq).Select(e => e.Key);

//    Console.WriteLine("Most Occuring Element in Array " + String.Join(",", mostOccuringElement));

//    Console.WriteLine("Least Occuring Element in Array " + String.Join(",", leastOccuringElement));
//}

//bool IsValidAnagram(string s, string t)
//{
//    Dictionary<char, int> sMap = new Dictionary<char, int>();
//    Dictionary<char, int> tMap = new Dictionary<char, int>();

//    foreach(char c in s)
//    {
//        if (sMap.ContainsKey(c))
//        {
//            sMap[c]++;
//        }
//        else
//        {
//            sMap[c] = 1;
//        }
//    }

//    foreach(char c in t)
//    {
//        if (tMap.ContainsKey(c))
//        {
//            tMap[c]++;
//        }
//        else
//        {
//            tMap[c] = 1;
//        }
//    }

//    foreach(var i in tMap)
//    {
//        if (!sMap.ContainsKey(i.Key) || sMap[i.Key] != tMap[i.Key])
//        {
//            return false;
//        }
//    }
//    return true;
//}

//Console.WriteLine(IsValidAnagram("rat", "car"));

//int[] FirstAndLastPositionOfElement(int[] nums,int n)
//{
//    int first = -1;
//    int last = -1;

//    for(int i=0;i<nums.Length;i++)
//    {
//        if (n == nums[i])
//        {
//            if (first == -1)
//            {
//                first = i;
//            }
//            last = i;
//        }
//    }
//    return new int[] { first, last };
//}

//int[] ans = FirstAndLastPositionOfElement([],0);
//foreach(int i in ans)
//{
//    Console.Write(i+" ");
//}

//int[] HalfTheNumber(int num)
//{
//    int left = num / 2;
//    int right = num - left;

//    return new int[] {left,right };
//}

//int[] ans = HalfTheNumber(11);
//foreach(int i in ans)
//{
//    Console.Write(i + " ");
//}

//List<int> RemoveDuplicates(int[] nums)
//{
//    List<int> ans = new List<int>();

//    for(int i = 0; i < nums.Length; i++)
//    {
//        if (!ans.Contains(nums[i]))
//        {
//            ans.Add(nums[i]);
//        }
//    }
//    return ans;
//}

//List<int> ans = RemoveDuplicates([1,2,1,4,1]);

//foreach(int i in ans)
//{
//    Console.Write(i + " ");
//}

//int[] RotateArray(int[] arr,int k)
//{
//    int l = arr.Length-1;
//    int n = k % l;
//    int[] reversedArray = ReverseArray(0,arr,l);
//    int[] leftReverseArray = ReverseArray(0, reversedArray, n-1);
//    int[] rightReverseArray = ReverseArray(n, leftReverseArray, l);
//    return rightReverseArray;

//}

//int[] ReverseArray(int i,int[] nums, int n)
//{
//    int start = i;
//    int end = n;
//    while (start < end)
//    {
//        int temp = nums[start];
//        nums[start] = nums[end];
//        nums[end] = temp;

//        start++;
//        end--;
//    }
//    return nums;
//}

//int[] ans = RotateArray([1, 2, 3, 4, 5, 6, 7],3);
//foreach(int i in ans)
//{
//    Console.Write(i + " ");
//}

//int[] MoveZerosToEnd(int[] arr)
//{
//    for(int i = 0; i < arr.Length-1; i++)
//    {
//        if (arr[i]==0 && arr[i + 1] != 0)
//        {
//            int temp = arr[i];
//            arr[i] = arr[i + 1];
//            arr[i + 1] = temp;
//        }
//    }
//    return arr;
//}

//int[] ans = MoveZerosToEnd([0,1,0,3,12]);
//foreach(int n in ans)
//{
//    Console.Write(n + " ");
//}

//int[] MoveZerosToEnd(int[] arr)
//{
//    int insertPos = 0;
//    for(int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] != 0)
//        {
//            arr[insertPos] = arr[i];
//            insertPos++;
//        }

//    }

//    while (insertPos < arr.Length)
//    {
//        arr[insertPos] = 0;
//        insertPos++;
//    }
//    return arr;
//}

//int[] ans = MoveZerosToEnd([0]);
//foreach (int n in ans)
//{
//    Console.Write(n + " ");
//}

//List<int> UnionOfArrays(int[] arr1, int[] arr2)
//{
//    Dictionary<int, int> freq = new Dictionary<int, int>();
//    List<int> union = new List<int>();
//    foreach( int num in arr1)
//    {
//        if (freq.ContainsKey(num))
//        {
//            freq[num]++;
//        }
//        else
//        {
//            freq[num] = 1;
//        }
//    }

//    foreach(int num in arr2)
//    {
//        if (freq.ContainsKey(num))
//        {
//            freq[num]++;
//        }
//        else
//        {
//            freq[num] = 1;
//        }
//    }
//    foreach(var f in freq)
//    {
//        union.Add(f.Key);
//    }

//    return union;
//}

//List<int> ans = UnionOfArrays([1, 2, 3, 4, 5], [2, 3, 4, 4, 5]);
//foreach(int n in ans)
//{
//    Console.Write(n + " ");
//}

//int FindMissingNumber(int[] arr)
//{
//    int n = arr.Length;
//    int s1 = (n * (n + 1)) / 2;
//    int s2 = 0;
//    for(int i = 0; i < arr.Length-1; i++)
//    {
//        s2 += arr[i];
//    }
//    return s1-s2;
//}

//Console.WriteLine(FindMissingNumber([1, 2, 4, 5]));

//List<int> ProductExceptItself(int[] arr)
//{
//    List<int> productArray = new List<int>();
//    for(int i = 0; i < arr.Length; i++)
//    {
//        int product = 1;
//        for(int j = 0; j < arr.Length; j++)
//        {
//            if (i != j)
//            {
//                product *= arr[j];
//            }
//        }
//        productArray.Add(product);
//    }
//    return productArray;
//}

//List<int> ans = ProductExceptItself([-1, 0, 1, 2, 3]);
//foreach(int n in ans)
//{
//    Console.Write(n + " ");
//}

//List<int> TopKFrequent(int[] arr, int k)
//{
//    Dictionary<int, int> freq = new Dictionary<int, int>();
//    foreach(int n in arr)
//    {
//        if (freq.ContainsKey(n))
//        {
//            freq[n]++;
//        }
//        else
//        {
//            freq[n] = 1;
//        }
//    }


//    return freq
//        .OrderByDescending(x => x.Value)
//        .Take(k)
//        .Select(x => x.Key)
//        .ToList(); ;
//}

//List<int> ans = TopKFrequent([7,7],1);
//foreach(int n in ans)
//{
//    Console.Write(n + " ");
//}

//string Encode(string[] strs)
//{
//    string str = "";
//    for(int i = 0; i < strs.Length; i++)
//    {
//        str += strs[i].Length + "#" + strs[i];
//    }
//    return str;
//}

//List<string> Decode(string str)
//{
//    int i = 0;
//    List<string> ansStr = new List<string>();
//    while (i < str.Length)
//    {
//        int j = i;
//        while (str[j] != '#')
//        {
//            j++;
//        }
//        ansStr.Add(str[i, j]);
//        i = j + 1;
//    }
//    return ansStr;
//}

//List<string> Decode(string[] strs)
//{
//    string str = Encode(strs);
//    Console.WriteLine(str);
//    List<string> result = new List<string>();
//    int i = 0;

//    while (i < str.Length)
//    {
//        int j = i;

//        while (str[j] != '#')
//        {
//            j++;
//        }
//        Console.WriteLine(i + " " + j);
//        int length = int.Parse(str.Substring(i, j - i));
//        Console.WriteLine(length);
//        j++;

//        string word = str.Substring(j, length);
//        Console.WriteLine(word);
//        result.Add(word);

//        i = j + length;
//    }

//    return result;
//}

////Console.WriteLine(Decode(["neet", "code", "love", "you"]));

//List<string> ans = Decode(["neet", "code", "love", "you"]);
//foreach (string str in ans)
//{
//    Console.Write(str + " ");
//}

//int LongestConsecutive(int[] nums)
//{
//    int count = 0;
//    for(int i = 0; i < nums.Length; i++)
//    {
//        if (nums.Contains(i))
//        {
//            count++;
//        }
//    }
//    return count;
//}

//Console.WriteLine(LongestConsecutive([1,0,1,2]));

//[0, 3, 7, 2, 5, 8, 4, 6, 0, 1]

//int LongestConsecutive(int[] nums)
//{
//    HashSet<int> hash = new HashSet<int>(nums);
//    int longest = 0;

//    foreach(int n in nums)
//    {
//        if (!hash.Contains(n - 1))
//        {
//            int curr = n;
//            int length = 1;

//            while (hash.Contains(curr + 1))
//            {
//                curr++;
//                length++;
//            }
//            longest = Math.Max(longest, length);
//        }

//    }
//    return longest;
//}

//Console.WriteLine(LongestConsecutive([0, 3, 2, 5, 4, 6, 1, 1]));

//string Encode(string[] strs)
//{
//    string str = "";

//    for(int i = 0; i < strs.Length; i++)
//    {
//        str += strs[i].Length + "#" + strs[i];
//    }
//    return str;
//}

//Console.WriteLine(Encode(["neet", "code", "love", "you"]));


//List<string> Decode(string str)
//{
//    List<string> strs = new List<string>();

//    int i = 0;
//    while (i < str.Length)
//    {
//        int j = i;
//        while (str[j] != '#')
//        {
//            j++;
//        }
//        int length = int.Parse(str.Substring(i, j-i));
//        j++;
//        string word = str.Substring(j, length);
//        strs.Add(word);
//        i = j + length;
//    }
//    return strs;
//}
//string str = Encode(["neet", "code", "love", "you"]);

//List<string> ansStrs = Decode(str);
//foreach(string s in ansStrs)
//{
//    Console.Write(s+" ");
//}

//List<List<string>> GroupAnagrams(string[] strs)
//{
//    Dictionary<string,List<string>> hash= new Dictionary<string, List<string>>();
//    foreach(var s in strs)
//    {
//        char[] str = s.ToCharArray();
//        Array.Sort(str);
//        string word = new string(str);
//        if (!hash.ContainsKey(word))
//        {
//            hash[word] = new List<string>();
//        }

//        hash[word].Add(s);

//    }
//    return hash.Values.ToList();

//}

//List<List<string>> ansStrs = GroupAnagrams(["act", "pots", "tops", "cat", "stop", "hat"]);

//foreach(var s in ansStrs)
//{
//    foreach(var str in s)
//    {
//        Console.Write(str+" ");
//    }
//    Console.WriteLine();
//}

//List<int> TopKFrequentElement(int[] nums,int k)
//{
//    Dictionary<int, int> hash = new Dictionary<int, int>();

//    foreach(int n in nums)
//    {
//        if (hash.ContainsKey(n))
//        {
//            hash[n]++;
//        }
//        else
//        {
//            hash[n] = 1;
//        }
//    }

//    return hash.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToList();

//}

//List<int> ansList = TopKFrequentElement([7, 7], 1);
//foreach(int n in ansList)
//{
//    Console.Write(n + " ");
//}

string Encode(string[] strs)
{
    string str = "";
    foreach(string s in strs)
    {
        str += s.Length + "#" + s;
    }
    return str;
}

//List<string> Decode(string[] strArr)
//{
//    string str = Encode(strArr);
//    List<string> strs = new List<string>();
//    int i = 0;
//    int longest = 0;

//    while (i < str.Length)
//    {
//        int j = i;
//        int length = 0;
//        while (str[j] != '#')
//        {
//            j++;
//        }
//        length = int.Parse(str.Substring(i, j - i));
//        j++;
//        string word = str.Substring(j, length);
//        strs.Add(word);
//        i = length + j;
//    }
//    return strs;
//}

//List<string> ansList = Decode(["neet", "code", "love", "you"]);
//foreach(string s in ansList)
//{
//    Console.Write(s + " ");
//}

//int[] ProductOfArray(int[] nums)
//{
//    int[] ans = new int[nums.Length];
//    for(int i = 0; i < nums.Length; i++)
//    {
//        int product = 1;
//        for(int j = 0; j < nums.Length; j++)
//        {
//            if (i != j)
//            {
//                product *= nums[j];
//            }
//        }
//        ans[i] = product;
//    }
//    return ans;
//}
//int[] ansArr = ProductOfArray([-1, 0, 1, 2, 3]);
//foreach(int n in ansArr)
//{
//    Console.Write(n + " ");
//}


//int LongestConsecutive(int[] nums)
//{
//    HashSet<int> hash = new HashSet<int>(nums);
//    int longest = 0;
//    foreach(int n in nums)
//    {

//        if (!hash.Contains(n - 1))
//        {
//            int j = n;
//            int length = 1;
//            while (hash.Contains(j + 1))
//            {
//                j++;
//                length++;
//            }
//            longest = Math.Max(longest, length);
//        }
//    }
//    return longest;
//}

//Console.WriteLine(LongestConsecutive([0, 3, 2, 5, 4, 6, 1, 1]));

//int[] TwoSum(int[] nums,int target)
//{
//    int[] ans = new int[2];
//    int i = 0;
//    int j = nums.Length - 1;
//    while (i < j)
//    {
//        if (nums[i] + nums[j] == target)
//        {
//            ans[0] = i+1;
//            ans[1] = j+1;
//            break;
//        }
//        else if (nums[i] < nums[j])
//        {
//            j--;
//        }
//        else
//        {
//            i++;
//        }
//    }
//    return ans;
//}

//int[] ans = TwoSum([-1, 0], -1);
//foreach(int i in ans)
//{
//    Console.Write(i + " ");
//}