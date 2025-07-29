using Demo.Ex1;

namespace Demo.Ex2;

internal class EmployeeNameEqualityComparer : IEqualityComparer<Employee>
{
    public bool Equals(Employee? x, Employee? y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (x is null) return false;
        if (y is null) return false;
        if (x.GetType() != y.GetType()) return false;
        return x.Name == y.Name;
    }

    public int GetHashCode(Employee obj)
    {
        return HashCode.Combine(obj.Name);
    }
}