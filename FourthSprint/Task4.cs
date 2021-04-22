using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace FirstSpring
{
    public interface IShape : ICloneable
    {
        public double Area()
        {
            return 0;
        }

    }
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area()
        {
            return Length * Width;
        }
        public object Clone()
        {
            return new Rectangle { Length = this.Length, Width = this.Width };
        }
    }
    public class Trapezoid : IShape
    {
        public double Length1 { get; set; }
        public double Length2 { get; set; }
        public double Width { get; set; }
        public double Area()
        {
            return ((Length1 + Length2) * Width) / 2;
        }
        public object Clone()
        {
            return new Trapezoid { Length1 = this.Length1, Width = this.Width, Length2 = this.Length2 };
        }

    }
    class Room<T> : ICloneable, IComparable where T : IShape
    {
        public double Height { get; set; }
        public T Floor { get; set; }

        public object Clone()
        {
            T floor = (T)Floor.Clone();

            return new Room<T> { Height = this.Height, Floor = floor };
        }

        public int CompareTo(object obj)
        {
            Room<T> o = obj as Room<T>;
            if (o != null) return this.Floor.Area().CompareTo(o.Floor.Area());
            else throw new Exception("Unable to Compare");
        }

        public double Volume()
        {
            return Height * Floor.Area();
        }


    }
    public class RoomComparerByVolume<T> : IComparer where T : IShape
    {
        public int Compare(object x, object y)
        {
            Room<T> x1 = x as Room<T>;
            Room<T> y1 = y as Room<T>;
            if (x1.Volume() > y1.Volume()) return 1;
            else if (x1.Volume() < y1.Volume()) return -1;
            else return 0;
        }
    }
}
