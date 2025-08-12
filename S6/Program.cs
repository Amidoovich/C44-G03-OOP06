using System.Runtime.InteropServices;

namespace S6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Shallow Copy and Deep Copy

            #region Array of value type

            #region Shallow Copy
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3];

            //Console.WriteLine($"Hash Code Of Arr01 = {Arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Hash Code Of Arr02 = {Arr02.GetHashCode()}"); //18643596

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

            #endregion
        }
    }
}
