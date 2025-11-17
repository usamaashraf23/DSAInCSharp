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
