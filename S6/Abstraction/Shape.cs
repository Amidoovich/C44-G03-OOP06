using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6.Abstraction
{
    internal abstract class Shape
    {
        protected Shape(decimal D1 , decimal D2)
        {
            Dimo1 = D1;
            Dimo2 = D2;
        }

        public decimal Dimo1 { get; set; }
        public decimal Dimo2 { get; set; }

        public abstract decimal CalcArea();

        public abstract decimal Perimmeter { get; }
    }
    // Class : Class => Inhertince
    // Class : Interface => Implement
    // Struct : Interface => Implement
    // Class : Abstract Class => Inhertince , Implement
    // Concreate Class

    abstract class  RefBase : Shape 
    {
        protected RefBase(decimal D1, decimal D2) : base(D1, D2)
        {
            
        }
        public override decimal CalcArea()
        {
            return Dimo1 * Dimo2;
        }
    }

    class Rectangle : RefBase
    {

        public Rectangle(decimal D1 , decimal D2) : base(D1, D2) 
        {
            
        }
        public override decimal Perimmeter 
        {
            get { return Dimo1 * Dimo2 * 2; }

        }

    }
    class Square : RefBase
    {


        public Square(int Side) : base(Side , Side)
        {
            
        }

        public override decimal Perimmeter
        {
            get { return Dimo1 * 4; }
        }
    }

    class Circle : Shape
    {

        public Circle(decimal Redius) : base(Redius , Redius)
        {
            
        }
        public override decimal Perimmeter
        {
            get { return 2 * Dimo1 * (decimal)Math.PI; }
        }

        public override decimal CalcArea()
        {
            return 3.14m * Dimo1 * Dimo2;
        }
    }


}
