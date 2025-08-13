using System.Xml;
using S6.Classes;

namespace S6
{
    internal class Program
    {
        
        public static void IntializeThePoint(Point3D P)
        {
            if (P is not null)
            {
                bool IsParse;
                int X ,Y , Z ;
                do
                {
                    Console.Write("Please Enter The X : ");
                    IsParse = int.TryParse(Console.ReadLine(), out X);

                } while (!IsParse);
                P.X = X;
                do
                {
                    Console.Write("Please Enter The Y : ");
                    IsParse = int.TryParse(Console.ReadLine(), out Y);

                } while (!IsParse);
                P.Y = Y;
                do
                {
                    Console.Write("Please Enter The Z : ");
                    IsParse = int.TryParse(Console.ReadLine(), out Z);

                } while (!IsParse);
                P.Z = Z;
            }


        }
        static void Main(string[] args)
        {
            #region First Project

            #region Q2
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());
            #endregion

            #region Q3
            //Point3D P1 = new Point3D();
            //Point3D P2 = new Point3D();

            //Console.WriteLine("please Intialize Point 1");
            //IntializeThePoint(P1);
            //Console.WriteLine("please Intialize Point 2");
            //IntializeThePoint(P2);
            //Console.WriteLine(P1);
            //Console.WriteLine(P2);
            #endregion

            #region Q4
            // it work and Compare The Refrence then give not Equal
            //if (P1 == P2)
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");
            #endregion

            #region Q5

            //Point3D[] Points =
            //{
            //    new Point3D() { X = 40 , Y = 100 , Z = 30 },
            //    new Point3D() { X = 40 , Y = 50 , Z = 60 },
            //    new Point3D() { X = 70 , Y = 80 , Z = 90 }

            //};


            //Array.Sort(Points);
            //foreach(Point3D point in Points)
            //{
            //    Console.WriteLine(point);
            //}

            #endregion

            //Point3D point01 = new Point3D(1, 2, 3);
            //Point3D point02 = new Point3D();

            //Console.WriteLine($"Point01 : {point01}");
            //Console.WriteLine($"Point01 Hash Code : {point01.GetHashCode()}");
            //Console.WriteLine($"Point02 : {point02}");
            //Console.WriteLine($"Point02 Hash Code : {point02.GetHashCode()}");
            //point02 = (Point3D)point01.Clone();
            //Console.WriteLine($"Point01 : {point01}");
            //Console.WriteLine($"Point01 Hash Code : {point01.GetHashCode()}");
            //Console.WriteLine($"Point02 : {point02}");
            //Console.WriteLine($"Point02 Hash Code : {point02.GetHashCode()}");


            #endregion
            #region Second Project

            //Console.WriteLine($"Add {Maths.Add(5,5)}");
            //Console.WriteLine($"Substract {Maths.SubStract(5,5)}");
            //Console.WriteLine($"Multiply {Maths.Multiply(5,5)}");
            //Console.WriteLine($"Divide {Maths.Divide(5,0)}");
            //Console.WriteLine($"Divide {Maths.Divide(0,5)}");
            //Console.WriteLine($"Divide {Maths.Divide(5,5)}");

            #endregion
            #region Third Project
            //User user;
            //Discount discount;
            //int Choice , Quantity;
            //bool IsParse;
            //decimal Price;
            //do
            //{
            //    Console.WriteLine("1.Regular User\n2.Permium User\n3.Guest User");
            //    IsParse = int.TryParse(Console.ReadLine(),out Choice); 
            //}
            //while (!IsParse);

            //switch (Choice)
            //{
            //    case 1 :
            //        user = new RegularUser();
            //        break;
            //    case 2 :
            //        user = new PermiumUser();
            //        break;
            //    case 3: 
            //        user = new GuestUser();
            //        break;
            //    default :
            //        user = new GuestUser();
            //        break;
            //}

            //discount = user.GetDiscount();
            //do
            //{
            //    Console.Write("Please Enter The price : ");
            //    IsParse = decimal.TryParse(Console.ReadLine(), out Price);
            //}while (!IsParse);
            //do
            //{
            //    Console.Write("Please Enter The Quantity : ");
            //    IsParse = int.TryParse(Console.ReadLine(), out Quantity);
            //}
            //while (!IsParse);

            //decimal TheDiscount = discount.CalculateDiscount(Price,Quantity);
            //decimal ThePrice = (Price * Quantity) - TheDiscount;


            //Console.WriteLine($"the price = {Price*Quantity:C}");
            //Console.WriteLine($"the Discount = {TheDiscount:C}");
            //Console.WriteLine($"The price after Discount = {ThePrice:C}");










            #endregion
        }
    }
}
