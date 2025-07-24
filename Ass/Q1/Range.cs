using System.Numerics;

namespace Ass.Q1;

internal class Range<T> where T : IComparable , INumber<T> 
{

    public T Min { get; set; }
    public T Max { get; set; }
    
    public Range(T min, T max)
    {
        if (min.CompareTo(max) > 0)
            throw new ArgumentException("min val can not be greater than max val");
        Min = min;
        Max = max;
    }
    public bool IsInRange(T value)
    {
        return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
    }

    public T Length()
    {
        return Max - Min;
    }
    
}