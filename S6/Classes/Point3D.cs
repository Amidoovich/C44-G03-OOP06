using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6.Classes
{
    internal class Point3D : IComparable<Point3D> , ICloneable
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        #endregion

        #region Constructors

        public Point3D()
        {
            
        }

        public Point3D(int x , int y , int z)
        {
            X= x;
            Y= y;
            Z= z;
        }

        public Point3D(int x , int y) : this (x,y,0)
        {
            
        }

        public Point3D(int x) : this(x,0)
        {
            
        }

        #endregion
        #region Methods

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(Point3D? other)
        {
            int CompreX = this.X.CompareTo(other?.X);
            return CompreX == 0 ? this.Y.CompareTo(other?.Y) : CompreX;

        }

        public object Clone()
        {
            return new Point3D()
            {
                X = this.X,
                Y = this.Y,
                Z = this.Z
            };
        }

        #endregion


    }
}
