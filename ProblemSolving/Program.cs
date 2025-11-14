// See https://aka.ms/new-console-template for more information


//void PrintStarsPyramid(int n)
//{



//    for(int i=0; i<n; i++)
//    {
//        //Added spaces on left

//        for (int j = 0; j < n - i - 1; j++)
//        {
//            Console.Write(" ");
//        }


//        for (int j = 0; j < 2*i+1; j++)
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
//    for(int i = 0; i < n; i++)
//    {
//        for(int j = 0; j < i; j++)
//        {
//            Console.Write(" ");
//        }

//        for(int j=0;j<(2*n) - (2*i+1);j++)
//        {
//            Console.Write("*");
//        }

//        for(int j = 0; j < i; j++)
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

bool IsPalindrome(int num)
{
    int temp = num;
    int reverseNum = 0;
    while (temp != 0)
    {
        int n = temp % 10;
        reverseNum = reverseNum * 10 + n;
        temp = temp / 10;
    }
    if (num != reverseNum)
    {
        return false;
    }
    return true;
}

Console.WriteLine(IsPalindrome(321));

