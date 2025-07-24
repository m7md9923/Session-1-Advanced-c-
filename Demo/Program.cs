namespace Demo;
using Demo.Ex1;

class Program
{
    static void Main(string[] args)
    {
        #region Demo

        #region Ex1 [Swap] [int - decimal - point] 
        
        // object a = 10 , b = 20;
        // Console.WriteLine($"a : {a}");
        // Console.WriteLine($"b : {b}");
        // Helper.Swap(ref a, ref b);
        // Console.WriteLine($"After Swap : ");
        // Console.WriteLine($"a : {a}");
        // Console.WriteLine($"b : {b}");
        //
        // decimal x = 10 , y = 20;
        // Console.WriteLine($"a : {x}");
        // Console.WriteLine($"b : {y}");
        // Helper.Swap(ref x, ref y);
        // Console.WriteLine($"After Swap : ");
        // Console.WriteLine($"a : {x}");
        // Console.WriteLine($"b : {y}");
        //
        // // struct if u create ctor ,he does not remove parameterless ctor
        //
        // Point p1 = new Point(10, 20);
        // Point p2 = new Point(30, 40);
        // Console.WriteLine($"p1 : {p1}");
        // Console.WriteLine($"p2 : {p2}");
        // Console.WriteLine($"After Swap : ");
        // Helper.Swap(ref p1, ref p2);
        // Console.WriteLine($"p1 : {p1}");
        // Console.WriteLine($"p2 : {p2}");
        //
        // int aa = 10 , bb = 20;
        // Console.WriteLine($"a : {aa}");
        // Console.WriteLine($"b : {bb}");
        // Helper.Swap<int>(ref aa, ref bb);
        // Console.WriteLine($"After Swap : ");
        // Console.WriteLine($"a : {aa}");
        // Console.WriteLine($"b : {bb}");
        //
        // Point pp1 = new Point(10, 20);
        // Helper.Print(pp1);
        
        #endregion
        
        #region Ex2 [Linear Search]

        // int[] arr = { 1, 2, 3, 4 ,5};
        // //int target = Helper.LinearSearch(arr, 3);
        // //Console.WriteLine($"Index of target value : {target}");
        //
        // // Point[] points =
        // // {
        // //     new Point(10, 20),
        // //     new Point(30, 40),
        // //     new Point(50, 60),
        // //     new Point(70, 80),
        // //     new Point(90, 100)
        // // };
        //
        // Employee emp1 = new Employee(1, 1000, "mohamed");
        // Employee emp2 = new Employee(1, 2000, "mohamed");
        // Console.WriteLine(emp1.GetHashCode());
        // Console.WriteLine(emp2.GetHashCode());
        // // op overloading --> == , != 
        // if (emp1 == emp2) Console.WriteLine("equal"); // == not defined in uder defined struct 
        // else Console.WriteLine("not equal");
        //
        // // user defined struct -->  Equals
        // // Equals --> value type : compare obj states [compare field by field]
        // // ==> op overloading 
        //
        // // user defined struct -->  Equals
        // // Equals --> obj -->  compare ref
        // // ==> compare ref
        //
        // Employee[] emps =
        // {
        //     new Employee(15, 1000, "mohamed"),
        //     new Employee(2, 8000, "ahmed"),
        //     new Employee(10, 3000, "ali"),
        //     new Employee(30, 4000, "hamada"),
        // };
        // int res = Helper.LinearSearch(emps , new Employee(10, 3000, "ali"));
        // Console.WriteLine($"index of target : {res}");
        
        #endregion

        #endregion
    }
    
}