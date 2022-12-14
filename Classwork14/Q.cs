using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[DeveloperInfo("katescha8", date = "28.11.2022" )]
public class Q
    {
        private double num;
        private double denom;
        public double Denom
        { get { return denom; } set { denom = value; } }
        public double Num
        { get { return num; } set { num = value; } }
        public Q(double num, double denom)
        {
            this.num = num;
            this.denom = denom;
        }
        public Q()
        { }
        public static bool operator ==(Q r1, Q r2)
        {
            return (r1.num == r2.num && r1.denom == r2.denom);
        }
        public static bool operator !=(Q r1, Q r2)
        {
            return !(r1.num == r2.num && r1.denom == r2.denom);
        }
        public override bool Equals(object obj)
        {
            Q r = (Q)obj;
            return (num == r.num && denom == r.denom);
        }
        public static bool operator >(Q r1, Q r2)
        {
            r1.num *= r2.denom;
            r2.num *= r1.denom;
            return r1.num > r2.num;
        }
        public static bool operator <(Q r1, Q r2)
        {
            r1.num *= r2.denom;
            r2.num *= r1.denom;
            return r1.num < r2.num;
        }
        public static bool operator >=(Q r1, Q r2)
        {
            r1.num *= r2.denom;
            r2.num *= r1.denom;
            return r1.num >= r2.num;
        }
        public static bool operator <=(Q r1, Q r2)
        {
            r1.num *= r2.denom;
            r2.num *= r1.denom;
            return r1.num <= r2.num;
        }
        public static Q operator +(Q r1, Q r2)
        {
            Q r3 = new Q();
            r3.num = r1.num * r2.denom + r2.num * r1.denom;
            r3.denom = r1.denom * r2.denom;
            return r3;
        }
        public static Q operator -(Q r1, Q r2)
        {
            Q r3 = new Q();
            r3.num = r1.num * r2.denom - r2.num * r1.denom;
            r3.denom = r1.denom * r2.denom;
            return r3;
        }
        public static Q operator ++(Q r)
        {
            r.num += r.denom;
            return r;
        }
        public static Q operator --(Q r)
        {
            r.num -= r.denom;
            return r;
        }
        public override string ToString()
        {
            return num.ToString() + "/" + denom.ToString();
        }
        public override int GetHashCode()
        {
            return (int)num;
        }
    }
