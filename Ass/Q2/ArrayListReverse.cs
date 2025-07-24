using System.Collections;

namespace Ass.Q2;

public static class ArrayListReverse
{
    public static void reverse<T>(this IList list)
    {
        if (list is not null &&  list.Count > 0)
        {
            int i = 0 , j = list.Count - 1;
            while (i < j)
            {
                var temp = list[i];
                list[i] = list[j];
                list[j] = temp;
                i++;
                j--;
            }
        }
    }
}