using Demo.Ex1;

namespace Demo.Ex3;

internal class EmployeeNameComparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        if (ReferenceEquals(x, y)) return 0;
        if (y is null) return 1;
        if (x is null) return -1;
        return string.Compare(x?.Name, y?.Name);
    }
}