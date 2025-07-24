namespace Demo.Ex1;

internal class Employee
{
    #region Properties

    public int Id { get; set; }
    public decimal Salary { get; set; }
    public string? Name { get; set; }
    #endregion

    #region Ctor

    public Employee(int id, decimal salary, string name)
    {
        Id = id;
        Salary = salary;
        Name = name;
    }
    #endregion

    #region Override ToS

    public override string ToString()
    {
        return $"Id : {Id} , Name : {Name} , Salary : {Salary}";
    }
    #endregion

    #region OP overloading 
    // == , != 

    // public static bool operator ==(Employee emp1, Employee emp2)
    // {
    //     // obj state 
    //     //return emp1.Id == emp2.Id && emp1.Name == emp2.Name && emp1.Salary == emp2.Salary;
    //     return emp1.Equals(emp2);
    // }
    // public static bool operator != (Employee emp1, Employee emp2)
    // {
    //     return !(emp1 == emp2);
    // }

    public override bool Equals(object? obj)
    {
        Employee? emp = (Employee?)obj;
        if (emp is null) return false;
        
        return this.Id == emp.Id && this.Name == emp.Name && this.Salary == emp.Salary;
    }

    public override int GetHashCode()
    {
        // wrong
        // return this.Id.GetHashCode() + this.Name.GetHashCode() + this.Salary.GetHashCode();
        // return this.Id.GetHashCode() ^ this.Name.GetHashCode() ^ this.Salary.GetHashCode();
        
        // correct
        return HashCode.Combine(this.Id, this.Name, this.Salary);
    }
    
    #endregion
    
}