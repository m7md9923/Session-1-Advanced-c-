using Demo.Ex2;

namespace Demo.Ex1;

internal class Helper<T> where T : IEquatable<T>
{
    #region Swap [Non Generic]
    
    #region Swap By Object

    // public static void Swap(ref object a, ref object b)
    // {
    //     object temp = a;
    //     a = b;
    //     b = temp;
    // }
    
    #endregion

    #region Swap Two Int Numbers
    
    // public static void Swap(ref int a, ref int b)
    // {
    //     int temp = a;
    //     a = b;
    //     b = temp;
    // }
    
    #endregion

    #region Swap Two Decimal Numbers

    // public static void Swap(ref decimal a, ref decimal b)
    // {
    //     decimal temp = a;
    //     a = b;
    //     b = temp;
    // }

    #endregion
    
    #region Swap Two Points
    //
    // public static void Swap(ref Point a, ref Point b)
    // {
    //     Point temp = a;
    //     a = b;
    //     b = temp;
    // }
    
    #endregion
    #endregion
    
    #region Swap [Generic]

    // T --> Generic type ==> method level,class level
    // T --> Method level ==> Compiler will detect the type of T based on parameters
    
    
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static void Print<T>(T a)
    {
        Console.WriteLine($"a : {a}");
    }
    #endregion
    
    #region Linear Search [Non Generic]

    // public static int LinearSearch(int[] arr, int target)
    // {
    //     if (arr is not null && arr.Length > 0)
    //     {
    //         for (int i = 0; i < arr.Length; i++)
    //         {
    //             if (arr[i] == target)
    //             {
    //                 return i;
    //             }
    //         }
    //     }
    //     return -1;
    // }
    #endregion
    
    #region Linear Search [Generic]
    
    public static int LinearSearch<T>(T[] arr, T target , IEqualityComparer<T> comparer) where T : IEquatable<T>
    {
        if (arr is not null && arr.Length > 0 && target is not null)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // if (arr[i]?.Equals(target) ?? false) // user defined struct --> not exist  
                // {
                //     // struct --> Equals 
                //     // Class --> == , Equals 
                //     return i;
                // }
                // if (target.Equals(arr[i]))
                //     return i;

                if (comparer.Equals(target, arr[i]))
                    return i;
            }
        }
        return -1;
    }
    #endregion
}