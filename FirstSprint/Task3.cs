using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSpring
{
    class Fraction
    {
        readonly int numerator;
        readonly int denominator;
        public Fraction(int numerator, int denominator)
        {
            if (denominator < 0)
            {
                this.numerator = -numerator;
                this.denominator = -denominator;
            }
            else
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction num = Simplify(new Fraction(a.numerator, b.denominator));
            Fraction den = Simplify(new Fraction(b.numerator, a.denominator));
            return Simplify(new Fraction(num.numerator * den.numerator, num.denominator * den.denominator));
        }
        public static Fraction operator -(Fraction a)
        {
            var t = Simplify(a);
            int n = -t.numerator;
            int d = t.denominator;

            return Simplify(new Fraction(n, d));
        }
        public static Fraction operator +(Fraction a)
        {
            return Simplify(a);
        }
        public static Fraction operator +(Fraction obj1, Fraction obj2)
        {
            obj1 = Simplify(obj1);
            obj2 = Simplify(obj2);
            int gcd_ab = GCD(obj1.denominator, obj2.denominator);
            int numer = obj1.numerator * (obj2.denominator / gcd_ab) + obj2.numerator * (obj1.denominator / gcd_ab);
            int denom = obj1.denominator * (obj2.denominator / gcd_ab);
            return Simplify(new Fraction(numer, denom));
        }
        public static Fraction operator -(Fraction obj1, Fraction obj2)
        {
            return Simplify(obj1 + -obj2);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return Simplify(a * new Fraction(b.denominator, b.numerator));
        }
        public static Fraction operator !(Fraction f)
        {
            return Simplify(new Fraction(f.denominator, f.numerator));
        }
        public override string ToString()
        {
            var a = Simplify(this);
            return $"{a.numerator} / {a.denominator}";
        }
        public override bool Equals(object obj)
        {
            Fraction other = obj as Fraction;
            other = Simplify(other);
            var f1 = Simplify(this);
            return (f1.numerator == other.numerator && f1.denominator == other.denominator);
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1.Equals(f2);
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(numerator, denominator);
        }
        private static Fraction Simplify(Fraction a)
        {
            int n = a.numerator;
            int d = a.denominator;
            int gcd_ab = GCD(n, d);
            n /= gcd_ab;
            d /= gcd_ab;
            return new Fraction(n, d);
        }

        private static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (Math.Abs(a) > Math.Abs(b))
                    a %= b;
                else
                    b %= a;
            }

            return Math.Abs(a | b);
        }
    }
}
