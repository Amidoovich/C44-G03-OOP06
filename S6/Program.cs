using System.Runtime.InteropServices;
using System.Text;
using S6.Built_in_Interfaces;

namespace S6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Shallow Copy and Deep Copy

            #region Array of value type

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3];

            //Console.WriteLine($"Hash Code Of Arr01 = {Arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Hash Code Of Arr02 = {Arr02.GetHashCode()}"); //18643596
            #region Shallow Copy

            //Arr02 = Arr01; // Shallow Copy
            //               // Copy Value of Arr01 To Arr02
            //               //Copy Addresses - Happened in Stack
            //               //[Arr01 - Arr02] => have Same Value
            //               //[Arr01 - Arr02] => Refer Same Object 
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"Hash Code Of Arr01 = {Arr01.GetHashCode()}");  //54267293
            //Console.WriteLine($"Hash Code Of Arr02 = {Arr02.GetHashCode()}");  //54267293

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); //1
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); //1

            //Arr01[0] = 100;
            //Console.WriteLine("After Changing");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); //100
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); //100 
            #endregion

            #region Deep Copy

            //object Obj = Arr02;
            //Obj = 10;
            //Obj = 10.2;
            //Obj = true;


            //Arr02 = (int[])Arr01.Clone(); // Deep Copy
            //                              // Happened in Heap
            //                              // Create New Opject with diff and New Identity then return it
            //                              // the new object will have the same object Sate [Data] of Caller [Arr01]
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"Hash Code Of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Hash Code Of Arr02 = {Arr02.GetHashCode()}");
            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); //1
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); //1
            //Arr01[0] = 100;
            //Console.WriteLine("After Changing");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");


            #endregion

            #endregion
            #region Array of Reference Type [string]

            //string[] names01 = { "Omar", "Amr" };
            //string[] names02 = new string[2];

            //Console.WriteLine($"HashCode of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"HashCode of names02 = {names02.GetHashCode()}");
            #region Shallow Copy

            //names02 = names01; // Shallow Copy
            //                   // Copy Value names01 => names02
            //                   // [names01 - names02] => have Same Value
            //                   // [names01 - names02] => Refer to Same Obj

            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"HashCode of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"HashCode of names02 = {names02.GetHashCode()}");

            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");
            //names01[0] = "Salma";
            //Console.WriteLine("After Changing");
            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");
            #endregion
            #region Deep Copy

            //names02 = (string[])names01.Clone(); //Deep Copy
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HashCode of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"HashCode of names02 = {names02.GetHashCode()}");
            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");
            //names01[0] = "Salma";
            //Console.WriteLine("After Changing");
            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");

            #endregion




            #endregion
            #region Array of Reference Type [stringbuilder]

            //StringBuilder[] names01 = new StringBuilder[1];
            //names01[0] = new StringBuilder();
            //// null => Omar
            ////StringBuilder stringBuilder01 = new StringBuilder();
            ////stringBuilder01.Append("Omar");


            ////names01[0] = "Omar";

            //names01[0].Append("Omar"); // NullReferenceException

            ////string[] names02 = new string[1];
            ////names02[0] = "Omar"; // Syntax Sugar 
            ///

            //StringBuilder[] names01 = [new StringBuilder("omar")];
            //StringBuilder[] names02 = new StringBuilder[1];

            //Console.WriteLine($"HashCode of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"HashCode of names02 = {names02.GetHashCode()}");

            #region Shallow Copy
            //names02 = names01;
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"HashCode of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"HashCode of names02 = {names02.GetHashCode()}");

            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");
            //names01[0].Append(" Salma");
            //Console.WriteLine("After Changing");
            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");

            #endregion
            #region Deep Copy

            //names02 = (StringBuilder[])names01.Clone();
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HashCode of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"HashCode of names02 = {names02.GetHashCode()}");
            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");
            //names01[0].Append(" Salma");
            //Console.WriteLine("After Changing");
            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");

            #endregion

            #endregion

            #endregion
            #region Buit-in Interfaces

            #region ICloneable
            //Employee employee01 = new Employee() { Id = 10 , Name = "Omar" , Salary = 5000};
            //Employee employee02 = new Employee() { Id = 20 , Name = "Mona" , Salary = 8000};
            //Console.WriteLine(employee01);
            //Console.WriteLine($"employee01 => {employee01.GetHashCode()}");
            //Console.WriteLine(employee02);
            //Console.WriteLine($"employee02 => {employee02.GetHashCode()}");
            //// Array => Built in class implement interface [ICloneable] => Clone()

            ////employee02 = (Employee)employee01.Clone();
            ////employee02 = new Employee()
            ////{
            ////    Id = employee01.Id,
            ////    Name = employee01.Name,
            ////    Salary = employee01.Salary,
            ////};
            //employee02 = new Employee(employee01);
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine(employee01);
            //Console.WriteLine($"employee01 => {employee01.GetHashCode()}");
            //Console.WriteLine(employee02);
            //Console.WriteLine($"employee02 => {employee02.GetHashCode()}");

            #endregion
            #region ICompareable
            //// int => Built in struct implement interface [ICompareable] => ComparerTo()
            //int[] numbers = { 4, 5, 6, 9, 1, 2, 7, 5 };
            //Array.Sort(numbers);

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Employee[] employees =

            //{
            //    new Employee() {Id = 10 ,Name =  "Omar" , Salary = 6000 },
            //    new Employee() {Id = 20 ,Name =  "Ahmed" , Salary = 10000 },
            //    new Employee() {Id = 30 ,Name =  "Sama" , Salary = 4000 },
            //    new Employee() {Id = 40 ,Name =  "May" , Salary = 5000 },
            //};

            //Array.Sort(employees);
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}

            //Array.Reverse(employees);

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //} 
            #endregion
            #region IComparer

            Employee[] employees =

            {
                new Employee() {Id = 10 ,Name =  "Omar" , Salary = 6000 },
                new Employee() {Id = 20 ,Name =  "Ahmed" , Salary = 10000 },
                new Employee() {Id = 30 ,Name =  "Sama" , Salary = 4000 },
                new Employee() {Id = 40 ,Name =  "May" , Salary = 5000 },
            };
            Array.Sort(employees,new EmployeeNameComparer());
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            #endregion
            #endregion
        }
    }
}
