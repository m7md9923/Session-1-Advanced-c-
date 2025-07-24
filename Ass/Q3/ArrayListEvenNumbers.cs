using System.Collections;

namespace Ass.Q3;

internal static class ArrayListEvenNumbers
{
    public static List<int> PrintEvenNumbers(this IList<int> list)
    {
        List<int> even = new List<int>();
        if(list is not null && list.Count > 0)
        {
            foreach (var item in list)
                if ((item & 1) == 0) even.Add(item); 
        }
        return even;
    }
}