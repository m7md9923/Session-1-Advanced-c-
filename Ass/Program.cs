using System.Collections;
using Ass.Q1;
using Ass.Q2;
using Ass.Q3;

namespace Ass;

class Program
{
    static void Main(string[] args)
    {
        #region Assignment

        #region Question 1

        // Range<int> range = new Range<int>(1, 10);
        // Console.WriteLine($"Check val if in range : {range.IsInRange(5)}");
        // Console.WriteLine($"Length of range : {range.Length()}");
        //
        // Range<decimal> range2 = new Range<decimal>(2.2M, 10.6M);
        // Console.WriteLine($"Check val if in range : {range2.IsInRange(5)}");
        // Console.WriteLine($"Length of range : {range2.Length()}");
        
        #endregion
        
        #region Question 2
        
        ArrayList nums = new ArrayList(){1, 2, 3, 4, 5 };
        Console.WriteLine($"Before:");
        foreach (var item in nums)
            Console.Write($"{item}, ");
        Console.WriteLine();
        
        ArrayListReverse.reverse(nums);
        Console.WriteLine($"After:");
        foreach (var item in nums)
            Console.Write($"{item}, ");
        Console.WriteLine();
        
        ArrayList names = new ArrayList() { "hello", "world", "foo", "bar" };
        Console.WriteLine($"Before: ");
        foreach (var item in names)
            Console.Write($"{item}, ");
        Console.WriteLine();
        
        ArrayListReverse.reverse(names);
        Console.WriteLine($"After: ");
        foreach (var item in names)
            Console.Write($"{item}, ");
        Console.WriteLine();
        
        #endregion
        
        #region Question 3
        
        // List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
        // Console.WriteLine($"Before:");
        // foreach (var item in nums)
        //     Console.Write($"{item}, ");
        // Console.WriteLine();
        // List<int> even =  ArrayListEvenNumbers.PrintEvenNumbers(nums);
        // Console.WriteLine($"After:");
        // foreach (var item in even)
        //     Console.Write($"{item}, ");
        // Console.WriteLine();
        
        #endregion

        #region Question 5

        // string s;
        // Console.WriteLine("Enter a string: ");
        // s = Console.ReadLine();
        // Console.WriteLine($"the first non repeated char is :{StringFirstNonRepeatedChar.FirstNonRepeatedChar(s)}");

        #endregion

        #endregion
    }
}