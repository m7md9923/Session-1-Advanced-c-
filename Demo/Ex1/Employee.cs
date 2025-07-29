namespace Demo.Ex1;

internal class Employee : IEquatable<Employee> , IComparable<Employee>
{
    #region Properties

    public int Id { get; set; }
    public decimal Salary { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    #endregion

    #region Ctor

    public Employee(int id, decimal salary, string name , int age)
    {
        Id = id;
        Salary = salary;
        Name = name;
        Age = age;
    }
    #endregion

    #region Override ToS

    public override string ToString()
    {
        return $"Id : {Id} , Name : {Name} , Salary : {Salary} , Age : {Age}";
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

    public override bool Equals(object? obj)
    {
        #region Explicit Casting 

        // Employee? emp = (Employee?)obj;
        // if (emp is null) return false;
        //
        // return this.Id == emp.Id && this.Name == emp.Name && this.Salary == emp.Salary;
        
        #endregion
        
        #region Implicit Casting [Is operator]
        
        // to check the val is from the specified type ot not 
        // cast to the specified type
        
        // if(obj is null)   // check
        //     return false;
        // if(obj is Employee emp) // check & cast
        //     // obj must be employee or any type that inherit from employee
        //     return this.Id == emp.Id && this.Name == emp.Name && this.Salary == emp.Salary;
        // else 
        //     return false;
        //
        #endregion
        
        #region As Operator
        
        // Employee? emp = obj as Employee; // as retrun instance , fail --> null
        // if(emp is null) 
        //     return false;
        // else 
        //     return this.Id == emp.Id && this.Name == emp.Name && this.Salary == emp.Salary;
        //
        #endregion
        
        #region Property Pattern Matching 
        
        if(obj is Employee {Id : int id , Name : string name  , Salary : decimal salary})
            return this.Id == id && this.Name == name && this.Salary == salary;
        else 
            return false;
        
        #endregion
        
    }

    public override int GetHashCode()
    {
        // wrong
        // return this.Id.GetHashCode() + this.Name.GetHashCode() + this.Salary.GetHashCode();
        // return this.Id.GetHashCode() ^ this.Name.GetHashCode() ^ this.Salary.GetHashCode();
        
        // correct
        return HashCode.Combine(this.Id, this.Name, this.Salary);
    }

    public bool Equals(Employee? other)
    {
        return other is not null && this.Id == other.Id && this.Name == other.Name && this.Salary == other.Salary;
    }
    
    #endregion

    public int CompareTo(Employee? other)
    {
        if(other is null) 
            return 1;
        return this.Salary.CompareTo(other.Salary); // compare to inside int 
    }
}