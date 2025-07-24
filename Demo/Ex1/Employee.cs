namespace Demo.Ex1;

internal struct Employee
{
    #region Properties

    public int Id { get; set; }
    public decimal Salary { get; set; }
    public string Name { get; set; }
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

    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // obj state 
        //return emp1.Id == emp2.Id && emp1.Name == emp2.Name && emp1.Salary == emp2.Salary;
        return emp1.Equals(emp2);
    }
    public static bool operator != (Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }
    
    
    
    #endregion
}